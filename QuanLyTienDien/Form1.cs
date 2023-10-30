using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyTienDien
{


    public partial class Form1 : Form
    {
        static string connString = @"Data Source=SSYI\SQLEXPRESS;Initial Catalog=QUANLYTIENDIEN1;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connString);
        public Form1()
        {
            InitializeComponent();
        }
        private void Xoatextbox()
        {
            tbmakh.Clear();
            tbtenkh.Clear();
            tbloaiho.Clear();
            tbsokw.Clear();
            tbmakh.Focus();// xóa con trỏ
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnluu.Enabled = string.IsNullOrWhiteSpace(this.btnluu.Text);
            this.btnhuybo.Enabled = string.IsNullOrWhiteSpace(this.btnhuybo.Text);

            this.tbmakh.Enabled = !string.IsNullOrWhiteSpace(this.tbmakh.Text);
            this.tbtenkh.Enabled=!string.IsNullOrEmpty(this.tbtenkh.Text);
            this.tbloaiho.Enabled = !string.IsNullOrWhiteSpace(this.tbloaiho.Text);
            this.tbsokw.Enabled = !string.IsNullOrEmpty(this.tbsokw.Text);
            this.tbthanhtien.Enabled =! string.IsNullOrEmpty(this.tbthanhtien.Text);

            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Select*from TIEUTHU", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dgv.DataSource = dt;



                if (conn.State == ConnectionState.Open)
                    conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btnthem_Click(object sender, EventArgs e)
        {
            this.btnluu.Enabled = !string.IsNullOrWhiteSpace(this.btnluu.Text);
            this.btnhuybo.Enabled = !string.IsNullOrWhiteSpace(this.btnhuybo.Text);
            this.tbmakh.Enabled = string.IsNullOrWhiteSpace(this.tbmakh.Text);
            this.tbtenkh.Enabled = string.IsNullOrEmpty(this.tbtenkh.Text);
            this.tbloaiho.Enabled = string.IsNullOrWhiteSpace(this.tbloaiho.Text);
            this.tbsokw.Enabled = string.IsNullOrEmpty(this.tbsokw.Text);
            this.tbthanhtien.Enabled = string.IsNullOrEmpty(this.tbthanhtien.Text);


        }

        //hiển thị khi click dgv sẽ hiển thị lên tb
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv.CurrentRow.Index;
            tbmakh.Text = dgv.Rows[i].Cells[0].Value.ToString();
            tbtenkh.Text = dgv.Rows[i].Cells[1].Value.ToString();
            tbloaiho.Text = dgv.Rows[i].Cells[2].Value.ToString();
            tbsokw.Text = dgv.Rows[i].Cells[3].Value.ToString();
            if (tbloaiho.Text == "KD")
            {
                tbthanhtien.Text = (long.Parse(tbsokw.Text) * 3000).ToString();
            }
            else tbthanhtien.Text = (long.Parse(tbsokw.Text) * 1000).ToString();


        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            Htry
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("update TIEUTHU set TenKH=@tenkh,Loaiho=@loaiho,SoKW=@sokw where MaKH=@makh" , conn);

                cmd.Parameters.AddWithValue("@makh", tbmakh.Text);
                cmd.Parameters.AddWithValue("@tenkh", tbtenkh.Text);
                cmd.Parameters.AddWithValue("@loaiho", tbloaiho.Text);
                cmd.Parameters.AddWithValue("@sokw", tbsokw.Text);
                cmd.ExecuteNonQuery();



                if (conn.State == ConnectionState.Open)
                    conn.Close();
                Form1_Load(sender, e);
                Xoatextbox();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                SqlCommand cmd = new SqlCommand("Delete from TIEUTHU where makh='"+tbmakh.Text+"'", conn);

                DialogResult dg = MessageBox.Show("Bạn có chắn chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dg == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                }

                cmd.Parameters.AddWithValue("@makh", tbmakh.Text);
                cmd.Parameters.AddWithValue("@tenkh", tbtenkh.Text);
                cmd.Parameters.AddWithValue("@loaiho", tbloaiho.Text);
                cmd.Parameters.AddWithValue("@sokw", tbsokw.Text);
                cmd.ExecuteNonQuery();

                if (conn.State == ConnectionState.Open)

                    conn.Close();
                Form1_Load(sender, e);
                Xoatextbox();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel,
        MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (tbmakh.Equals(""))
            {
                MessageBox.Show("Không để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tbtenkh.Equals(""))
            {
                MessageBox.Show("Không để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tbloaiho.Equals(""))
            {
                MessageBox.Show("Không để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (tbsokw.Equals(""))
            {
                MessageBox.Show("Không để trống", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into TIEUTHU values (@makh,@tenkh,@loaiho,@sokw )", conn);
                cmd.Parameters.AddWithValue("@makh", tbmakh.Text);
                cmd.Parameters.AddWithValue("@tenkh", tbtenkh.Text);
                cmd.Parameters.AddWithValue("@loaiho", tbloaiho.Text);
                cmd.Parameters.AddWithValue("@sokw", tbsokw.Text);
                cmd.ExecuteNonQuery();



                if (conn.State == ConnectionState.Open)
                    conn.Close();
                Form1_Load(sender, e);
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void huybo()
        {
            tbmakh.Text = "";
            tbtenkh.Text = "";
            tbloaiho.Text = "";
            tbsokw.Text = "";
        }
   private void btnhuybo_Click(object sender, EventArgs e)
        {
          huybo();
        }

        private void btnreload_Click(object sender, EventArgs e)
        {
            dgv.Refresh();
        }

        private void tbthanhtien_TextChanged(object sender, EventArgs e)
        {
            if (tbloaiho.Text == "KD")
            {
                tbthanhtien.Text = (long.Parse(tbsokw.Text) * 3000).ToString();
            }
            else tbthanhtien.Text = (long.Parse(tbsokw.Text) * 1000).ToString();
        }

    }
}
