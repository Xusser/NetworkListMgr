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
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProfileName,
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
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(844, 358);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // ProfileName
            // 
            this.ProfileName.HeaderText = "配置名称";
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.ReadOnly = true;
            // 
            // Managed
            // 
            this.Managed.HeaderText = "管理";
            this.Managed.Name = "Managed";
            this.Managed.ReadOnly = true;
            this.Managed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Managed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ProfileDesc
            // 
            this.ProfileDesc.HeaderText = "配置描述";
            this.ProfileDesc.Name = "ProfileDesc";
            this.ProfileDesc.ReadOnly = true;
            // 
            // SignFirstNetwork
            // 
            this.SignFirstNetwork.HeaderText = "首选网络";
            this.SignFirstNetwork.Name = "SignFirstNetwork";
            this.SignFirstNetwork.ReadOnly = true;
            // 
            // SignDesc
            // 
            this.SignDesc.HeaderText = "标志描述";
            this.SignDesc.Name = "SignDesc";
            this.SignDesc.ReadOnly = true;
            // 
            // GUID
            // 
            this.GUID.HeaderText = "GUID";
            this.GUID.Name = "GUID";
            this.GUID.ReadOnly = true;
            // 
            // SignKeyName
            // 
            this.SignKeyName.HeaderText = "标志键名";
            this.SignKeyName.Name = "SignKeyName";
            this.SignKeyName.ReadOnly = true;
            // 
            // Modify
            // 
            this.Modify.HeaderText = "修改";
            this.Modify.Name = "Modify";
            this.Modify.ReadOnly = true;
            // 
            // Del
            // 
            this.Del.HeaderText = "删除";
            this.Del.Name = "Del";
            this.Del.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 358);
            this.Controls.Add(this.dataGridView);
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

