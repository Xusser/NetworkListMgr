namespace NetworkListMgr
{
    partial class ModifyDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_profileName = new System.Windows.Forms.Label();
            this.profileName = new System.Windows.Forms.TextBox();
            this.lbl_profileDesc = new System.Windows.Forms.Label();
            this.profileDesc = new System.Windows.Forms.TextBox();
            this.lbl_signName = new System.Windows.Forms.Label();
            this.lbl_signDesc = new System.Windows.Forms.Label();
            this.signName = new System.Windows.Forms.TextBox();
            this.signDesc = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_profileName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.profileName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_profileDesc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.profileDesc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_signName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_signDesc, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.signName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.signDesc, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_confirm, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_cancel, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(445, 264);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_profileName
            // 
            this.lbl_profileName.AutoSize = true;
            this.lbl_profileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_profileName.Location = new System.Drawing.Point(19, 18);
            this.lbl_profileName.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.lbl_profileName.Name = "lbl_profileName";
            this.lbl_profileName.Size = new System.Drawing.Size(85, 29);
            this.lbl_profileName.TabIndex = 0;
            this.lbl_profileName.Text = "配置名称";
            this.lbl_profileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.profileName, 3);
            this.profileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileName.Location = new System.Drawing.Point(126, 18);
            this.profileName.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.profileName.Name = "profileName";
            this.profileName.Size = new System.Drawing.Size(300, 25);
            this.profileName.TabIndex = 1;
            this.profileName.TextChanged += new System.EventHandler(this.ProfileName_TextChanged);
            // 
            // lbl_profileDesc
            // 
            this.lbl_profileDesc.AutoSize = true;
            this.lbl_profileDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_profileDesc.Location = new System.Drawing.Point(19, 67);
            this.lbl_profileDesc.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.lbl_profileDesc.Name = "lbl_profileDesc";
            this.lbl_profileDesc.Size = new System.Drawing.Size(85, 29);
            this.lbl_profileDesc.TabIndex = 2;
            this.lbl_profileDesc.Text = "配置描述";
            this.lbl_profileDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileDesc
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.profileDesc, 3);
            this.profileDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileDesc.Location = new System.Drawing.Point(126, 67);
            this.profileDesc.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.profileDesc.Name = "profileDesc";
            this.profileDesc.Size = new System.Drawing.Size(300, 25);
            this.profileDesc.TabIndex = 3;
            // 
            // lbl_signName
            // 
            this.lbl_signName.AutoSize = true;
            this.lbl_signName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_signName.Location = new System.Drawing.Point(19, 116);
            this.lbl_signName.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.lbl_signName.Name = "lbl_signName";
            this.lbl_signName.Size = new System.Drawing.Size(85, 29);
            this.lbl_signName.TabIndex = 4;
            this.lbl_signName.Text = "Sign名称";
            this.lbl_signName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_signDesc
            // 
            this.lbl_signDesc.AutoSize = true;
            this.lbl_signDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_signDesc.Location = new System.Drawing.Point(19, 165);
            this.lbl_signDesc.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.lbl_signDesc.Name = "lbl_signDesc";
            this.lbl_signDesc.Size = new System.Drawing.Size(85, 29);
            this.lbl_signDesc.TabIndex = 5;
            this.lbl_signDesc.Text = "Sign描述";
            this.lbl_signDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.signName, 3);
            this.signName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signName.Location = new System.Drawing.Point(126, 116);
            this.signName.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.signName.Name = "signName";
            this.signName.Size = new System.Drawing.Size(300, 25);
            this.signName.TabIndex = 6;
            // 
            // signDesc
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.signDesc, 3);
            this.signDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signDesc.Location = new System.Drawing.Point(126, 165);
            this.signDesc.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.signDesc.Name = "signDesc";
            this.signDesc.Size = new System.Drawing.Size(300, 25);
            this.signDesc.TabIndex = 7;
            // 
            // btn_confirm
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_confirm, 2);
            this.btn_confirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_confirm.Location = new System.Drawing.Point(233, 214);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(193, 32);
            this.btn_confirm.TabIndex = 8;
            this.btn_confirm.Text = "应用";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // btn_cancel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btn_cancel, 2);
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancel.Location = new System.Drawing.Point(19, 214);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(192, 32);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // ModifyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 264);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ModifyDialog";
            this.Shown += new System.EventHandler(this.ModifyDialog_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_profileName;
        private System.Windows.Forms.TextBox profileName;
        private System.Windows.Forms.Label lbl_profileDesc;
        private System.Windows.Forms.TextBox profileDesc;
        private System.Windows.Forms.Label lbl_signName;
        private System.Windows.Forms.Label lbl_signDesc;
        private System.Windows.Forms.TextBox signName;
        private System.Windows.Forms.TextBox signDesc;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
    }
}