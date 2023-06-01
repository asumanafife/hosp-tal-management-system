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
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        public string TCNO;
        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = TCNO;

            SqlCommand komut = new SqlCommand("Select*From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr= komut.ExecuteReader();    
            while (dr.Read())
            {
                txad.Text = dr[1].ToString();
                txsoyad.Text = dr[2].ToString();
                cmbbrans.Text = dr[3].ToString();
                txsifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5" , bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txad.Text);
            komut.Parameters.AddWithValue("@p2", txsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@p4", txsifre.Text);
            komut.Parameters.AddWithValue("@p5", msktc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
        }
    }
}
