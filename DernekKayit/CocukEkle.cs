using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekKayit
{
    public partial class CocukEkle : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public CocukEkle()
        {
            InitializeComponent();

        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
        DernekKayitEntities db;
        private void CocukEkle_Load(object sender, EventArgs e)
        {
            db = new DernekKayitEntities();
            db.Cocuk.Load();
            cocukBindingSource1.DataSource = db.Cocuk.Local;
            var userr= db.User.ToList();
            UyeDTO uyeDTO = new UyeDTO();
            List<UyeDTO> listUyeDto = new List<UyeDTO>();
            foreach (var item in userr)
            {
                listUyeDto.Add(new UyeDTO { AdSoyad = item.AdSoyad, Id = item.Id });
            }
            userBindingSource1.DataSource = listUyeDto;
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            cocukBindingSource1.AddNew();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Çocuk bilgisini silmek istediğinize emin misiniz ?","Mesaj",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                cocukBindingSource1.RemoveCurrent();
            }
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            db.SaveChanges();
            XtraMessageBox.Show("Değişiklikleriniz başarıyla kaydedilmiştir.","Mesaj",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CocukEkle_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.Dispose();
        }
    }
}