
namespace Ticari_Otomasyon1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BtnUrunler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnStoklar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnMusteriler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFirmalar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAnasayfa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnPersoneller = new DevExpress.XtraBars.BarButtonItem();
            this.BtnGiderler = new DevExpress.XtraBars.BarButtonItem();
            this.BtnKasa = new DevExpress.XtraBars.BarButtonItem();
            this.BtnNotlar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnBankalar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnRehber = new DevExpress.XtraBars.BarButtonItem();
            this.BtnFaturalar = new DevExpress.XtraBars.BarButtonItem();
            this.BtnAyarlar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.BtnUrunler,
            this.BtnStoklar,
            this.BtnMusteriler,
            this.BtnFirmalar,
            this.BtnAnasayfa,
            this.BtnPersoneller,
            this.BtnGiderler,
            this.BtnKasa,
            this.BtnNotlar,
            this.BtnBankalar,
            this.BtnRehber,
            this.BtnFaturalar,
            this.BtnAyarlar});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1020, 158);
            // 
            // BtnUrunler
            // 
            this.BtnUrunler.Caption = "ÜRÜNLER";
            this.BtnUrunler.Id = 1;
            this.BtnUrunler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunler.ImageOptions.Image")));
            this.BtnUrunler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnUrunler.ImageOptions.LargeImage")));
            this.BtnUrunler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnUrunler.Name = "BtnUrunler";
            this.BtnUrunler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnUrunler_ItemClick);
            // 
            // BtnStoklar
            // 
            this.BtnStoklar.Caption = "STOKLAR";
            this.BtnStoklar.Id = 2;
            this.BtnStoklar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnStoklar.ImageOptions.Image")));
            this.BtnStoklar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnStoklar.ImageOptions.LargeImage")));
            this.BtnStoklar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnStoklar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnStoklar.Name = "BtnStoklar";
            // 
            // BtnMusteriler
            // 
            this.BtnMusteriler.Caption = "MÜŞTERİLER";
            this.BtnMusteriler.Id = 3;
            this.BtnMusteriler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMusteriler.ImageOptions.Image")));
            this.BtnMusteriler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnMusteriler.ImageOptions.LargeImage")));
            this.BtnMusteriler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnMusteriler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnMusteriler.Name = "BtnMusteriler";
            // 
            // BtnFirmalar
            // 
            this.BtnFirmalar.Caption = "FİRMALAR";
            this.BtnFirmalar.Id = 4;
            this.BtnFirmalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFirmalar.ImageOptions.Image")));
            this.BtnFirmalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnFirmalar.ImageOptions.LargeImage")));
            this.BtnFirmalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnFirmalar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnFirmalar.Name = "BtnFirmalar";
            // 
            // BtnAnasayfa
            // 
            this.BtnAnasayfa.Caption = "ANA SAYFA";
            this.BtnAnasayfa.Id = 5;
            this.BtnAnasayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnasayfa.ImageOptions.Image")));
            this.BtnAnasayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAnasayfa.ImageOptions.LargeImage")));
            this.BtnAnasayfa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnAnasayfa.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnAnasayfa.Name = "BtnAnasayfa";
            // 
            // BtnPersoneller
            // 
            this.BtnPersoneller.Caption = "PERSONELLER";
            this.BtnPersoneller.Id = 6;
            this.BtnPersoneller.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnPersoneller.ImageOptions.Image")));
            this.BtnPersoneller.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnPersoneller.ImageOptions.LargeImage")));
            this.BtnPersoneller.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnPersoneller.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnPersoneller.Name = "BtnPersoneller";
            // 
            // BtnGiderler
            // 
            this.BtnGiderler.Caption = "GİDERLER";
            this.BtnGiderler.Id = 7;
            this.BtnGiderler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGiderler.ImageOptions.Image")));
            this.BtnGiderler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnGiderler.ImageOptions.LargeImage")));
            this.BtnGiderler.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnGiderler.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnGiderler.Name = "BtnGiderler";
            // 
            // BtnKasa
            // 
            this.BtnKasa.Caption = "KASA";
            this.BtnKasa.Id = 8;
            this.BtnKasa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKasa.ImageOptions.Image")));
            this.BtnKasa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnKasa.ImageOptions.LargeImage")));
            this.BtnKasa.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnKasa.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnKasa.Name = "BtnKasa";
            // 
            // BtnNotlar
            // 
            this.BtnNotlar.Caption = "NOTLAR";
            this.BtnNotlar.Id = 9;
            this.BtnNotlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnNotlar.ImageOptions.Image")));
            this.BtnNotlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnNotlar.ImageOptions.LargeImage")));
            this.BtnNotlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnNotlar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnNotlar.Name = "BtnNotlar";
            // 
            // BtnBankalar
            // 
            this.BtnBankalar.Caption = "BANKALAR";
            this.BtnBankalar.Id = 10;
            this.BtnBankalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnBankalar.ImageOptions.Image")));
            this.BtnBankalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnBankalar.ImageOptions.LargeImage")));
            this.BtnBankalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnBankalar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnBankalar.Name = "BtnBankalar";
            // 
            // BtnRehber
            // 
            this.BtnRehber.Caption = "REHBER";
            this.BtnRehber.Id = 11;
            this.BtnRehber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRehber.ImageOptions.Image")));
            this.BtnRehber.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnRehber.ImageOptions.LargeImage")));
            this.BtnRehber.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnRehber.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnRehber.Name = "BtnRehber";
            // 
            // BtnFaturalar
            // 
            this.BtnFaturalar.Caption = "FATURALAR";
            this.BtnFaturalar.Id = 12;
            this.BtnFaturalar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnFaturalar.ImageOptions.Image")));
            this.BtnFaturalar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnFaturalar.ImageOptions.LargeImage")));
            this.BtnFaturalar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnFaturalar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnFaturalar.Name = "BtnFaturalar";
            // 
            // BtnAyarlar
            // 
            this.BtnAyarlar.Caption = "AYARLAR";
            this.BtnAyarlar.Id = 13;
            this.BtnAyarlar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAyarlar.ImageOptions.Image")));
            this.BtnAyarlar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAyarlar.ImageOptions.LargeImage")));
            this.BtnAyarlar.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnAyarlar.ItemAppearance.Normal.Options.UseFont = true;
            this.BtnAyarlar.Name = "BtnAyarlar";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "MENÜLER";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAnasayfa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnUrunler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnStoklar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnMusteriler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnFirmalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnPersoneller);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnGiderler);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnKasa);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnNotlar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnBankalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnRehber);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnFaturalar);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAyarlar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 599);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TİCARİ OTOMASYON SİSTEMİ";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem BtnUrunler;
        private DevExpress.XtraBars.BarButtonItem BtnStoklar;
        private DevExpress.XtraBars.BarButtonItem BtnMusteriler;
        private DevExpress.XtraBars.BarButtonItem BtnFirmalar;
        private DevExpress.XtraBars.BarButtonItem BtnAnasayfa;
        private DevExpress.XtraBars.BarButtonItem BtnPersoneller;
        private DevExpress.XtraBars.BarButtonItem BtnGiderler;
        private DevExpress.XtraBars.BarButtonItem BtnKasa;
        private DevExpress.XtraBars.BarButtonItem BtnNotlar;
        private DevExpress.XtraBars.BarButtonItem BtnBankalar;
        private DevExpress.XtraBars.BarButtonItem BtnRehber;
        private DevExpress.XtraBars.BarButtonItem BtnFaturalar;
        private DevExpress.XtraBars.BarButtonItem BtnAyarlar;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

