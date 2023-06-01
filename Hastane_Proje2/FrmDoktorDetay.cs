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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        public string TC;

        private void btnbilgidüzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle fr=new FrmDoktorBilgiDüzenle();
            fr.TCNO = lblTC.Text;
            fr.Show();
        }

        private void btnduyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr=new FrmDuyurular();
            fr.Show();
        }

        private void btnçıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen= dataGridView1.SelectedCells[0].RowIndex;
            rchşikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
