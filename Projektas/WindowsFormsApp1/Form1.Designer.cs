﻿
namespace WindowsFormsApp1
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
            this.btnPajamos = new System.Windows.Forms.Button();
            this.btnDemoPajamos = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPajamos
            // 
            this.btnPajamos.Location = new System.Drawing.Point(0, 0);
            this.btnPajamos.Name = "btnPajamos";
            this.btnPajamos.Size = new System.Drawing.Size(200, 23);
            this.btnPajamos.TabIndex = 0;
            this.btnPajamos.Text = "Pažiūrėti darbuotojo pajamas";
            this.btnPajamos.UseVisualStyleBackColor = true;
            this.btnPajamos.Click += new System.EventHandler(this.btnPajamos_Click);
            // 
            // btnDemoPajamos
            // 
            this.btnDemoPajamos.Location = new System.Drawing.Point(0, 29);
            this.btnDemoPajamos.Name = "btnDemoPajamos";
            this.btnDemoPajamos.Size = new System.Drawing.Size(200, 23);
            this.btnDemoPajamos.TabIndex = 1;
            this.btnDemoPajamos.Text = "Pajamos pagal pareigas";
            this.btnDemoPajamos.UseVisualStyleBackColor = true;
            this.btnDemoPajamos.Click += new System.EventHandler(this.btnDemoPajamos_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 83);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnDemoPajamos);
            this.Controls.Add(this.btnPajamos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPajamos;
        private System.Windows.Forms.Button btnDemoPajamos;
        private System.Windows.Forms.Button button3;
    }
}

