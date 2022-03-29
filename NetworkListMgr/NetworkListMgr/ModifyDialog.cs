using Microsoft.Win32;
using System;
using System.Windows.Forms;
using static NetworkListMgr.MainForm;

namespace NetworkListMgr
{
    public partial class ModifyDialog : Form
    {
        NetworkList networkList;

        public ModifyDialog(NetworkList net)
        {
            networkList = net;
            InitializeComponent();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(profileName.Text.Trim()))
            {
                MessageBox.Show("配置名称 不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(profileDesc.Text.Trim()))
            {
                MessageBox.Show("配置描述 不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(signName.Text.Trim()))
            {
                MessageBox.Show("Sign名称 不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (string.IsNullOrEmpty(signDesc.Text.Trim()))
            {
                MessageBox.Show("Sign描述 不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // 初始化
                string ProfilePath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles\" + networkList.profileGUID;
                string SignPath;
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

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
            }

            Close();
        }

        private void ModifyDialog_Shown(object sender, EventArgs e)
        {
            Text = "正在修改 " + networkList.profileName;
            if (networkList.isManaged)
                Text += " (管理型)";
            else
                Text += " (非管理型)";

            profileName.Text = networkList.profileName;
            profileDesc.Text = networkList.profileDescription;
            signName.Text = networkList.signFirstNetwork;
            signDesc.Text = networkList.signDescription;

            profileDesc.ReadOnly = true;
            //this.signName.ReadOnly = true;
            //this.signDesc.ReadOnly = true;
        }

        private void ProfileName_TextChanged(object sender, EventArgs e)
        {
            if (networkList.profileName == networkList.signFirstNetwork)
            {
                signName.Text = profileName.Text;
            }
            if (networkList.profileName == networkList.signDescription)
            {
                signDesc.Text = profileName.Text;
            }
        }
    }
}
