using Hobimler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hobimler
{
    public partial class Form1 : Form
    {
        OkulContext db = new OkulContext();
        public Form1()
        {
            InitializeComponent();
            lstOgrenciler.DataSource = new BindingSource(db.Ogrenciler.ToList(), null);
            cboHobiler.DataSource = new BindingSource(db.Hobiler.ToList(), null);
            
        }

        private void lstOgrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOgrenciler.SelectedIndex >-1 )
            {
                var Ogr = (Ogrenci)lstOgrenciler.SelectedItem;
                lstHobiler.DataSource = new BindingSource(Ogr.Hobiler.ToList(),null);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lstOgrenciler.SelectedIndex > -1)
            {
                var Ogr = (Ogrenci)lstOgrenciler.SelectedItem;
                var seciliHobi = (Hobi)cboHobiler.SelectedItem;
                if (Ogr.Hobiler.Any(x=>x.Id == seciliHobi.Id))
                {
                    MessageBox.Show("Zaten aynısını ekledin!!!");
                }
                else
                {
                       Ogr.Hobiler.Add(seciliHobi);
                db.SaveChanges();
                lstOgrenciler.SelectedIndex = -1;
                lstOgrenciler.SelectedItem = Ogr;     
                }
            
            }
        }

        private void lstHobiler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Delete && lstOgrenciler.SelectedIndex>-1 && lstHobiler.SelectedIndex>-1)
            {
                var Ogr = (Ogrenci)lstOgrenciler.SelectedItem;
                var seciliHobi = (Hobi)lstHobiler.SelectedItem;
                Ogr.Hobiler.Remove(seciliHobi);
                db.SaveChanges();
                lstOgrenciler.SelectedIndex = -1;
                lstOgrenciler.SelectedItem = Ogr;
            }
        }
    }
}
