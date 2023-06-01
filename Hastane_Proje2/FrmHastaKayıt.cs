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
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl=new sqlbaglantisi();
        private void btnkayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1, @p2, @p3, @p4, @p5, @p6)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txad.Text);
            komut.Parameters.AddWithValue("@p2", txsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4", msktelefon.Text);
            komut.Parameters.AddWithValue("@p5", txsifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbcinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Başarıyla Gerçekleşmiştir, Şifreniz: "+ txsifre.Text,"Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
