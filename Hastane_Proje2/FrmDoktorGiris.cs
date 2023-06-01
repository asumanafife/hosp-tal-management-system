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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("select*From Tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mstTC.Text);
            komut.Parameters.AddWithValue("@p2", TXsifre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay fr=new FrmDoktorDetay();
                fr.TC = mstTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
            }
            bgl.baglanti();
        }

        private void TXsifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
