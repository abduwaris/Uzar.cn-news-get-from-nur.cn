namespace GetNurCnNews
{
    partial class UgMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UgMessageBox));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("ALKATIP UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(120, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(108, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ئەسكەرتىش";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(125, 205);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 40);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "ماقۇل";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.SystemColors.Control;
            this.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsg.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMsg.Location = new System.Drawing.Point(12, 47);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ReadOnly = true;
            this.txtMsg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMsg.Size = new System.Drawing.Size(316, 148);
            this.txtMsg.TabIndex = 2;
            // 
            // UgMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(339, 249);
            this.ControlBox = false;
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("ALKATIP Tor", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UgMessageBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtMsg;
    }
}