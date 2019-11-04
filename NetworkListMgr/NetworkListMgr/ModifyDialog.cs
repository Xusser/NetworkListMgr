using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NetworkListMgr.MainForm;

namespace NetworkListMgr
{
    public partial class ModifyDialog : Form
    {
        NetworkList networkList;

        public ModifyDialog(NetworkList net)
        {
            this.networkList = net;
            InitializeComponent();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.profileName.Text.Trim()))
            {
                MessageBox.Show("配置名称 不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (String.IsNullOrEmpty(this.profileDesc.Text.Trim()))
            {
                MessageBox.Show("配置描述 不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (String.IsNullOrEmpty(this.signName.Text.Trim()))
            {
                MessageBox.Show("Sign名称 不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (String.IsNullOrEmpty(this.signDesc.Text.Trim()))
            {
                MessageBox.Show("Sign描述 不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // 初始化
                String ProfilePath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles\" + networkList.profileGUID;
                String SignPath;
                if (networkList.isManaged)
                    SignPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures\Managed\" + networkList.signKeyName;
                else
                    SignPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures\Unmanaged\" + networkList.signKeyName;
                //Console.WriteLine("ProfilePath:" + ProfilePath);
                //Console.WriteLine("SignPath:" + SignPath);

                RegistryKey modProfileKey = Registry.LocalMachine.OpenSubKey(ProfilePath, true);
                RegistryKey modSignKey = Registry.LocalMachine.OpenSubKey(SignPath, true);

                // 修改Profile
                modProfileKey.SetValue("ProfileName", this.profileName.Text);
                modProfileKey.SetValue("Description", this.profileDesc.Text);
                modProfileKey.Close();

                // 修改Signatures
                modSignKey.SetValue("FirstNetwork", this.signName.Text);
                modSignKey.SetValue("Description", this.signDesc.Text);
                modSignKey.Close();

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Abort;
            }

            this.Close();
        }

        private void ModifyDialog_Shown(object sender, EventArgs e)
        {
            this.Text = "正在修改 " + networkList.profileName;
            if (networkList.isManaged)
                this.Text += " (管理型)";
            else
                this.Text += " (非管理型)";

            this.profileName.Text = networkList.profileName;
            this.profileDesc.Text = networkList.profileDescription;
            this.signName.Text = networkList.signFirstNetwork;
            this.signDesc.Text = networkList.signDescription;

            this.profileDesc.ReadOnly = true;
            //this.signName.ReadOnly = true;
            //this.signDesc.ReadOnly = true;
        }

        private void profileName_TextChanged(object sender, EventArgs e)
        {
            if (networkList.profileName == networkList.signFirstNetwork)
            {
                this.signName.Text = this.profileName.Text;
            }
            if (networkList.profileName == networkList.signDescription)
            {
                this.signDesc.Text = this.profileName.Text;
            }
        }
    }
}
