namespace NetworkListMgr
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ProfileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Managed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProfileDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignFirstNetwork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GUID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SignKeyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Del = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfileName,
            this.Category,
            this.Managed,
            this.ProfileDesc,
            this.SignFirstNetwork,
            this.SignDesc,
            this.GUID,
            this.SignKeyName,
            this.Modify,
            this.Del});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(1266, 538);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProfileName.FillWeight = 1F;
            this.ProfileName.HeaderText = "配置名称";
            this.ProfileName.MinimumWidth = 6;
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.ReadOnly = true;
            this.ProfileName.Width = 116;
            // 
            // Category
            // 
            this.Category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Category.HeaderText = "网络类型";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 116;
            // 
            // Managed
            // 
            this.Managed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Managed.FillWeight = 40.30749F;
            this.Managed.HeaderText = "管理";
            this.Managed.MinimumWidth = 6;
            this.Managed.Name = "Managed";
            this.Managed.ReadOnly = true;
            this.Managed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Managed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Managed.Width = 80;
            // 
            // ProfileDesc
            // 
            this.ProfileDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ProfileDesc.FillWeight = 40.30749F;
            this.ProfileDesc.HeaderText = "配置描述";
            this.ProfileDesc.MinimumWidth = 6;
            this.ProfileDesc.Name = "ProfileDesc";
            this.ProfileDesc.ReadOnly = true;
            this.ProfileDesc.Width = 116;
            // 
            // SignFirstNetwork
            // 
            this.SignFirstNetwork.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SignFirstNetwork.FillWeight = 40.30749F;
            this.SignFirstNetwork.HeaderText = "首选网络";
            this.SignFirstNetwork.MinimumWidth = 6;
            this.SignFirstNetwork.Name = "SignFirstNetwork";
            this.SignFirstNetwork.ReadOnly = true;
            this.SignFirstNetwork.Width = 116;
            // 
            // SignDesc
            // 
            this.SignDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SignDesc.FillWeight = 40.30749F;
            this.SignDesc.HeaderText = "标志描述";
            this.SignDesc.MinimumWidth = 6;
            this.SignDesc.Name = "SignDesc";
            this.SignDesc.ReadOnly = true;
            this.SignDesc.Width = 116;
            // 
            // GUID
            // 
            this.GUID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GUID.FillWeight = 40.30749F;
            this.GUID.HeaderText = "GUID";
            this.GUID.MinimumWidth = 6;
            this.GUID.Name = "GUID";
            this.GUID.ReadOnly = true;
            this.GUID.Width = 80;
            // 
            // SignKeyName
            // 
            this.SignKeyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SignKeyName.FillWeight = 40.30749F;
            this.SignKeyName.HeaderText = "标志键名";
            this.SignKeyName.MinimumWidth = 6;
            this.SignKeyName.Name = "SignKeyName";
            this.SignKeyName.ReadOnly = true;
            this.SignKeyName.Width = 116;
            // 
            // Modify
            // 
            this.Modify.FillWeight = 40.30749F;
            this.Modify.HeaderText = "修改";
            this.Modify.MinimumWidth = 64;
            this.Modify.Name = "Modify";
            this.Modify.ReadOnly = true;
            // 
            // Del
            // 
            this.Del.FillWeight = 40.30749F;
            this.Del.HeaderText = "删除";
            this.Del.MinimumWidth = 64;
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1266, 538);
            this.Controls.Add(this.dataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网络位置管理";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Managed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProfileDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignFirstNetwork;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GUID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SignKeyName;
        private System.Windows.Forms.DataGridViewButtonColumn Modify;
        private System.Windows.Forms.DataGridViewButtonColumn Del;
    }
}

