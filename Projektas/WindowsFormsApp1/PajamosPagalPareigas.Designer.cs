
namespace WindowsFormsApp1
{
    partial class PajamosPagalPareigas
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
            this.btnParodytiGalimasPajamas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtĮvestisEtatoDalis = new System.Windows.Forms.TextBox();
            this.txtApskaiciuotosPajamos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxPareigosId = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnParodytiGalimasPajamas
            // 
            this.btnParodytiGalimasPajamas.Location = new System.Drawing.Point(68, 56);
            this.btnParodytiGalimasPajamas.Name = "btnParodytiGalimasPajamas";
            this.btnParodytiGalimasPajamas.Size = new System.Drawing.Size(117, 23);
            this.btnParodytiGalimasPajamas.TabIndex = 1;
            this.btnParodytiGalimasPajamas.Text = "Parodyti pajamas";
            this.btnParodytiGalimasPajamas.UseVisualStyleBackColor = true;
            this.btnParodytiGalimasPajamas.Click += new System.EventHandler(this.btnParodytiGalimasPajamas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pareigos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Etato dalis";
            // 
            // txtĮvestisEtatoDalis
            // 
            this.txtĮvestisEtatoDalis.Location = new System.Drawing.Point(68, 30);
            this.txtĮvestisEtatoDalis.Name = "txtĮvestisEtatoDalis";
            this.txtĮvestisEtatoDalis.Size = new System.Drawing.Size(117, 20);
            this.txtĮvestisEtatoDalis.TabIndex = 4;
            // 
            // txtApskaiciuotosPajamos
            // 
            this.txtApskaiciuotosPajamos.Location = new System.Drawing.Point(68, 85);
            this.txtApskaiciuotosPajamos.Name = "txtApskaiciuotosPajamos";
            this.txtApskaiciuotosPajamos.Size = new System.Drawing.Size(117, 20);
            this.txtApskaiciuotosPajamos.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pajamos";
            // 
            // cmbxPareigosId
            // 
            this.cmbxPareigosId.FormattingEnabled = true;
            this.cmbxPareigosId.Location = new System.Drawing.Point(69, 3);
            this.cmbxPareigosId.Name = "cmbxPareigosId";
            this.cmbxPareigosId.Size = new System.Drawing.Size(116, 21);
            this.cmbxPareigosId.TabIndex = 7;
            // 
            // PajamosPagalPareigas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 107);
            this.Controls.Add(this.cmbxPareigosId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApskaiciuotosPajamos);
            this.Controls.Add(this.txtĮvestisEtatoDalis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnParodytiGalimasPajamas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PajamosPagalPareigas";
            this.Text = "Pajamos pagal pareigas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnParodytiGalimasPajamas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtĮvestisEtatoDalis;
        private System.Windows.Forms.TextBox txtApskaiciuotosPajamos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxPareigosId;
    }
}