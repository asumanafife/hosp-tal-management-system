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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;

        sqlbaglantisi bgl=new sqlbaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;

            //Ad Soyad Çekme

            SqlCommand komut = new SqlCommand("Select HastaAd, HastaSoyad From Tbl_Hastalar where HastaTC=@P1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr= komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmiş

            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select*From Tbl_Randevular where HastaTC="+ tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları Çekme

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader dr2= komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd, DoktorSoyad From Tbl_Doktorlar where Doktorbrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr3= komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0]+ " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select*From Tbl_Randevular where randevubrans='" + cmbbrans.Text + "'"+ " and RandevuDoktor='"+cmbdoktor.Text+ "' and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource=dt;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle fr= new FrmBilgiDüzenle();
            fr.TCno= lblTC.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            TXİD.Text = dataGridView2.Rows[secilen].Cells[secilen].Value.ToString();
        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_Randevular set RandevuDurum=1,HastaTC=@P1, HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTC.Text);
            komut.Parameters.AddWithValue("@p2", rchsikayet.Text);
            komut.Parameters.AddWithValue("@p3", TXİD.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
