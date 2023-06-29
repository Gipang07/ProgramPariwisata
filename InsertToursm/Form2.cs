using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace InsertToursm
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=DB_ETSM;Integrated Security=True");
        public int IDPariwisata;

        private void button4_Click(object sender, EventArgs e)
        {
            if (Isvalid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO PSW_TB VALUES (@NamaPSW, @HargaPSW, @AlamatPSW, @TipePSW)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NamaPSW", txtnama.Text);
                cmd.Parameters.AddWithValue("@HargaPSW", txtharga.Text);
                cmd.Parameters.AddWithValue("@AlamatPSW", txtalamat.Text);
                cmd.Parameters.AddWithValue("@TipePSW", txttipe.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Pariwisata Baru telah berhasil Ditambahkan", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEToursmshowdata();

            }
        }

        private bool Isvalid()
        {
            if (txtnama.Text == string.Empty)
            {
                MessageBox.Show("Nama Pariwisata Diperlukan", "failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GetEToursmshowdata();
            ResetFormControl();
        }

        private void GetEToursmshowdata()
        {
            SqlCommand cmd = new SqlCommand("select * from PSW_TB", con);
            DataTable dt = new DataTable();

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            EToursmshowdata.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetFormControl();
        }

        private void ResetFormControl()
        {
            txtnama.Clear();
            txttipe.Clear();
            txtalamat.Clear();
            txtharga.Clear();

            txtnama.Focus();
        }

        private void EToursmshowdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDPariwisata = Convert.ToInt32(EToursmshowdata.SelectedRows[0].Cells[0].Value);
            txtnama.Text = EToursmshowdata.SelectedRows[0].Cells[1].Value.ToString();
            txtharga.Text = EToursmshowdata.SelectedRows[0].Cells[2].Value.ToString();
            txtalamat.Text = EToursmshowdata.SelectedRows[0].Cells[3].Value.ToString();
            txttipe.Text = EToursmshowdata.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (IDPariwisata > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE PSW_TB SET NamaPSW = @NamaPSW, HargaPSW = @HargaPSW, AlamatPSW = @AlamatPSW, TipePSW = @TipePSW  WHERE IDPariwisata = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@NamaPSW", txtnama.Text);
                cmd.Parameters.AddWithValue("@HargaPSW", txtharga.Text);
                cmd.Parameters.AddWithValue("@AlamatPSW", txtalamat.Text);
                cmd.Parameters.AddWithValue("@TipePSW", txttipe.Text);
                cmd.Parameters.AddWithValue("@ID", this.IDPariwisata);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Pariwisata telah berhasil Diupdate", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEToursmshowdata();
                ResetFormControl();

            }
            else
            {

                MessageBox.Show("Tolong Select salah satu pariwisata untuk update ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (IDPariwisata > 0)
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM PSW_TB WHERE IDPariwisata = @ID", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@ID", this.IDPariwisata);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Pariwisata telah berhasil Dihapus", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetEToursmshowdata();
                ResetFormControl();
            }
            else
            {
                MessageBox.Show("Tolong Select salah satu pariwisata untuk dihapus ", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
