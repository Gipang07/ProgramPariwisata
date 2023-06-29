using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InsertToursm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=DB_ETSM;Integrated Security=True");
        public int IDPariwisata;

        private void label1_Click(object sender, EventArgs e)
        {
            GetToursmshowdata();
        }

        private void GetToursmshowdata()
        {
            SqlCommand cmd = new SqlCommand("select * from PSW_TB", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            Toursmshowdata.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); // Menampilkan Form3
        }

        private bool isValid()
        {
            if (txtnama.Text == string.Empty)
            {
                MessageBox.Show("Nama Pariwisata Diperlukan", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Toursmshowdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IDPariwisata = Convert.ToInt32(Toursmshowdata.SelectedRows[0].Cells[0].Value);
            txtnama.Text = Toursmshowdata.SelectedRows[0].Cells[1].Value.ToString();
            txtharga.Text = Toursmshowdata.SelectedRows[0].Cells[2].Value.ToString();
            txtalamat.Text = Toursmshowdata.SelectedRows[0].Cells[3].Value.ToString();
            txttipe.Text = Toursmshowdata.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetToursmshowdata();
        }
    }
}
