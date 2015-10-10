namespace GetNurCnNews
{
    partial class FrmLocalTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLocalTypes));
            this.label1 = new System.Windows.Forms.Label();
            this.lbList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtTypeTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "يەرلىكتىكى خەۋەر تۈر سەپلىمە ھۆججىتى";
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 20;
            this.lbList.Location = new System.Drawing.Point(13, 32);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(208, 144);
            this.lbList.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtTypeTitle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTypeID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(13, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "يېڭىدىن قوشۇش";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 86);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 41);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "قوشۇش";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtTypeTitle
            // 
            this.txtTypeTitle.Location = new System.Drawing.Point(6, 53);
            this.txtTypeTitle.Name = "txtTypeTitle";
            this.txtTypeTitle.Size = new System.Drawing.Size(61, 27);
            this.txtTypeTitle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "يەرلىكتىكى تۈر ئىسمى :";
            // 
            // txtTypeID
            // 
            this.txtTypeID.Location = new System.Drawing.Point(6, 20);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(61, 27);
            this.txtTypeID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "يەرلىكتىكى تۈر نۇمۇرى :";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(144, 321);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 50);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "بولدى";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(13, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "تاللىغاننى ئۆچۈرۈش";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmLocalTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(233, 377);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("ALKATIP Tor Tom", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLocalTypes";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLocalTypes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTypeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTypeTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnDelete;
    }
}