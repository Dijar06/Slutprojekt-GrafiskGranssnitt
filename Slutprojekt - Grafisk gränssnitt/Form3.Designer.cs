﻿namespace Slutprojekt___Grafisk_gränssnitt
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            button1 = new Button();
            listBox2 = new ListBox();
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(518, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(249, 178);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(381, 118);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 4;
            button1.Text = "Ta ut pengar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(159, 60);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(174, 139);
            listBox2.TabIndex = 6;
            listBox2.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 36);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 7;
            label1.Text = "Historik:";
            // 
            // button2
            // 
            button2.Location = new Point(381, 89);
            button2.Name = "button2";
            button2.Size = new Size(86, 23);
            button2.TabIndex = 8;
            button2.Text = "Startsida";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(814, 261);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form3";
            Text = "Historik";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private ListBox listBox2;
        private Label label1;
        private Button button2;
    }
}