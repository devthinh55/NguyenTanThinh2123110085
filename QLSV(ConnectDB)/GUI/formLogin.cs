using System;
using System.Windows.Forms;
using QLSV_ConnectDB.GUI; 

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
            // Kiểm tra đăng nhập cơ bản
            if (txtUser.Text == "admin" && txtPass.Text == "123")
            {
                Form1 main = new Form1();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
        }
    }
}