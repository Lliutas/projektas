
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
            this.btnPridėti = new System.Windows.Forms.Button();
            this.btnIštrinti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPajamos
            // 
            this.btnPajamos.Location = new System.Drawing.Point(0, 0);
            this.btnPajamos.Name = "btnPajamos";
            this.btnPajamos.Size = new System.Drawing.Size(210, 23);
            this.btnPajamos.TabIndex = 0;
            this.btnPajamos.Text = "Pažiūrėti darbuotojo pajamas";
            this.btnPajamos.UseVisualStyleBackColor = true;
            this.btnPajamos.Click += new System.EventHandler(this.btnPajamos_Click);
            // 
            // btnDemoPajamos
            // 
            this.btnDemoPajamos.Location = new System.Drawing.Point(0, 29);
            this.btnDemoPajamos.Name = "btnDemoPajamos";
            this.btnDemoPajamos.Size = new System.Drawing.Size(210, 23);
            this.btnDemoPajamos.TabIndex = 1;
            this.btnDemoPajamos.Text = "Pajamos pagal pareigas";
            this.btnDemoPajamos.UseVisualStyleBackColor = true;
            this.btnDemoPajamos.Click += new System.EventHandler(this.btnDemoPajamos_Click);
            // 
            // btnPridėti
            // 
            this.btnPridėti.Location = new System.Drawing.Point(0, 58);
            this.btnPridėti.Name = "btnPridėti";
            this.btnPridėti.Size = new System.Drawing.Size(101, 23);
            this.btnPridėti.TabIndex = 2;
            this.btnPridėti.Text = "Pridėti darbuotoją";
            this.btnPridėti.UseVisualStyleBackColor = true;
            this.btnPridėti.Click += new System.EventHandler(this.btnPridėti_Click);
            // 
            // btnIštrinti
            // 
            this.btnIštrinti.Location = new System.Drawing.Point(107, 58);
            this.btnIštrinti.Name = "btnIštrinti";
            this.btnIštrinti.Size = new System.Drawing.Size(103, 23);
            this.btnIštrinti.TabIndex = 3;
            this.btnIštrinti.Text = "Ištrinti darbuotoją";
            this.btnIštrinti.UseVisualStyleBackColor = true;
            this.btnIštrinti.Click += new System.EventHandler(this.btnIštrinti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 83);
            this.Controls.Add(this.btnIštrinti);
            this.Controls.Add(this.btnPridėti);
            this.Controls.Add(this.btnDemoPajamos);
            this.Controls.Add(this.btnPajamos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pajamų skaičiuoklė";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPajamos;
        private System.Windows.Forms.Button btnDemoPajamos;
        private System.Windows.Forms.Button btnPridėti;
        private System.Windows.Forms.Button btnIštrinti;
    }
}

