
namespace WindowsFormsApp1
{
    partial class DarbuotojųPajamos
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
            this.btnParodytiInfo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVardas = new System.Windows.Forms.TextBox();
            this.txtPavardė = new System.Windows.Forms.TextBox();
            this.txtPajamos = new System.Windows.Forms.TextBox();
            this.txtPareigos = new System.Windows.Forms.TextBox();
            this.txtEtatoDalis = new System.Windows.Forms.TextBox();
            this.cmbxDarbuotojoId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pasirinkite norimo darbuotojo Id:";
            // 
            // btnParodytiInfo
            // 
            this.btnParodytiInfo.Location = new System.Drawing.Point(175, 33);
            this.btnParodytiInfo.Name = "btnParodytiInfo";
            this.btnParodytiInfo.Size = new System.Drawing.Size(106, 23);
            this.btnParodytiInfo.TabIndex = 2;
            this.btnParodytiInfo.Text = "Parodyti informaciją";
            this.btnParodytiInfo.UseVisualStyleBackColor = true;
            this.btnParodytiInfo.Click += new System.EventHandler(this.btnParodytiInfo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vardas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pavardė:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pareigos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Etato dalis:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Pajamos:";
            // 
            // txtVardas
            // 
            this.txtVardas.Location = new System.Drawing.Point(175, 62);
            this.txtVardas.Name = "txtVardas";
            this.txtVardas.Size = new System.Drawing.Size(106, 20);
            this.txtVardas.TabIndex = 10;
            // 
            // txtPavardė
            // 
            this.txtPavardė.Location = new System.Drawing.Point(175, 88);
            this.txtPavardė.Name = "txtPavardė";
            this.txtPavardė.Size = new System.Drawing.Size(106, 20);
            this.txtPavardė.TabIndex = 11;
            // 
            // txtPajamos
            // 
            this.txtPajamos.Location = new System.Drawing.Point(175, 166);
            this.txtPajamos.Name = "txtPajamos";
            this.txtPajamos.Size = new System.Drawing.Size(106, 20);
            this.txtPajamos.TabIndex = 12;
            // 
            // txtPareigos
            // 
            this.txtPareigos.Location = new System.Drawing.Point(175, 114);
            this.txtPareigos.Name = "txtPareigos";
            this.txtPareigos.Size = new System.Drawing.Size(106, 20);
            this.txtPareigos.TabIndex = 13;
            // 
            // txtEtatoDalis
            // 
            this.txtEtatoDalis.Location = new System.Drawing.Point(175, 140);
            this.txtEtatoDalis.Name = "txtEtatoDalis";
            this.txtEtatoDalis.Size = new System.Drawing.Size(106, 20);
            this.txtEtatoDalis.TabIndex = 14;
            // 
            // cmbxDarbuotojoId
            // 
            this.cmbxDarbuotojoId.FormattingEnabled = true;
            this.cmbxDarbuotojoId.Location = new System.Drawing.Point(175, 6);
            this.cmbxDarbuotojoId.Name = "cmbxDarbuotojoId";
            this.cmbxDarbuotojoId.Size = new System.Drawing.Size(106, 21);
            this.cmbxDarbuotojoId.TabIndex = 15;
            // 
            // DarbuotojųPajamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 192);
            this.Controls.Add(this.cmbxDarbuotojoId);
            this.Controls.Add(this.txtEtatoDalis);
            this.Controls.Add(this.txtPareigos);
            this.Controls.Add(this.txtPajamos);
            this.Controls.Add(this.txtPavardė);
            this.Controls.Add(this.txtVardas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnParodytiInfo);
            this.Controls.Add(this.label1);
            this.Name = "DarbuotojųPajamos";
            this.Text = "DarbuotojųPajamos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParodytiInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVardas;
        private System.Windows.Forms.TextBox txtPavardė;
        private System.Windows.Forms.TextBox txtPajamos;
        private System.Windows.Forms.TextBox txtPareigos;
        private System.Windows.Forms.TextBox txtEtatoDalis;
        private System.Windows.Forms.ComboBox cmbxDarbuotojoId;
    }
}