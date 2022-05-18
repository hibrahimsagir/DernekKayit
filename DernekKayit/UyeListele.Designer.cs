
namespace DernekKayit
{
    partial class UyeListele
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.userBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDogumYeri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDogumTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMeslek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpMeslek = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.meslekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEgitimDurumu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpEgitim = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.egitimDurumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEvAdresi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCepTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEvTel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEPosta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Durum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemGridLookUpDurum = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.uyeDurumBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMedeniHal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Foto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpMeslek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meslekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEgitim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.egitimDurumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpDurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeDurumBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.userBindingSource2;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(10);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(10);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemGridLookUpEgitim,
            this.repositoryItemGridLookUpMeslek,
            this.repositoryItemGridLookUpDurum});
            this.gridControl1.Size = new System.Drawing.Size(1034, 644);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // userBindingSource2
            // 
            this.userBindingSource2.DataSource = typeof(DernekKayit.User);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colAdSoyad,
            this.colDogumYeri,
            this.colDogumTarihi,
            this.colMeslek,
            this.colEgitimDurumu,
            this.colEvAdresi,
            this.colCepTel,
            this.colEvTel,
            this.colEPosta,
            this.colKayitTarihi,
            this.Durum,
            this.colMedeniHal,
            this.Foto});
            this.gridView1.DetailHeight = 1065;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowRowSizing = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindNullPrompt = "Aranacak metni girin...";
            this.gridView1.OptionsFind.FindPanelLocation = DevExpress.XtraGrid.Views.Grid.GridFindPanelLocation.Panel;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowHeight = 32;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 76;
            this.colId.Name = "colId";
            this.colId.Width = 284;
            // 
            // colAdSoyad
            // 
            this.colAdSoyad.FieldName = "AdSoyad";
            this.colAdSoyad.MinWidth = 76;
            this.colAdSoyad.Name = "colAdSoyad";
            this.colAdSoyad.Visible = true;
            this.colAdSoyad.VisibleIndex = 0;
            this.colAdSoyad.Width = 76;
            // 
            // colDogumYeri
            // 
            this.colDogumYeri.FieldName = "DogumYeri";
            this.colDogumYeri.MinWidth = 76;
            this.colDogumYeri.Name = "colDogumYeri";
            this.colDogumYeri.Visible = true;
            this.colDogumYeri.VisibleIndex = 1;
            this.colDogumYeri.Width = 76;
            // 
            // colDogumTarihi
            // 
            this.colDogumTarihi.FieldName = "DogumTarihi";
            this.colDogumTarihi.MinWidth = 76;
            this.colDogumTarihi.Name = "colDogumTarihi";
            this.colDogumTarihi.Visible = true;
            this.colDogumTarihi.VisibleIndex = 2;
            this.colDogumTarihi.Width = 76;
            // 
            // colMeslek
            // 
            this.colMeslek.ColumnEdit = this.repositoryItemGridLookUpMeslek;
            this.colMeslek.FieldName = "MeslekId";
            this.colMeslek.MinWidth = 76;
            this.colMeslek.Name = "colMeslek";
            this.colMeslek.Visible = true;
            this.colMeslek.VisibleIndex = 3;
            this.colMeslek.Width = 76;
            // 
            // repositoryItemGridLookUpMeslek
            // 
            this.repositoryItemGridLookUpMeslek.AutoHeight = false;
            this.repositoryItemGridLookUpMeslek.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpMeslek.DataSource = this.meslekBindingSource;
            this.repositoryItemGridLookUpMeslek.DisplayMember = "MeslekAdi";
            this.repositoryItemGridLookUpMeslek.Name = "repositoryItemGridLookUpMeslek";
            this.repositoryItemGridLookUpMeslek.PopupView = this.repositoryItemGridLookUpEdit2View;
            this.repositoryItemGridLookUpMeslek.ValueMember = "Id";
            // 
            // meslekBindingSource
            // 
            this.meslekBindingSource.DataSource = typeof(DernekKayit.Meslek);
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colEgitimDurumu
            // 
            this.colEgitimDurumu.ColumnEdit = this.repositoryItemGridLookUpEgitim;
            this.colEgitimDurumu.FieldName = "EgitimDurumId";
            this.colEgitimDurumu.MinWidth = 76;
            this.colEgitimDurumu.Name = "colEgitimDurumu";
            this.colEgitimDurumu.Visible = true;
            this.colEgitimDurumu.VisibleIndex = 4;
            this.colEgitimDurumu.Width = 76;
            // 
            // repositoryItemGridLookUpEgitim
            // 
            this.repositoryItemGridLookUpEgitim.AutoHeight = false;
            this.repositoryItemGridLookUpEgitim.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEgitim.DataSource = this.egitimDurumBindingSource;
            this.repositoryItemGridLookUpEgitim.DisplayMember = "EgitimDurumAdi";
            this.repositoryItemGridLookUpEgitim.Name = "repositoryItemGridLookUpEgitim";
            this.repositoryItemGridLookUpEgitim.PopupView = this.repositoryItemGridLookUpEdit1View;
            this.repositoryItemGridLookUpEgitim.ValueMember = "Id";
            // 
            // egitimDurumBindingSource
            // 
            this.egitimDurumBindingSource.DataSource = typeof(DernekKayit.EgitimDurum);
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colEvAdresi
            // 
            this.colEvAdresi.FieldName = "EvAdresi";
            this.colEvAdresi.MinWidth = 76;
            this.colEvAdresi.Name = "colEvAdresi";
            this.colEvAdresi.Visible = true;
            this.colEvAdresi.VisibleIndex = 5;
            this.colEvAdresi.Width = 76;
            // 
            // colCepTel
            // 
            this.colCepTel.FieldName = "CepTel";
            this.colCepTel.MinWidth = 76;
            this.colCepTel.Name = "colCepTel";
            this.colCepTel.Visible = true;
            this.colCepTel.VisibleIndex = 6;
            this.colCepTel.Width = 76;
            // 
            // colEvTel
            // 
            this.colEvTel.FieldName = "EvTel";
            this.colEvTel.MinWidth = 76;
            this.colEvTel.Name = "colEvTel";
            this.colEvTel.Visible = true;
            this.colEvTel.VisibleIndex = 7;
            this.colEvTel.Width = 76;
            // 
            // colEPosta
            // 
            this.colEPosta.FieldName = "EPosta";
            this.colEPosta.MinWidth = 76;
            this.colEPosta.Name = "colEPosta";
            this.colEPosta.Visible = true;
            this.colEPosta.VisibleIndex = 8;
            this.colEPosta.Width = 76;
            // 
            // colKayitTarihi
            // 
            this.colKayitTarihi.FieldName = "KayitTarihi";
            this.colKayitTarihi.MinWidth = 76;
            this.colKayitTarihi.Name = "colKayitTarihi";
            this.colKayitTarihi.Visible = true;
            this.colKayitTarihi.VisibleIndex = 9;
            this.colKayitTarihi.Width = 76;
            // 
            // Durum
            // 
            this.Durum.Caption = "Durum";
            this.Durum.ColumnEdit = this.repositoryItemGridLookUpDurum;
            this.Durum.FieldName = "UyeDurum.Id";
            this.Durum.MinWidth = 76;
            this.Durum.Name = "Durum";
            this.Durum.Visible = true;
            this.Durum.VisibleIndex = 10;
            this.Durum.Width = 76;
            // 
            // repositoryItemGridLookUpDurum
            // 
            this.repositoryItemGridLookUpDurum.AutoHeight = false;
            this.repositoryItemGridLookUpDurum.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpDurum.DataSource = this.uyeDurumBindingSource;
            this.repositoryItemGridLookUpDurum.DisplayMember = "UyeDurum1";
            this.repositoryItemGridLookUpDurum.Name = "repositoryItemGridLookUpDurum";
            this.repositoryItemGridLookUpDurum.PopupView = this.gridView2;
            this.repositoryItemGridLookUpDurum.ValueMember = "Id";
            // 
            // uyeDurumBindingSource
            // 
            this.uyeDurumBindingSource.DataSource = typeof(DernekKayit.UyeDurum);
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colMedeniHal
            // 
            this.colMedeniHal.FieldName = "MedeniHal";
            this.colMedeniHal.MinWidth = 76;
            this.colMedeniHal.Name = "colMedeniHal";
            this.colMedeniHal.Visible = true;
            this.colMedeniHal.VisibleIndex = 11;
            this.colMedeniHal.Width = 76;
            // 
            // Foto
            // 
            this.Foto.Caption = "Fotoğraf";
            this.Foto.FieldName = "Image";
            this.Foto.MinWidth = 25;
            this.Foto.Name = "Foto";
            this.Foto.Visible = true;
            this.Foto.VisibleIndex = 12;
            this.Foto.Width = 100;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataSource = typeof(DernekKayit.User);
            // 
            // UyeListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 644);
            this.Controls.Add(this.gridControl1);
            this.Name = "UyeListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UyeListele";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UyeListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpMeslek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meslekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEgitim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.egitimDurumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpDurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uyeDurumBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource userBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colDogumYeri;
        private DevExpress.XtraGrid.Columns.GridColumn colDogumTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colMeslek;
        private DevExpress.XtraGrid.Columns.GridColumn colEgitimDurumu;
        private DevExpress.XtraGrid.Columns.GridColumn colEvAdresi;
        private DevExpress.XtraGrid.Columns.GridColumn colCepTel;
        private DevExpress.XtraGrid.Columns.GridColumn colEvTel;
        private DevExpress.XtraGrid.Columns.GridColumn colEPosta;
        private DevExpress.XtraGrid.Columns.GridColumn colKayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn Durum;
        private DevExpress.XtraGrid.Columns.GridColumn colMedeniHal;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEgitim;
        private System.Windows.Forms.BindingSource egitimDurumBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpMeslek;
        private System.Windows.Forms.BindingSource meslekBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpDurum;
        private System.Windows.Forms.BindingSource uyeDurumBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource userBindingSource2;
        private DevExpress.XtraGrid.Columns.GridColumn Foto;
    }
}