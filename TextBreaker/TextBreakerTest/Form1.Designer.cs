﻿namespace TextBreakerTest
{
    partial class Form1
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
            this.cmdBreak = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdReadDict = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdBreak
            // 
            this.cmdBreak.Location = new System.Drawing.Point(13, 44);
            this.cmdBreak.Name = "cmdBreak";
            this.cmdBreak.Size = new System.Drawing.Size(130, 35);
            this.cmdBreak.TabIndex = 0;
            this.cmdBreak.Text = "Break";
            this.cmdBreak.UseVisualStyleBackColor = true;
            this.cmdBreak.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 279);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 212);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 85);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 188);
            this.textBox1.TabIndex = 2;
            // 
            // cmdReadDict
            // 
            this.cmdReadDict.Location = new System.Drawing.Point(293, 447);
            this.cmdReadDict.Name = "cmdReadDict";
            this.cmdReadDict.Size = new System.Drawing.Size(130, 35);
            this.cmdReadDict.TabIndex = 3;
            this.cmdReadDict.Text = "ReadDict";
            this.cmdReadDict.UseVisualStyleBackColor = true;
            this.cmdReadDict.Click += new System.EventHandler(this.cmdReadDict_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 507);
            this.Controls.Add(this.cmdReadDict);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmdBreak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBreak;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdReadDict;
    }
}

