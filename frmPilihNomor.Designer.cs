namespace AntrianCaller
{
    partial class FrmPilihNomor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPilihNomor));
            this.BtnLoketSatu = new System.Windows.Forms.Button();
            this.BtnLoketDua = new System.Windows.Forms.Button();
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
            this.BtnLoketSatu.Click += new System.EventHandler(this.BtnLoketSatu_Click);
            // 
            // BtnLoketDua
            // 
            this.BtnLoketDua.Image = ((System.Drawing.Image)(resources.GetObject("BtnLoketDua.Image")));
            this.BtnLoketDua.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnLoketDua.Location = new System.Drawing.Point(151, 141);
            this.BtnLoketDua.Name = "BtnLoketDua";
            this.BtnLoketDua.Size = new System.Drawing.Size(80, 60);
            this.BtnLoketDua.TabIndex = 1;
            this.BtnLoketDua.Text = "Loket 2";
            this.BtnLoketDua.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLoketDua.UseVisualStyleBackColor = true;
            this.BtnLoketDua.Click += new System.EventHandler(this.BtnLoketDua_Click);
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
            this.BtnLoketTiga.Click += new System.EventHandler(this.BtnLoketTiga_Click);
            // 
            // FrmPilihNomor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.BtnLoketTiga);
            this.Controls.Add(this.BtnLoketDua);
            this.Controls.Add(this.BtnLoketSatu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1200, 450);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPilihNomor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pilih Nomor Loket";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FrmPilihNomor_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPilihNomor_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnLoketSatu;
        private System.Windows.Forms.Button BtnLoketDua;
        private System.Windows.Forms.Button BtnLoketTiga;
    }
}