using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetworkListMgr
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public struct NetworkList
        {
            public string signKeyName;
            public bool isManaged;
            public string signDescription;
            public string Category;
            public string signFirstNetwork;
            public string profileGUID;
            public string profileDescription;
            public string profileName;
        };

        private List<NetworkList> NetworkLists = new List<NetworkList>();

        private List<NetworkList> Read()
        {
            RegistryKey managedKey, unmanagedKey;
            string[] keyNames;

            using (RegistryKey signaturesKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures", false))
            {
                managedKey = signaturesKey.OpenSubKey("Managed", false);
                unmanagedKey = signaturesKey.OpenSubKey("Unmanaged", false);
            }

            NetworkLists.Clear();

            // Managed
            keyNames = managedKey.GetSubKeyNames();
            foreach (string keyName in keyNames)
            {
                try
                {
                    NetworkList networkList = new NetworkList();
                    networkList.signKeyName = keyName;
                    networkList.isManaged = true;
                    using (RegistryKey signatureKey = managedKey.OpenSubKey(keyName, false))
                    {
                        networkList.profileGUID = signatureKey.GetValue("ProfileGuid").ToString();
                        networkList.signDescription = signatureKey.GetValue("Description").ToString();
                        networkList.signFirstNetwork = signatureKey.GetValue("FirstNetwork").ToString();
                    }
                    using (RegistryKey profilesKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles", false))
                    {
                        using (RegistryKey profileKey = profilesKey.OpenSubKey(networkList.profileGUID, false))
                        {
                            networkList.profileDescription = profileKey.GetValue("Description").ToString();
                            networkList.profileName = profileKey.GetValue("ProfileName").ToString();
                        }
                    }
                    NetworkLists.Add(networkList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Unmanaged
            keyNames = unmanagedKey.GetSubKeyNames();
            foreach (string keyName in keyNames)
            {
                try
                {
                    NetworkList networkList = new NetworkList();
                    networkList.signKeyName = keyName;
                    networkList.isManaged = false;
                    using (RegistryKey signatureKey = unmanagedKey.OpenSubKey(keyName, false))
                    {
                        networkList.profileGUID = signatureKey.GetValue("ProfileGuid").ToString();
                        networkList.signDescription = signatureKey.GetValue("Description").ToString();
                        networkList.signFirstNetwork = signatureKey.GetValue("FirstNetwork").ToString();
                    }
                    using (RegistryKey profilesKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\NetworkList\\Profiles", false))
                    {
                        using (RegistryKey profileKey = profilesKey.OpenSubKey(networkList.profileGUID, false))
                        {
                            networkList.profileDescription = profileKey.GetValue("Description").ToString();
                            networkList.profileName = profileKey.GetValue("ProfileName").ToString();
                            networkList.Category = profileKey.GetValue("Category").ToString();
                        }
                    }
                    NetworkLists.Add(networkList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return NetworkLists;
        }

        private void Refresh_dataGridView(List<NetworkList> networkLists)
        {
            dataGridView.Rows.Clear();
            dataGridView.DataSource = null;
            //dataGridView.Refresh();

            DataGridViewRow row;

            for (int i = 0; i < networkLists.Count; i++)
            {
                dataGridView.Rows.Add();
                row = dataGridView.Rows[i];

                row.Cells["ProfileName"].Value = networkLists[i].profileName;
                if (networkLists[i].isManaged)
                    row.Cells["Managed"].Value = true;
                else
                    row.Cells["Managed"].Value = false;


                switch (networkLists[i].Category)
                {
                    case "0":
                        row.Cells["Category"].Value = "公用网络";
                        break;
                    case "1":
                        row.Cells["Category"].Value = "专用网络";
                        break;
                    case "2":
                        row.Cells["Category"].Value = "域网络";
                        break;
                    default:
                        row.Cells["Category"].Value = string.Format("未知网络({0})", networkLists[i].Category);
                        break;
                }

                row.Cells["ProfileDesc"].Value = networkLists[i].profileDescription;
                row.Cells["SignFirstNetwork"].Value = networkLists[i].signFirstNetwork;
                row.Cells["SignDesc"].Value = networkLists[i].signDescription;
                row.Cells["GUID"].Value = networkLists[i].profileGUID;
                row.Cells["SignKeyName"].Value = networkLists[i].signKeyName;
                row.Cells["Modify"].Value = "修改";
                row.Cells["Del"].Value = "删除";
            }
            dataGridView.Refresh();

            Text = string.Format("网络位置管理 ({0}个网络位置)", networkLists.Count);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
#if !DEBUG
            dataGridView.Columns["Managed"].Visible = false;
            dataGridView.Columns["ProfileDesc"].Visible = false;
            dataGridView.Columns["SignFirstNetwork"].Visible = false;
            dataGridView.Columns["SignDesc"].Visible = false;
            dataGridView.Columns["GUID"].Visible = false;
            dataGridView.Columns["SignKeyName"].Visible = false;
            Width = Width / 2;
#endif

            Refresh_dataGridView(Read());
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                switch (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    case "修改":
                        NetworkList nl = new NetworkList();
                        nl.signKeyName = senderGrid.Rows[e.RowIndex].Cells["SignKeyName"].Value.ToString();
                        nl.isManaged = (bool)senderGrid.Rows[e.RowIndex].Cells["Managed"].Value;
                        nl.profileName = senderGrid.Rows[e.RowIndex].Cells["ProfileName"].Value.ToString();
                        nl.profileGUID = senderGrid.Rows[e.RowIndex].Cells["GUID"].Value.ToString();
                        nl.profileDescription = senderGrid.Rows[e.RowIndex].Cells["ProfileDesc"].Value.ToString();
                        nl.signDescription = senderGrid.Rows[e.RowIndex].Cells["SignDesc"].Value.ToString();
                        nl.signFirstNetwork = senderGrid.Rows[e.RowIndex].Cells["SignFirstNetwork"].Value.ToString();

                        using (ModifyDialog md = new ModifyDialog(nl))
                        {
                            if (md.ShowDialog() == DialogResult.OK)
                            {
                                Debug.WriteLine(string.Format("Profile[{0}] modified", nl.profileGUID));
                            }
                            else
                            {
                                Debug.WriteLine(string.Format("User cancelled", nl.profileGUID));
                                //MessageBox.Show("用户取消操作");
                            }
                        }
                        break;
                    case "删除":
                        String signKeyPath, profileKeyPath;
                        String warnMessage = null;
                        try
                        {
                            warnMessage += "你即将删除\r\n";
                            if ((bool)senderGrid.Rows[e.RowIndex].Cells["Managed"].Value)
                            {
                                warnMessage += senderGrid.Rows[e.RowIndex].Cells["ProfileName"].Value.ToString() + "（管理型配置）\r\n\r\n";
                                signKeyPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures\Managed\" + senderGrid.Rows[e.RowIndex].Cells["SignKeyName"].Value.ToString();
                                profileKeyPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles\" + senderGrid.Rows[e.RowIndex].Cells["GUID"].Value.ToString();
                            }
                            else
                            {
                                warnMessage += senderGrid.Rows[e.RowIndex].Cells["ProfileName"].Value.ToString() + "（非管理型配置）\r\n\r\n";
                                signKeyPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Signatures\UnManaged\" + senderGrid.Rows[e.RowIndex].Cells["SignKeyName"].Value.ToString();
                                profileKeyPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles\" + senderGrid.Rows[e.RowIndex].Cells["GUID"].Value.ToString();
                            }
                            warnMessage += "signKeyPath=" + signKeyPath + "\r\n\r\n";
                            warnMessage += "profileKeyPath=" + profileKeyPath + "\r\n\r\n请确认";
                            if (MessageBox.Show(warnMessage, "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                RegistryKey delKey = Registry.LocalMachine;
                                delKey.DeleteSubKey(signKeyPath, true);
                                delKey.DeleteSubKey(profileKeyPath, true);
                                delKey.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;
                }

                // 做完以后刷新
                Refresh_dataGridView(Read());
            }
        }
    }
}
