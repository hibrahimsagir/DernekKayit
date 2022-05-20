using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DernekKayit
{
    public partial class UyeGuncelle : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<Meslek> meslekler;
        List<EgitimDurum> egitimdurumu;
        List<UyeDurum> uyelikdurum;
        int UserId=-1;

        public UyeGuncelle()
        {
            InitializeComponent();
            //dataLayoutControl1.DataSource = GetDataSource();
            //dataLayoutControl1.RetrieveFields();
            //List<BaseLayoutItem> flatList = new FlatItemsList().GetItemsList(dataLayoutControl1.Root);
            //BaseLayoutItem aboutItem = flatList.First(e => e.Text == "About");
            //aboutItem.TextLocation = DevExpress.Utils.Locations.Top;
        }
        private void bbiClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void YeniUyeKayit_Load(object sender, EventArgs e)
        {
            gridCocuk.DataSource = null;
            using (DernekKayitEntities db = new DernekKayitEntities())
            {
                meslekler = db.Meslek.Where(x => x.MeslekAdi != null).ToList();
                egitimdurumu = db.EgitimDurum.Where(x => x.EgitimDurumAdi != null).ToList();
                uyelikdurum = db.UyeDurum.Where(x => x.UyeDurum1 != null).ToList();
            }
            foreach (var meslek in meslekler)
            {
                comboBoxMeslek.Properties.Items.Add(meslek.MeslekAdi);
            }
            foreach (var egitimdurum in egitimdurumu)
            {
                comboBoxEgitimDurum.Properties.Items.Add(egitimdurum.EgitimDurumAdi);
            }
            foreach (var uyedurum in uyelikdurum)
            {
                comboBoxUyelikDurum.Properties.Items.Add(uyedurum.UyeDurum1);
            }


        }

        private void bbiSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (String.IsNullOrEmpty(textAdSoyad.Text))
            {
                MessageBox.Show("İsim soyisim boş geçilemez");
                return;
            }
            if (comboBoxEgitimDurum.SelectedItem == null)
            {
                MessageBox.Show("Eğitim durumu boş geçilemez");
                return;
            }
            if (comboBoxUyelikDurum.SelectedItem == null)
            {
                MessageBox.Show("Üyelik durumu boş geçilemez");
                return;
            }
            if (comboBoxMeslek.SelectedItem == null)
            {
                MessageBox.Show("Bir meslek seçmek zorundasınız");
                return;
            }
            if (comboBoxMedeniHal.SelectedItem == "Evli" && String.IsNullOrEmpty(textEditEsAdSoyad.Text))
            {
                MessageBox.Show("Medeni hali evli olarak seçmenize rağmen Eş Ad Soyad bilgisi girişi yapmadınız.");
                return;
            }
            if (textAdSoyad.Text != null)
            {
                string isimsoyisim = textAdSoyad.Text;
                DateTime dogumtarihi = dateDogumTarihi.DateTime;
                using (DernekKayitEntities db = new DernekKayitEntities())
                {
                    var kullanici = db.User.FirstOrDefault(x => x.AdSoyad == isimsoyisim && x.DogumTarihi == dogumtarihi);
                    if (kullanici != null)
                    {
                        MessageBox.Show("Böyle bir kullanıcı mevcuttur. Kayıtları kontrol ediniz.");
                        return;
                    }
                }


            }
            try
            {
                var user = new User
                {
                    AdSoyad = textAdSoyad.Text,
                    DogumYeri = String.IsNullOrEmpty(textDogumYeri.Text) ? null : textDogumYeri.Text,
                    DogumTarihi = dateDogumTarihi.DateTime,
                    MeslekId = meslekler.FirstOrDefault(x => x.MeslekAdi == comboBoxMeslek.SelectedItem).Id,
                    EgitimDurumId = egitimdurumu.FirstOrDefault(x => x.EgitimDurumAdi == comboBoxEgitimDurum.SelectedItem).Id,
                    MedeniHal = comboBoxMedeniHal.SelectedItem == "Evli" ? true : false,
                    EvAdresi = String.IsNullOrEmpty(textEvadres.Text) ? null : textEvadres.Text,
                    CepTel = String.IsNullOrEmpty(textCepTel.Text) ? null : textCepTel.Text,
                    EvTel = String.IsNullOrEmpty(textEvTel.Text) ? null : textEvTel.Text,
                    EPosta = String.IsNullOrEmpty(textEposta.Text) ? null : textEposta.Text,
                    DurumId = uyelikdurum.FirstOrDefault(x => x.UyeDurum1 == comboBoxUyelikDurum.SelectedItem).Id,
                    KayitTarihi = DateTime.Now,
                    Image = ConvertImageToBinary(pictureEdit1.Image),

                };

                using (DernekKayitEntities db = new DernekKayitEntities())
                {
                    db.User.Add(user);
                    db.SaveChanges();
                    UserId = user.Id;
                    if (!String.IsNullOrEmpty(textEditEsAdSoyad.Text))
                    {
                        EsBilgisiEkle(UserId);
                    }
                }

                MessageBox.Show("Üye başarılı bir şekilde kaydedilmiştir.");
            }
            catch
            {
                MessageBox.Show("Bir hata ile karşılaşıldı. Lütfen tekrar deneyiniz.");
            }


        }
        private void EsBilgisiEkle(int userId)
        {
            var Es = new Es
            {
                AdSoyad = textEditEsAdSoyad.Text,
                Durum = true,
                KayitTarihi = DateTime.Now,
                UserId = userId,
            };
            using (DernekKayitEntities db = new DernekKayitEntities())
            {
                db.Es.Add(Es);
                db.SaveChanges();
            }
        }
        private void FormTemizle()
        {
            textAdSoyad.Text = null;
            textDogumYeri.Text = null;
            dateDogumTarihi.Text = null;
            comboBoxMeslek.SelectedItem = null;
            comboBoxEgitimDurum.SelectedItem = null;
            comboBoxMedeniHal.SelectedItem = null;
            textEvadres.Text = null;
            textCepTel.Text = null;
            textEvTel.Text = null;
            textEposta.Text = null;
            comboBoxUyelikDurum.SelectedItem = null;
            pictureEdit1.Image = null;
            textEditEsAdSoyad.Text = null;
            UserId = -1;
        }

        byte[] ConvertImageToBinary(Image img)
        {
            if (img == null)
            {
                return null;
            }
            else
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    return ms.ToArray();
                }
            }

        }

        private void bbiSaveAndClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bbiSave_ItemClick(sender, e);
            this.Close();
        }
        private void bbiReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormTemizle();
        }
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            if (UserId==-1)
            {
                MessageBox.Show("Çocuk bilgisi eklemeden önce Kaydet butonuna basarak üye kaydını gerçekleştirmeniz gerekmektedir.");
                return;
            }
            else
            {
                var cocuk = new Cocuk
                {
                    AdSoyad = textCocukAdSoyad.Text,
                    Cinsiyet = comboBoxCinsiyet.SelectedItem.ToString(),
                    DogumTarihi = dateCocukDogumTarih.DateTime,
                    Durum = "Aktif",
                    KayitTarih = DateTime.Now,
                    UserId = UserId,
                };
                using (DernekKayitEntities db = new DernekKayitEntities())
                {
                    db.Cocuk.Add(cocuk);
                    db.SaveChanges();
                    var cocuks = db.Cocuk.Where(x => x.UserId == UserId).ToList();
                    gridCocuk.DataSource = cocuks;
                    gridCocuk.Refresh();
                    CocukBilgisiTemizle();
                }
            }
            
        }
        private void CocukBilgisiTemizle()
        {
            textCocukAdSoyad.Text = null;
            comboBoxCinsiyet.SelectedItem = null;
            dateCocukDogumTarih.Text = null;
        }
    }
}
