namespace AntrianCaller
{
    partial class frmPilihNomor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPilihNomor));
            this.BtnLoketSatu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnLoketTiga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLoketSatu
            // 
            this.BtnLoketSatu.Image = ((System.Drawing.Image)(resources.GetObject("BtnLoketSatu.Image")));
            this.BtnLoketSatu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnLoketSatu.Location = new System.Drawing.Point(28, 141);
            this.BtnLoketSatu.Name = "BtnLoketSatu";
            this.BtnLoketSatu.Size = new System.Drawing.Size(80, 60);
            this.BtnLoketSatu.TabIndex = 0;
            this.BtnLoketSatu.Text = "Loket 1";
            this.BtnLoketSatu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLoketSatu.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(151, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "Loket 2";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnLoketTiga
            // 
            this.BtnLoketTiga.Image = ((System.Drawing.Image)(resources.GetObject("BtnLoketTiga.Image")));
            this.BtnLoketTiga.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnLoketTiga.Location = new System.Drawing.Point(273, 141);
            this.BtnLoketTiga.Name = "BtnLoketTiga";
            this.BtnLoketTiga.Size = new System.Drawing.Size(80, 60);
            this.BtnLoketTiga.TabIndex = 2;
            this.BtnLoketTiga.Text = "Loket 3";
            this.BtnLoketTiga.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLoketTiga.UseVisualStyleBackColor = true;
            // 
            // frmPilihNomor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.BtnLoketTiga);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnLoketSatu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1200, 450);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPilihNomor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pilih Nomor Loket";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoketSatu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnLoketTiga;
    }
}