using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wczytywanie_tekstu
{
    public partial class Form1 : Form
    {
        string lokalizacja;

        public Form1()
        {
            InitializeComponent();
        }

        public void buttonWczytywanie_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
            lokalizacja = openFileDialog1.FileName;

        }

        public void buttonzapis_Click(object sender, EventArgs e)
        {
            if (lokalizacja != null)
            {
                try
                {
                    TextWriter txt = new StreamWriter(lokalizacja);
                    txt.Write(textBox1.Text);
                    txt.Close();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Exception catch here - details  : " + ex.ToString());
                }
            }
        }

        private void buttonZapisDialog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.CheckFileExists =false;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                TextWriter txt = new StreamWriter(saveFileDialog1.FileName);
                txt.Write(textBox1.Text);
                txt.Close();
            }
        }
    }
}
