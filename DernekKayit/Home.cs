using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DernekKayit
{
    public partial class Home : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Home()
        {
            InitializeComponent();

        }

        public void accordionControlElement6_Click(object sender, EventArgs e)
        {
            YeniUyeKayit yeniUyeKayit = new YeniUyeKayit();
            yeniUyeKayit.Show();
            
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void accordionControlElement9_Click(object sender, EventArgs e)
        {
            UyeListele uyeListele = new UyeListele();
            uyeListele.Show();
        }

        private void accordionControlElement8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen açılacak olan listeden silme işlemi yapmak istediğiniz kişiyi aratıp bulduktan sonra kaydın sağ tarafında bulunan çarpı işaretine  tıklayınız.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UyeListele uyeListele = new UyeListele();
            uyeListele.Show();
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lütfen açılacak olan listeden güncelleme yapmak istediğiniz kişiyi aratıp bulduktan sonra kaydın üzerine çift tıklayınız.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UyeListele uyeListele = new UyeListele();
            uyeListele.Show();
        }

        private void accordionControlElement10_Click(object sender, EventArgs e)
        {
            CocukEkle cocukEkle = new CocukEkle();
            cocukEkle.Show();
        }
    }
}
