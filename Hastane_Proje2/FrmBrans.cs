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

namespace Hastane_Proje2
{
    public partial class FrmBrans : Form
    {
        public FrmBrans()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void FrmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select* From Tbl_Branslar",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("İnser İnto Tbl_Branslar( BransAd) values (@b1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txbrans.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti();
            MessageBox.Show("Branş Eklendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txbrans.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete From Tbl_Branslar where Bransid=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi");
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update From Tbl_Branslar where Bransid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi");
        }
    }
}
