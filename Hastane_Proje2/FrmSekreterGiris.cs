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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select*From Tbl_Sekreter where SekreterTC=@P1 and sekreterSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",mstTC.Text);
            komut.Parameters.AddWithValue("@p2",TXsifre.Text);
            SqlDataReader dr= komut.ExecuteReader();
            if(dr.Read())
            {
                FrmSekreterDetay frs=new FrmSekreterDetay();
                frs.TCnumara=mstTC.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre");
            }
            bgl.baglanti().Close();
        }

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
