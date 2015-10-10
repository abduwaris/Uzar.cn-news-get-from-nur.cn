namespace GetNurCnNews
{
    partial class FrmSelectNurNewsType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectNurNewsType));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbTypes = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTypeTitle = new System.Windows.Forms.TextBox();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbTypes);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(283, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "نۇر خەۋەرلىرى تۈرىنى تاللاڭ";
            // 
            // clbTypes
            // 
            this.clbTypes.FormattingEnabled = true;
            this.clbTypes.Location = new System.Drawing.Point(16, 31);
            this.clbTypes.Name = "clbTypes";
            this.clbTypes.Size = new System.Drawing.Size(250, 224);
            this.clbTypes.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtTypeTitle);
            this.groupBox2.Controls.Add(this.txtTypeID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(15, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "يېڭىدىن قوشۇش";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 37);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "قوشۇش";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTypeTitle
            // 
            this.txtTypeTitle.Location = new System.Drawing.Point(16, 54);
            this.txtTypeTitle.Name = "txtTypeTitle";
            this.txtTypeTitle.Size = new System.Drawing.Size(192, 25);
            this.txtTypeTitle.TabIndex = 1;
            // 
            // txtTypeID
            // 
            this.txtTypeID.Location = new System.Drawing.Point(16, 23);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(82, 25);
            this.txtTypeID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "ماۋزوسى :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "نۇر تورىدىكى تۈر نۇمۇرى (سان) :";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(204, 427);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 51);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "بولدى";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(16, 427);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 51);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "تاللانغاننى ئۆچۈرۈش";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmSelectNurNewsType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(307, 482);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("ALKATIP Tor Tom", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectNurNewsType";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSelectNurNewsType_FormClosed);
            this.Load += new System.EventHandler(this.FrmSelectNurNewsType_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clbTypes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTypeTitle;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}