using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ConnectDB_Article02_
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
            btRead_Click(sender, e);
        }

        private void btRead_Click(object sender, EventArgs e)
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
                string sql = "insert into Customer values(" + tbId.Text + ",'" + tbName.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                // Cập nhật nhanh lên giao diện mà không cần đọc lại toàn bộ DB
                dgvCustomer.Rows.Add(tbId.Text, tbName.Text);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = "update customer set Name= '" + tbName.Text + "' where id = " + tbId.Text;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                // Cập nhật tên mới ngay trên dòng đang chọn của DataGridView
                int idx = dgvCustomer.CurrentCell.RowIndex;
                dgvCustomer.Rows[idx].Cells[1].Value = tbName.Text;
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                string sql = "delete from Customer where id = " + tbId.Text;
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                // Xóa dòng hiện tại trên giao diện
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