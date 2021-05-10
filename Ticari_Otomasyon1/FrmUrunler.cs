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

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete From Tbl_Urunler where ID=@p1",bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", TxtId.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
            TxtId.Text = "";

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            TxtId.Text = dr["ID"].ToString();
            TxtUrunAdi.Text = dr["URUNAD"].ToString();
            TxtMarka.Text = dr["MARKA"].ToString();
            TxtModel.Text = dr["MODEL"].ToString();
            MskTxtYil.Text = dr["YIL"].ToString();
            NmrAdet.Value =decimal.Parse(dr["ADET"].ToString());
            TxtAlisFiyat.Text = dr["ALISFIYATI"].ToString();
            TxtSatisFiyat.Text = dr["SATISFIYATI"].ToString();
            RchTxtDetay.Text = dr["DETAY"].ToString();


        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtId.Text = "";
            TxtUrunAdi.Text = "";
            TxtMarka.Text = "";
            TxtModel.Text = "";
            MskTxtYil.Text = "";
            NmrAdet.Value = 0;
            TxtAlisFiyat.Text = "";
            TxtSatisFiyat.Text = "";
            RchTxtDetay.Text = "";
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Tbl_Urunler set URUNAD=@p1, MARKA=@p2, MODEL=@p3, YIL=@p4, ADET=@p5, ALISFIYATI=@p6, SATISFIYATI=@p7, DETAY=@p8 where ID=@p9",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtUrunAdi.Text);
            komut.Parameters.AddWithValue("@p2", TxtMarka.Text);
            komut.Parameters.AddWithValue("@p3", TxtModel.Text);
            komut.Parameters.AddWithValue("@p4", MskTxtYil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((NmrAdet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(TxtAlisFiyat.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(TxtSatisFiyat.Text));
            komut.Parameters.AddWithValue("@p8", RchTxtDetay.Text);
            komut.Parameters.AddWithValue("@p9", TxtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün bilgisi güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            listele();
        }
    }
}
