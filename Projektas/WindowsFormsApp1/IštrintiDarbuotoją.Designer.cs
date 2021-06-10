
namespace WindowsFormsApp1
{
    partial class IštrintiDarbuotoją
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxTDarbuotojoId = new System.Windows.Forms.ComboBox();
            this.txtTVardas = new System.Windows.Forms.TextBox();
            this.txtTPavardė = new System.Windows.Forms.TextBox();
            this.btnIštrinti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pavardė";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Darbuotojo Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vardas";
            // 
            // cmbxTDarbuotojoId
            // 
            this.cmbxTDarbuotojoId.FormattingEnabled = true;
            this.cmbxTDarbuotojoId.Location = new System.Drawing.Point(88, 12);
            this.cmbxTDarbuotojoId.Name = "cmbxTDarbuotojoId";
            this.cmbxTDarbuotojoId.Size = new System.Drawing.Size(121, 21);
            this.cmbxTDarbuotojoId.TabIndex = 3;
            // 
            // txtTVardas
            // 
            this.txtTVardas.Location = new System.Drawing.Point(270, 12);
            this.txtTVardas.Name = "txtTVardas";
            this.txtTVardas.Size = new System.Drawing.Size(121, 20);
            this.txtTVardas.TabIndex = 4;
            // 
            // txtTPavardė
            // 
            this.txtTPavardė.Location = new System.Drawing.Point(270, 38);
            this.txtTPavardė.Name = "txtTPavardė";
            this.txtTPavardė.Size = new System.Drawing.Size(121, 20);
            this.txtTPavardė.TabIndex = 5;
            // 
            // btnIštrinti
            // 
            this.btnIštrinti.Location = new System.Drawing.Point(88, 39);
            this.btnIštrinti.Name = "btnIštrinti";
            this.btnIštrinti.Size = new System.Drawing.Size(121, 23);
            this.btnIštrinti.TabIndex = 6;
            this.btnIštrinti.Text = "Ištrinti";
            this.btnIštrinti.UseVisualStyleBackColor = true;
            this.btnIštrinti.Click += new System.EventHandler(this.btnIštrinti_Click);
            // 
            // IštrintiDarbuotoją
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 64);
            this.Controls.Add(this.btnIštrinti);
            this.Controls.Add(this.txtTPavardė);
            this.Controls.Add(this.txtTVardas);
            this.Controls.Add(this.cmbxTDarbuotojoId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IštrintiDarbuotoją";
            this.Text = "Ištrinti darbuotoją";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxTDarbuotojoId;
        private System.Windows.Forms.TextBox txtTVardas;
        private System.Windows.Forms.TextBox txtTPavardė;
        private System.Windows.Forms.Button btnIštrinti;
    }
}