namespace AntrianCaller
{
    partial class FrmMainApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainApp));
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnResetSetup = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSLBottom = new System.Windows.Forms.ToolStripStatusLabel();
            this.TimerMainApp = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Image = ((System.Drawing.Image)(resources.GetObject("BtnStart.Image")));
            this.BtnStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnStart.Location = new System.Drawing.Point(151, 141);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(80, 60);
            this.BtnStart.TabIndex = 0;
            this.BtnStart.Text = "MULAI";
            this.BtnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnResetSetup
            // 
            this.BtnResetSetup.Location = new System.Drawing.Point(295, 301);
            this.BtnResetSetup.Name = "BtnResetSetup";
            this.BtnResetSetup.Size = new System.Drawing.Size(75, 23);
            this.BtnResetSetup.TabIndex = 1;
            this.BtnResetSetup.Text = "RESET";
            this.BtnResetSetup.UseVisualStyleBackColor = true;
            this.BtnResetSetup.Click += new System.EventHandler(this.BtnResetSetup_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLBottom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 327);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(382, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSLBottom
            // 
            this.TSSLBottom.Name = "TSSLBottom";
            this.TSSLBottom.Size = new System.Drawing.Size(116, 20);
            this.TSSLBottom.Text = "StripStatusLabel";
            // 
            // FrmMainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BtnResetSetup);
            this.Controls.Add(this.BtnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1200, 450);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Antrian App";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FrmMainApp_Activated);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnResetSetup;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSLBottom;
        private System.Windows.Forms.Timer TimerMainApp;
    }
}

