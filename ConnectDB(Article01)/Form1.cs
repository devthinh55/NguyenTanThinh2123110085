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

namespace ConnectDB_Article01_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btRead_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=sale; User Id=sa; Password=sa");
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            dgvCustomer.Rows.Clear(); // delete cũ trên grid trc khi nạp mới
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
            }
            conn.Close();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=sale; User Id=sa; Password=sa");
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Customer values(5, 'Nguyen Van X')";
            cmd.ExecuteNonQuery();
            conn.Close();
            btRead_Click(sender, e); // gọi lại để cập nhật giao diện
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=sale; User Id=sa; Password=sa");
            conn.Open();
            SqlCommand cmd = new SqlCommand("update customer set Name= 'Nguyen Van Z' where id = 5", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            btRead_Click(sender, e);
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.; Initial Catalog=sale; User Id=sa; Password=sa");
            conn.Open();
            SqlCommand cmd = new SqlCommand("delete from Customer where id = 2", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            btRead_Click(sender, e);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
