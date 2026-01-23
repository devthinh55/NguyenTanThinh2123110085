using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ConnectDB_Article03_
{
    public partial class Form1 : Form
    {
        string strConn = @"Data Source=.; Initial Catalog=sale; User Id=sa; Password=sa";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from customer", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                dgvCustomer.Rows.Clear();
                while (reader.Read())
                {
                    dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
                conn.Close();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = "insert into customer values(@id, @name)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add(new SqlParameter("@id", tbId.Text));
                cmd.Parameters.Add(new SqlParameter("@name", tbName.Text));

                cmd.ExecuteNonQuery();
                conn.Close();

                // Cập nhật lại giao diện
                dgvCustomer.Rows.Add(tbId.Text, tbName.Text);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = "update customer set Name = @name where id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.Add(new SqlParameter("@id", tbId.Text));
                cmd.Parameters.Add(new SqlParameter("@name", tbName.Text));

                cmd.ExecuteNonQuery();
                conn.Close();

                // Cập nhật lại tên trên dòng đang chọn của DataGridView
                int idx = dgvCustomer.CurrentCell.RowIndex;
                dgvCustomer.Rows[idx].Cells[1].Value = tbName.Text;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng có thực sự đang chọn dòng nào không
            if (dgvCustomer.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                // Dùng Parameter để chống xóa nhầm/xóa toàn bộ bảng
                string sql = "delete from Customer where id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@id", tbId.Text));

                cmd.ExecuteNonQuery();
                conn.Close();

                // Xóa dòng hiển thị trên bảng
                int idx = dgvCustomer.CurrentCell.RowIndex;
                dgvCustomer.Rows.RemoveAt(idx);
            }
        }

        private void dgvCustomer_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx >= 0 && dgvCustomer.Rows[idx].Cells[0].Value != null)
            {
                tbId.Text = dgvCustomer.Rows[idx].Cells[0].Value.ToString();
                tbName.Text = dgvCustomer.Rows[idx].Cells[1].Value.ToString();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}