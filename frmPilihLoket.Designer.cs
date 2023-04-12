namespace AntrianCaller
{
    partial class FrmPilihLoket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPilihLoket));
            this.BtnCustomerService = new System.Windows.Forms.Button();
            this.BtnAnalis = new System.Windows.Forms.Button();
            this.BtnKasir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCustomerService
            // 
            this.BtnCustomerService.Image = ((System.Drawing.Image)(resources.GetObject("BtnCustomerService.Image")));
            this.BtnCustomerService.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCustomerService.Location = new System.Drawing.Point(269, 146);
            this.BtnCustomerService.Name = "BtnCustomerService";
            this.BtnCustomerService.Size = new System.Drawing.Size(80, 60);
            this.BtnCustomerService.TabIndex = 5;
            this.BtnCustomerService.Text = "CS";
            this.BtnCustomerService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCustomerService.UseVisualStyleBackColor = true;
            this.BtnCustomerService.Click += new System.EventHandler(this.BtnCustomerService_Click);
            // 
            // BtnAnalis
            // 
            this.BtnAnalis.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnalis.Image")));
            this.BtnAnalis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnAnalis.Location = new System.Drawing.Point(155, 146);
            this.BtnAnalis.Name = "BtnAnalis";
            this.BtnAnalis.Size = new System.Drawing.Size(80, 60);
            this.BtnAnalis.TabIndex = 4;
            this.BtnAnalis.Text = "Analis";
            this.BtnAnalis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAnalis.UseVisualStyleBackColor = true;
            this.BtnAnalis.Click += new System.EventHandler(this.BtnAnalis_Click);
            // 
            // BtnKasir
            // 
            this.BtnKasir.Image = ((System.Drawing.Image)(resources.GetObject("BtnKasir.Image")));
            this.BtnKasir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnKasir.Location = new System.Drawing.Point(37, 146);
            this.BtnKasir.Name = "BtnKasir";
            this.BtnKasir.Size = new System.Drawing.Size(80, 60);
            this.BtnKasir.TabIndex = 3;
            this.BtnKasir.Text = "Kasir";
            this.BtnKasir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnKasir.UseVisualStyleBackColor = true;
            this.BtnKasir.Click += new System.EventHandler(this.BtnKasir_Click);
            // 
            // FrmPilihLoket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.BtnCustomerService);
            this.Controls.Add(this.BtnAnalis);
            this.Controls.Add(this.BtnKasir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1200, 450);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPilihLoket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pilih Loket";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPilihLoket_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCustomerService;
        private System.Windows.Forms.Button BtnAnalis;
        private System.Windows.Forms.Button BtnKasir;
    }
}