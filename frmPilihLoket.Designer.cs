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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAnalis = new System.Windows.Forms.Button();
            this.BtnKasir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(269, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 60);
            this.button1.TabIndex = 5;
            this.button1.Text = "CS";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
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
            // 
            // FrmPilihLoket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnAnalis);
            this.Controls.Add(this.BtnKasir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPilihLoket";
            this.Text = "Pilih Loket";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAnalis;
        private System.Windows.Forms.Button BtnKasir;
    }
}