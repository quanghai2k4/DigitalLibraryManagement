using System.Data;
using System.Data.SqlClient;

namespace DigitalLibraryManagement
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=172.21.83.166;Initial Catalog=QuanLyThuVien;Persist Security Info=True;User ID=sa;Password=dylan@2k4;";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);

            btnTacGia.Click += btnTacGia_Click;
            btnNXB.Click += btnNXB_Click;
            btnDauSach.Click += btnDauSach_Click;
            btnDocGia.Click += btnDocGia_Click;
            btnTheLoai.Click += btnTheLoai_Click;
            btnLichSu.Click += btnLichSu_Click;
        }

        private void btnTacGia_Click(object sender, EventArgs e)
        {
            try {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new SqlCommand("SELECT * FROM TacGia", conn);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Dock = DockStyle.Fill;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnNXB_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new SqlCommand("SELECT * FROM NXBi", conn);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Dock = DockStyle.Fill;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnDauSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new SqlCommand("SELECT * FROM DauSach", conn);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Dock = DockStyle.Fill;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new SqlCommand("SELECT * FROM DocGia", conn);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Dock = DockStyle.Fill;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnTheLoai_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new SqlCommand("SELECT * FROM TheLoai", conn);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Dock = DockStyle.Fill;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new SqlCommand("SELECT * FROM LichSu", conn);
                adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Dock = DockStyle.Fill;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
