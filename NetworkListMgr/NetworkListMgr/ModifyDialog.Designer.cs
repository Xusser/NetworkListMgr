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
            this.label1 = new System.Windows.Forms.Label();
            this.profileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.profileDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signName = new System.Windows.Forms.TextBox();
            this.signDesc = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.profileName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.profileDesc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.signName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.signDesc, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_OK, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_Cancel, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 211);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "配置名称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.profileName, 3);
            this.profileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileName.Location = new System.Drawing.Point(94, 14);
            this.profileName.Margin = new System.Windows.Forms.Padding(8);
            this.profileName.Name = "profileName";
            this.profileName.Size = new System.Drawing.Size(226, 21);
            this.profileName.TabIndex = 1;
            this.profileName.TextChanged += new System.EventHandler(this.profileName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(14, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "配置描述";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileDesc
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.profileDesc, 3);
            this.profileDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profileDesc.Location = new System.Drawing.Point(94, 53);
            this.profileDesc.Margin = new System.Windows.Forms.Padding(8);
            this.profileDesc.Name = "profileDesc";
            this.profileDesc.Size = new System.Drawing.Size(226, 21);
            this.profileDesc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(14, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sign名称";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(14, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sign描述";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.signName, 3);
            this.signName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signName.Location = new System.Drawing.Point(94, 92);
            this.signName.Margin = new System.Windows.Forms.Padding(8);
            this.signName.Name = "signName";
            this.signName.Size = new System.Drawing.Size(226, 21);
            this.signName.TabIndex = 6;
            // 
            // signDesc
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.signDesc, 3);
            this.signDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signDesc.Location = new System.Drawing.Point(94, 131);
            this.signDesc.Margin = new System.Windows.Forms.Padding(8);
            this.signDesc.Name = "signDesc";
            this.signDesc.Size = new System.Drawing.Size(226, 21);
            this.signDesc.TabIndex = 7;
            // 
            // button_OK
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button_OK, 2);
            this.button_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OK.Location = new System.Drawing.Point(174, 170);
            this.button_OK.Margin = new System.Windows.Forms.Padding(8);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(146, 27);
            this.button_OK.TabIndex = 8;
            this.button_OK.Text = "应用";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button_Cancel, 2);
            this.button_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Cancel.Location = new System.Drawing.Point(14, 170);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(8);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(144, 27);
            this.button_Cancel.TabIndex = 9;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // ModifyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.tableLayoutPanel1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox profileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox profileDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox signName;
        private System.Windows.Forms.TextBox signDesc;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
    }
}