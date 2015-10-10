namespace GetNurCnNews
{
    partial class FrmHome
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.menuHome = new System.Windows.Forms.MenuStrip();
            this.ھۆججەتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDataBaseReset = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmToFactoryWithoutDB = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmFactory = new System.Windows.Forms.ToolStripMenuItem();
            this.ئاپتۇماتىكمەشغۇلاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCancelAutomaticGet = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmSetAutomaticGet = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnFolder = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNurTypes = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NurID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewsTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NurTypeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NurTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalTypeTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Broser = new System.Windows.Forms.DataGridViewButtonColumn();
            this.NewsLogoImg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.lblPageIndex = new System.Windows.Forms.Label();
            this.btnGetSelectedNews = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.lblNurType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picLoad = new System.Windows.Forms.PictureBox();
            this.menuHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // menuHome
            // 
            this.menuHome.Font = new System.Drawing.Font("ALKATIP Tor Tom", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ھۆججەتToolStripMenuItem,
            this.ئاپتۇماتىكمەشغۇلاتToolStripMenuItem});
            this.menuHome.Location = new System.Drawing.Point(0, 0);
            this.menuHome.Name = "menuHome";
            this.menuHome.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuHome.Size = new System.Drawing.Size(855, 26);
            this.menuHome.TabIndex = 0;
            this.menuHome.Text = "ھۆججەت";
            // 
            // ھۆججەتToolStripMenuItem
            // 
            this.ھۆججەتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDataBaseReset,
            this.toolStripMenuItem3,
            this.tsmToFactoryWithoutDB,
            this.toolStripMenuItem2,
            this.tsmFactory});
            this.ھۆججەتToolStripMenuItem.Name = "ھۆججەتToolStripMenuItem";
            this.ھۆججەتToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
            this.ھۆججەتToolStripMenuItem.Text = "ھۆججەت";
            // 
            // tsmDataBaseReset
            // 
            this.tsmDataBaseReset.Name = "tsmDataBaseReset";
            this.tsmDataBaseReset.Size = new System.Drawing.Size(328, 22);
            this.tsmDataBaseReset.Text = "ساندان ھۆججىتىنى قايتا سەپلەش";
            this.tsmDataBaseReset.Click += new System.EventHandler(this.tsmDataBaseReset_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(325, 6);
            // 
            // tsmToFactoryWithoutDB
            // 
            this.tsmToFactoryWithoutDB.Name = "tsmToFactoryWithoutDB";
            this.tsmToFactoryWithoutDB.Size = new System.Drawing.Size(328, 22);
            this.tsmToFactoryWithoutDB.Text = "ساندان سەپلىمە ھۆججىتىدىن باشقىسىنى قايتا سەپلەش";
            this.tsmToFactoryWithoutDB.Click += new System.EventHandler(this.tsmToFactoryWithoutDB_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(325, 6);
            // 
            // tsmFactory
            // 
            this.tsmFactory.Name = "tsmFactory";
            this.tsmFactory.Size = new System.Drawing.Size(328, 22);
            this.tsmFactory.Text = "زاۋۇت ئەسلىگە قايتۇرۇش";
            this.tsmFactory.Click += new System.EventHandler(this.tsmFactory_Click);
            // 
            // ئاپتۇماتىكمەشغۇلاتToolStripMenuItem
            // 
            this.ئاپتۇماتىكمەشغۇلاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCancelAutomaticGet,
            this.toolStripMenuItem1,
            this.tsmSetAutomaticGet});
            this.ئاپتۇماتىكمەشغۇلاتToolStripMenuItem.Name = "ئاپتۇماتىكمەشغۇلاتToolStripMenuItem";
            this.ئاپتۇماتىكمەشغۇلاتToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.ئاپتۇماتىكمەشغۇلاتToolStripMenuItem.Text = "ئاپتۇماتىك مەشغۇلات";
            this.ئاپتۇماتىكمەشغۇلاتToolStripMenuItem.Visible = false;
            // 
            // tsmCancelAutomaticGet
            // 
            this.tsmCancelAutomaticGet.Name = "tsmCancelAutomaticGet";
            this.tsmCancelAutomaticGet.Size = new System.Drawing.Size(263, 22);
            this.tsmCancelAutomaticGet.Text = "ئاپتۇماتىك يىغىشنى ئەمەلدىن قالدۇرۇش";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(260, 6);
            // 
            // tsmSetAutomaticGet
            // 
            this.tsmSetAutomaticGet.Name = "tsmSetAutomaticGet";
            this.tsmSetAutomaticGet.Size = new System.Drawing.Size(263, 22);
            this.tsmSetAutomaticGet.Text = "ئاپتۇماتىك يىغىشقا تەڭشەش";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnFolder);
            this.splitContainer1.Panel1.Controls.Add(this.txtFolder);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.cmbNurTypes);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer1.Size = new System.Drawing.Size(855, 418);
            this.splitContainer1.SplitterDistance = 37;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(12, 8);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(107, 23);
            this.btnFolder.TabIndex = 4;
            this.btnFolder.Text = "تاللاش";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolder.Location = new System.Drawing.Point(125, 8);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.ReadOnly = true;
            this.txtFolder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFolder.Size = new System.Drawing.Size(305, 23);
            this.txtFolder.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "رەسىم ساقلاش ئورنىنى تاللاش :";
            // 
            // cmbNurTypes
            // 
            this.cmbNurTypes.FormattingEnabled = true;
            this.cmbNurTypes.Location = new System.Drawing.Point(590, 8);
            this.cmbNurTypes.Name = "cmbNurTypes";
            this.cmbNurTypes.Size = new System.Drawing.Size(231, 24);
            this.cmbNurTypes.TabIndex = 1;
            this.cmbNurTypes.SelectedIndexChanged += new System.EventHandler(this.cmbNurTypes_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.picLoad);
            this.splitContainer2.Panel1.Controls.Add(this.dgvShow);
            this.splitContainer2.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnGetAll);
            this.splitContainer2.Panel2.Controls.Add(this.lblPageIndex);
            this.splitContainer2.Panel2.Controls.Add(this.btnGetSelectedNews);
            this.splitContainer2.Panel2.Controls.Add(this.btnNextPage);
            this.splitContainer2.Panel2.Controls.Add(this.btnPrevPage);
            this.splitContainer2.Panel2.Controls.Add(this.lblNurType);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Size = new System.Drawing.Size(855, 377);
            this.splitContainer2.SplitterDistance = 322;
            this.splitContainer2.TabIndex = 0;
            // 
            // dgvShow
            // 
            this.dgvShow.AllowUserToAddRows = false;
            this.dgvShow.AllowUserToDeleteRows = false;
            this.dgvShow.AllowUserToResizeColumns = false;
            this.dgvShow.AllowUserToResizeRows = false;
            this.dgvShow.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvShow.ColumnHeadersHeight = 36;
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.NurID,
            this.NewsTitle,
            this.NurTypeTitle,
            this.NurTypeID,
            this.LocalTypeTitle,
            this.LocalTypeID,
            this.Broser,
            this.NewsLogoImg});
            this.dgvShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShow.GridColor = System.Drawing.SystemColors.Control;
            this.dgvShow.Location = new System.Drawing.Point(0, 0);
            this.dgvShow.MultiSelect = false;
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("ALKATIP Tor Tom", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShow.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvShow.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("ALKATIP Tor Tom", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            this.dgvShow.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvShow.RowTemplate.Height = 35;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(855, 322);
            this.dgvShow.TabIndex = 0;
            this.dgvShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellContentClick);
            // 
            // Select
            // 
            this.Select.DataPropertyName = "Select";
            this.Select.FalseValue = "0";
            this.Select.HeaderText = "تاللاش";
            this.Select.Name = "Select";
            this.Select.TrueValue = "1";
            this.Select.Width = 50;
            // 
            // NurID
            // 
            this.NurID.DataPropertyName = "NurID";
            this.NurID.HeaderText = "NurID";
            this.NurID.Name = "NurID";
            this.NurID.ReadOnly = true;
            this.NurID.Visible = false;
            // 
            // NewsTitle
            // 
            this.NewsTitle.DataPropertyName = "Title";
            this.NewsTitle.HeaderText = "خەۋەر";
            this.NewsTitle.Name = "NewsTitle";
            this.NewsTitle.ReadOnly = true;
            this.NewsTitle.Width = 400;
            // 
            // NurTypeTitle
            // 
            this.NurTypeTitle.DataPropertyName = "NurTypeTitle";
            this.NurTypeTitle.HeaderText = "نۇردىكى تۈرى";
            this.NurTypeTitle.Name = "NurTypeTitle";
            this.NurTypeTitle.ReadOnly = true;
            this.NurTypeTitle.Width = 140;
            // 
            // NurTypeID
            // 
            this.NurTypeID.DataPropertyName = "NurTypeID";
            this.NurTypeID.HeaderText = "NurTypeID";
            this.NurTypeID.Name = "NurTypeID";
            this.NurTypeID.ReadOnly = true;
            this.NurTypeID.Visible = false;
            // 
            // LocalTypeTitle
            // 
            this.LocalTypeTitle.DataPropertyName = "LocalTypeTitle";
            this.LocalTypeTitle.HeaderText = "يەرلىكتىكى تۈرى";
            this.LocalTypeTitle.Name = "LocalTypeTitle";
            this.LocalTypeTitle.ReadOnly = true;
            this.LocalTypeTitle.Width = 140;
            // 
            // LocalTypeID
            // 
            this.LocalTypeID.DataPropertyName = "LocalTypeID";
            this.LocalTypeID.HeaderText = "LocalTypeID";
            this.LocalTypeID.Name = "LocalTypeID";
            this.LocalTypeID.ReadOnly = true;
            this.LocalTypeID.Visible = false;
            // 
            // Broser
            // 
            this.Broser.HeaderText = "كۆرۈش";
            this.Broser.Name = "Broser";
            this.Broser.ReadOnly = true;
            this.Broser.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Broser.Text = "كۆرۈش";
            this.Broser.UseColumnTextForButtonValue = true;
            // 
            // NewsLogoImg
            // 
            this.NewsLogoImg.DataPropertyName = "NewsLogoImg";
            this.NewsLogoImg.HeaderText = "NewsLogoImg";
            this.NewsLogoImg.Name = "NewsLogoImg";
            this.NewsLogoImg.ReadOnly = true;
            this.NewsLogoImg.Visible = false;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(187, 8);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(166, 34);
            this.btnGetAll.TabIndex = 4;
            this.btnGetAll.Text = "ھەممىنى يىغىش";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // lblPageIndex
            // 
            this.lblPageIndex.AutoSize = true;
            this.lblPageIndex.Location = new System.Drawing.Point(528, 17);
            this.lblPageIndex.Name = "lblPageIndex";
            this.lblPageIndex.Size = new System.Drawing.Size(14, 16);
            this.lblPageIndex.TabIndex = 3;
            this.lblPageIndex.Text = "5";
            // 
            // btnGetSelectedNews
            // 
            this.btnGetSelectedNews.Location = new System.Drawing.Point(12, 8);
            this.btnGetSelectedNews.Name = "btnGetSelectedNews";
            this.btnGetSelectedNews.Size = new System.Drawing.Size(169, 34);
            this.btnGetSelectedNews.TabIndex = 0;
            this.btnGetSelectedNews.Text = "تاللانغان خەۋەرلەرنى يىغىش";
            this.btnGetSelectedNews.UseVisualStyleBackColor = true;
            this.btnGetSelectedNews.Click += new System.EventHandler(this.btnGetSelectedNews_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(421, 8);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(89, 34);
            this.btnNextPage.TabIndex = 2;
            this.btnNextPage.Text = "كىيىنكى بەت";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Location = new System.Drawing.Point(560, 8);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(85, 34);
            this.btnPrevPage.TabIndex = 2;
            this.btnPrevPage.Text = "ئالدىنقى بەت";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // lblNurType
            // 
            this.lblNurType.AutoSize = true;
            this.lblNurType.Location = new System.Drawing.Point(683, 17);
            this.lblNurType.Name = "lblNurType";
            this.lblNurType.Size = new System.Drawing.Size(46, 16);
            this.lblNurType.TabIndex = 1;
            this.lblNurType.Text = "خەلىقئارا";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(746, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "نۆۋەتتىكى تۈر :";
            // 
            // picLoad
            // 
            this.picLoad.Image = ((System.Drawing.Image)(resources.GetObject("picLoad.Image")));
            this.picLoad.Location = new System.Drawing.Point(245, 22);
            this.picLoad.Name = "picLoad";
            this.picLoad.Size = new System.Drawing.Size(400, 300);
            this.picLoad.TabIndex = 1;
            this.picLoad.TabStop = false;
            this.picLoad.Visible = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 444);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuHome);
            this.Font = new System.Drawing.Font("ALKATIP Tor Tom", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuHome;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHome";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خەۋەر يىغىش پىرى";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.menuHome.ResumeLayout(false);
            this.menuHome.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuHome;
        private System.Windows.Forms.ToolStripMenuItem ھۆججەتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmFactory;
        private System.Windows.Forms.ToolStripMenuItem tsmDataBaseReset;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnGetSelectedNews;
        private System.Windows.Forms.ComboBox cmbNurTypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNurType;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Label lblPageIndex;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewsTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurTypeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NurTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalTypeTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalTypeID;
        private System.Windows.Forms.DataGridViewButtonColumn Broser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewsLogoImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.ToolStripMenuItem ئاپتۇماتىكمەشغۇلاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmCancelAutomaticGet;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmSetAutomaticGet;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem tsmToFactoryWithoutDB;
        private System.Windows.Forms.PictureBox picLoad;
    }
}

