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

namespace Ticari_Otomasyon1
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler()
        {
            InitializeComponent();
        }

       
        
       
        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {

            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from TBL_URUNLER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;


        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            SqlCommand kayit = new SqlCommand("insert into TBL_URUNLER (URUNAD, MARKA, MODEL, YIL, ADET, ALISFIYATI, SATISFIYATI, DETAY) values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)", bgl.baglanti());
            kayit.Parameters.AddWithValue("@p1", TxtUrunAdi.Text);
            kayit.Parameters.AddWithValue("@p2", TxtMarka.Text);
            kayit.Parameters.AddWithValue("@p3", TxtModel.Text);
            kayit.Parameters.AddWithValue("@p4", MskTxtYil.Text);
            kayit.Parameters.AddWithValue("@p5", int.Parse((NmrAdet.Value).ToString()));
            kayit.Parameters.AddWithValue("@p6", decimal.Parse(TxtAlisFiyat.Text));
            kayit.Parameters.AddWithValue("@p7", decimal.Parse(TxtSatisFiyat.Text));
            kayit.Parameters.AddWithValue("@p8", RchTxtDetay.Text);
            kayit.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            TxtUrunAdi.Text = "";
            TxtMarka.Text = "";
            TxtModel.Text = "";
            MskTxtYil.Text = "";
            NmrAdet.Value = 0;
            TxtAlisFiyat.Text = "";
            TxtSatisFiyat.Text = "";
            RchTxtDetay.Text = "";
        }
    }
}
