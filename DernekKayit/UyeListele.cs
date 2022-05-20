using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekKayit
{
    public partial class UyeListele : DevExpress.XtraEditors.XtraForm
    {
        public UyeListele()
        {
            InitializeComponent();
        }
        DernekKayitEntities db;
        private void UyeListele_Load(object sender, EventArgs e)
        {
             db= new DernekKayitEntities();
            userBindingSource2.DataSource = db.User.Where(x=>x.DurumId==1).ToList();
            egitimDurumBindingSource.DataSource = db.EgitimDurum.ToList();
            meslekBindingSource.DataSource = db.Meslek.ToList();
            uyeDurumBindingSource.DataSource = db.UyeDurum.ToList();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                int ıdd = (gridView1.GetFocusedRow() as User).Id;
                if (XtraMessageBox.Show($"Kaydı silmek (pasif) istediğinize emin misiniz {(gridView1.GetFocusedRow() as User).AdSoyad} ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                {
                    var user = db.User.FirstOrDefault(x => x.Id == ıdd);
                    user.DurumId = 2;
                    db.SaveChanges();
                    userBindingSource2.DataSource = db.User.Where(x => x.DurumId == 1).ToList();
                }
            }
            catch
            {
                XtraMessageBox.Show("Bir hata ile karışlaşıldı. Lütfen Formu kapatıp tekrar yeniden açmayı deneyiniz.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void UyeListele_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                db.SaveChanges();
                db.Dispose();
            }
            catch
            {
                XtraMessageBox.Show("Bir hata ile karşılaşıldı formu kapatıp tekrar deneyiniz.");
            }
        }
    }
}