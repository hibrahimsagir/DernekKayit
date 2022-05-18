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

        private void UyeListele_Load(object sender, EventArgs e)
        {
            DernekKayitEntities db = new DernekKayitEntities();
            userBindingSource2.DataSource = db.User.ToList();
            egitimDurumBindingSource.DataSource = db.EgitimDurum.ToList();
            meslekBindingSource.DataSource = db.Meslek.ToList();
            uyeDurumBindingSource.DataSource = db.UyeDurum.ToList();
        }
    }
}