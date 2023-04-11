namespace AntrianCaller
{
    partial class FrmCaller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaller));
            this.GBInfo = new System.Windows.Forms.GroupBox();
            this.BtnPanggilBaru = new System.Windows.Forms.Button();
            this.BtnPanggilUlang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GBInfo
            // 
            this.GBInfo.Location = new System.Drawing.Point(25, 13);
            this.GBInfo.Name = "GBInfo";
            this.GBInfo.Size = new System.Drawing.Size(345, 244);
            this.GBInfo.TabIndex = 0;
            this.GBInfo.TabStop = false;
            this.GBInfo.Text = "INFO";
            // 
            // BtnPanggilBaru
            // 
            this.BtnPanggilBaru.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPanggilBaru.Image = ((System.Drawing.Image)(resources.GetObject("BtnPanggilBaru.Image")));
            this.BtnPanggilBaru.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPanggilBaru.Location = new System.Drawing.Point(25, 263);
            this.BtnPanggilBaru.Name = "BtnPanggilBaru";
            this.BtnPanggilBaru.Size = new System.Drawing.Size(170, 80);
            this.BtnPanggilBaru.TabIndex = 1;
            this.BtnPanggilBaru.Text = "PANGGIL BARU";
            this.BtnPanggilBaru.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPanggilBaru.UseVisualStyleBackColor = true;
            // 
            // BtnPanggilUlang
            // 
            this.BtnPanggilUlang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPanggilUlang.Image = ((System.Drawing.Image)(resources.GetObject("BtnPanggilUlang.Image")));
            this.BtnPanggilUlang.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPanggilUlang.Location = new System.Drawing.Point(204, 263);
            this.BtnPanggilUlang.Name = "BtnPanggilUlang";
            this.BtnPanggilUlang.Size = new System.Drawing.Size(170, 80);
            this.BtnPanggilUlang.TabIndex = 2;
            this.BtnPanggilUlang.Text = "PANGGIL ULANG";
            this.BtnPanggilUlang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPanggilUlang.UseVisualStyleBackColor = true;
            // 
            // FrmCaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.BtnPanggilBaru);
            this.Controls.Add(this.BtnPanggilUlang);
            this.Controls.Add(this.GBInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1200, 450);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Antrian App";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCaller_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBInfo;
        private System.Windows.Forms.Button BtnPanggilBaru;
        private System.Windows.Forms.Button BtnPanggilUlang;
    }
}