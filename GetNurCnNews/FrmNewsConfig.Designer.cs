namespace GetNurCnNews
{
    partial class FrmNewsConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewsConfig));
            this.gbBox = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gbBox
            // 
            this.gbBox.Location = new System.Drawing.Point(13, 13);
            this.gbBox.Margin = new System.Windows.Forms.Padding(4);
            this.gbBox.Name = "gbBox";
            this.gbBox.Padding = new System.Windows.Forms.Padding(4);
            this.gbBox.Size = new System.Drawing.Size(313, 155);
            this.gbBox.TabIndex = 0;
            this.gbBox.TabStop = false;
            this.gbBox.Text = "نۇر خەۋەرلىرى سېلىشتۇرما جەدىۋىلى";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(210, 175);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(116, 47);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "بولدى";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmNewsConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(334, 234);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.gbBox);
            this.Font = new System.Drawing.Font("ALKATIP Tor Tom", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNewsConfig";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmNewsConfig_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbBox;
        private System.Windows.Forms.Button btnOK;
    }
}