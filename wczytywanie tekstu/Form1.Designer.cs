﻿
namespace wczytywanie_tekstu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonWczytywanie = new System.Windows.Forms.Button();
            this.buttonzapis = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonZapisDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 410);
            this.textBox1.TabIndex = 0;
            // 
            // buttonWczytywanie
            // 
            this.buttonWczytywanie.Location = new System.Drawing.Point(644, 12);
            this.buttonWczytywanie.Name = "buttonWczytywanie";
            this.buttonWczytywanie.Size = new System.Drawing.Size(75, 23);
            this.buttonWczytywanie.TabIndex = 1;
            this.buttonWczytywanie.Text = "Wczytaj plik";
            this.buttonWczytywanie.UseVisualStyleBackColor = true;
            this.buttonWczytywanie.Click += new System.EventHandler(this.buttonWczytywanie_Click);
            // 
            // buttonzapis
            // 
            this.buttonzapis.Location = new System.Drawing.Point(552, 399);
            this.buttonzapis.Name = "buttonzapis";
            this.buttonzapis.Size = new System.Drawing.Size(90, 23);
            this.buttonzapis.TabIndex = 2;
            this.buttonzapis.Text = "zapisz zmiany";
            this.buttonzapis.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonzapis.UseVisualStyleBackColor = true;
            this.buttonzapis.Click += new System.EventHandler(this.buttonzapis_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.InitialDirectory = "C:\\";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // buttonZapisDialog
            // 
            this.buttonZapisDialog.Location = new System.Drawing.Point(698, 399);
            this.buttonZapisDialog.Name = "buttonZapisDialog";
            this.buttonZapisDialog.Size = new System.Drawing.Size(90, 23);
            this.buttonZapisDialog.TabIndex = 3;
            this.buttonZapisDialog.Text = "nowy plik";
            this.buttonZapisDialog.UseVisualStyleBackColor = true;
            this.buttonZapisDialog.Click += new System.EventHandler(this.buttonZapisDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonZapisDialog);
            this.Controls.Add(this.buttonzapis);
            this.Controls.Add(this.buttonWczytywanie);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonWczytywanie;
        private System.Windows.Forms.Button buttonzapis;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonZapisDialog;
    }
}

