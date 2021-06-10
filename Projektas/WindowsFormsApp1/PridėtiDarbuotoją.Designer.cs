
namespace WindowsFormsApp1
{
    partial class Pridėti_darbuotoją
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtPEtatoDalis = new System.Windows.Forms.TextBox();
            this.txtPVardas = new System.Windows.Forms.TextBox();
            this.txtPPavardė = new System.Windows.Forms.TextBox();
            this.cmbxPPareigųId = new System.Windows.Forms.ComboBox();
            this.btnPridėti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vardas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PareigųId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pavardė";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "EtatoDalis";
            // 
            // txtPEtatoDalis
            // 
            this.txtPEtatoDalis.Location = new System.Drawing.Point(62, 81);
            this.txtPEtatoDalis.Name = "txtPEtatoDalis";
            this.txtPEtatoDalis.Size = new System.Drawing.Size(121, 20);
            this.txtPEtatoDalis.TabIndex = 4;
            // 
            // txtPVardas
            // 
            this.txtPVardas.Location = new System.Drawing.Point(62, 2);
            this.txtPVardas.Name = "txtPVardas";
            this.txtPVardas.Size = new System.Drawing.Size(121, 20);
            this.txtPVardas.TabIndex = 5;
            // 
            // txtPPavardė
            // 
            this.txtPPavardė.Location = new System.Drawing.Point(62, 28);
            this.txtPPavardė.Name = "txtPPavardė";
            this.txtPPavardė.Size = new System.Drawing.Size(121, 20);
            this.txtPPavardė.TabIndex = 6;
            // 
            // cmbxPPareigųId
            // 
            this.cmbxPPareigųId.FormattingEnabled = true;
            this.cmbxPPareigųId.Location = new System.Drawing.Point(62, 54);
            this.cmbxPPareigųId.Name = "cmbxPPareigųId";
            this.cmbxPPareigųId.Size = new System.Drawing.Size(121, 21);
            this.cmbxPPareigųId.TabIndex = 7;
            // 
            // btnPridėti
            // 
            this.btnPridėti.Location = new System.Drawing.Point(62, 107);
            this.btnPridėti.Name = "btnPridėti";
            this.btnPridėti.Size = new System.Drawing.Size(121, 23);
            this.btnPridėti.TabIndex = 8;
            this.btnPridėti.Text = "Pridėti";
            this.btnPridėti.UseVisualStyleBackColor = true;
            this.btnPridėti.Click += new System.EventHandler(this.btnPridėti_Click);
            // 
            // Pridėti_darbuotoją
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 131);
            this.Controls.Add(this.btnPridėti);
            this.Controls.Add(this.cmbxPPareigųId);
            this.Controls.Add(this.txtPPavardė);
            this.Controls.Add(this.txtPVardas);
            this.Controls.Add(this.txtPEtatoDalis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Pridėti_darbuotoją";
            this.Text = "Pridėti darbuotoją";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPEtatoDalis;
        private System.Windows.Forms.TextBox txtPVardas;
        private System.Windows.Forms.TextBox txtPPavardė;
        private System.Windows.Forms.ComboBox cmbxPPareigųId;
        private System.Windows.Forms.Button btnPridėti;
    }
}