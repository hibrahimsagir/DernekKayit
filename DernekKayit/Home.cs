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

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            YeniUyeKayit yeniUyeKayit = new YeniUyeKayit();
            yeniUyeKayit.Show();
            this.Hide();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
