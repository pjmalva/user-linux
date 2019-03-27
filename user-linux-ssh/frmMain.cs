using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Renci.SshNet;

namespace user_linux_ssh {
    public partial class frmMain : Form{
        private SshClient sshclient = null;

        private bool isEditing = false;
        private string lastStatus = "";
        private string fileGroups = "groups";

        private string cmdGroups = "getent group {0} | cut -d: -f1";
        private string cmdUsers = "cat /etc/passwd | grep /bin/bash | cut -d: -f1";
        private string cmdUserGroups = "groups {0} | cut -d: -f2";

        private string cmdAddUser = "useradd -p {2} -G {1} {0}";
        private string cmdModUser = "usermod -G {1} {0}";
        private string cmdDelUser = "userdel {0}";

        private string cmdAddSMBUser = "echo -ne '{1}\n{1}\n' | smbpasswd -a {0}";
        private string cmdDelSMBUser = "smbpasswd -x {0}";

        private string cmdModPasswdUser = "echo -ne '{1}\n{1}\n' | passwd {0}";
        private string cmdModPasswdSMBUser = "echo -ne '{1}\n{1}\n' | smbpasswd {0}";

        public frmMain() {
            CenterToScreen();
            InitializeComponent();

            if (!File.Exists(fileGroups)) {
                File.Create(fileGroups);
            }
        }

        private void btnConect_Click(object sender, EventArgs e){
            if(txtUser.Text == "" || txtPasswd.Text == "" || txtServer.Text == "") {
                MessageBox.Show("Erro: Preencha todos os campos!");
                txtServer.Focus();
                return;
            }

            sshclient = new SshClient(
                txtServer.Text,
                Convert.ToInt32(numPort.Value),
                txtUser.Text,
                txtPasswd.Text
            );

            try {
                sshclient.Connect();
                lastStatus = "[Conectato à " + txtServer.Text + " como "+ txtUser.Text +"]";
                txtLog.Text = "Connected.";
                loadData();
            } catch (Exception exp) {
                lastStatus = "[Error: " + exp.Message + "]";
            }
            changeControls();
        }

        private void changeControls() {
            gbxControls.Enabled = sshclient.IsConnected;
            gbxData.Enabled = !sshclient.IsConnected;
            lblStatus.Text = lastStatus;
        }

        private List<string> listUsers() {
            var users = new List<string>();
            foreach (string user in sendCommand(cmdUsers, false).Split('\n')) {
                if(user != String.Empty) {
                    users.Add(user);
                }   
            }
            return users;
        }

        private List<string> listUserGroups(string user) {
            var groups = new List<string>();
            foreach (string group in sendCommand(String.Format(cmdUserGroups, user), false).Split(' ')) {
                if(group != "") groups.Add(group.Trim());
            }
            return groups;
        }

        private List<string> listGroups() {
            var groups = new List<string>();
            foreach (string group_id in File.ReadAllLines(fileGroups)) {
                groups.Add(sendCommand(String.Format(cmdGroups, group_id), false).Trim());
            }
            return groups;
        }

        private void loadData() {
            txtUserName.Clear();
            txtUserPasswd.Clear();

            cblUsers.Items.Clear();
            cblUsers.Items.AddRange(listUsers().ToArray());

            cblGroups.Items.Clear();
            cblGroups.Items.AddRange(listGroups().ToArray());
        }

        private void loadDataUser(string user) {
            txtUserName.Text = user;
            cbxSmb.Checked = true;
            string[] lstGroups = listUserGroups(user).ToArray();

            for (int i = 0; i < cblGroups.Items.Count; i++) {
                cblGroups.SetItemChecked(i, false);
            }

            foreach (string group in lstGroups) {
                int group_id = cblGroups.Items.IndexOf(group);
                if(group_id > -1) cblGroups.SetItemChecked(group_id, true);
            }
        }

        private void btnDesconect_Click(object sender, EventArgs e) {
            sshclient.Disconnect();
            lastStatus = "[Desconectado]";
            changeControls();
        }

        private string sendCommand(string c, bool logging = true) {
            var u = sshclient.RunCommand(c);
            if(logging) txtLog.Text = u.Result + txtLog.Text;
            return u.Result;
        }

        private void btnEdit_Click(object sender, EventArgs e) {
            if(cblUsers.CheckedItems.Count > 1) {
                MessageBox.Show("Erro: Mais de 1 usuário selecionado.");
                return;
            } else if (cblUsers.CheckedItems.Count == 0) {
                MessageBox.Show("Erro: Selecione 1 usuáiro para edita.");
                return;
            }
            isEditing = true;
            loadDataUser(cblUsers.CheckedItems[0].ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            foreach(string user in cblUsers.CheckedItems) {
                sendCommand(String.Format(cmdDelUser, user));
            }
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            string[] selectedGroups;
            selectedGroups = new string[cblGroups.CheckedItems.Count];

            cblGroups.CheckedItems.CopyTo(selectedGroups, 0);
            string groups = String.Join(",", selectedGroups);

            if (isEditing) {
                sendCommand(String.Format(cmdModUser, txtUserName.Text, groups.Trim()));
                if (!cbxSmb.Checked) {
                    sendCommand(String.Format(cmdDelSMBUser, txtUserName.Text));
                }
                isEditing = false;
            } else {
                sendCommand(String.Format(cmdAddUser, txtUserName.Text, groups.Trim(), txtUserPasswd.Text));
                if (cbxSmb.Checked) {
                    sendCommand(String.Format(cmdAddSMBUser, txtUserName.Text, txtUserPasswd.Text));
                }
            }

            loadData();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e) {
            isEditing = false;
        }

        private void btnChangePasswd_Click(object sender, EventArgs e) {
            if (cblUsers.CheckedItems.Count == 0) {
                MessageBox.Show("Erro: Selecione ao menos 1 usuáiro para alterar a senha.");
                return;
            }

            frmChangePasswd frm = new frmChangePasswd(txtPasswd.Text);
            frm.ShowDialog(this);

            if (frm.DialogResult == DialogResult.Yes) {
                string newPasswd = frm.newPasswd;

                foreach(string user in cblUsers.CheckedItems) {
                    sendCommand(String.Format(cmdModPasswdUser, user, newPasswd));
                    sendCommand(String.Format(cmdModPasswdSMBUser, user, newPasswd));
                }
            }

            frm.Dispose();
        }
    }
}
