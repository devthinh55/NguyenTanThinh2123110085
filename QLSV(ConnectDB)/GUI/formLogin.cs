using System;
using System.Windows.Forms;

namespace QLSV_ConnectDB.GUI
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            if (user == "admin" && pass == "123")
            {
                Form1 frm = new Form1();

                frm.FormClosed += (s, args) =>
                {
                    Application.Exit();
                };

                this.Hide();
                frm.Show(); 
            }
            else
            {
                MessageBox.Show(
                    "Sai tài khoản hoặc mật khẩu!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
