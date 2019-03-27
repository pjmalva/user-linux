using System;
using System.Windows.Forms;

namespace user_linux_ssh {
    public partial class frmChangePasswd : Form {
        private string adminPasswd = "";
        public string newPasswd = "";

        public frmChangePasswd(string passwd) {
            adminPasswd = passwd;
            InitializeComponent();
            CenterToParent();
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            if (txtAdminPasswd.Text != adminPasswd) {
                MessageBox.Show("A senha do Administrador esta incorreta.");
                txtAdminPasswd.Focus();
                return;
            }

            if (txtPasswd.Text != txtConfirmPasswd.Text) {
                MessageBox.Show("As senhas não são iguais.");
                txtPasswd.Focus();
                return;
            }

            newPasswd = txtConfirmPasswd.Text;
            DialogResult = DialogResult.Yes;
        }
    }
}
