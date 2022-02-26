using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YH_SekillerDunyasi.Models;

namespace YH_SekillerDunyasi
{
    public partial class Form1 : Form
    {
        BindingList<Sekil> sekiller;
        bool durum = true;
        public Form1()
        {
            InitializeComponent();
            try
            {
                string json = File.ReadAllText("kayit.json");
                sekiller = JsonConvert.DeserializeObject<BindingList<Sekil>>(json, new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                });
                lstSekiller.DataSource = sekiller;
            }
            catch (Exception)
            {
                sekiller = new BindingList<Sekil>();
                lstSekiller.DataSource = sekiller;
            }
            sekiller.ListChanged += Sekiller_ListChanged;
            lstSekiller.DataSource = sekiller;
            cboTur.SelectedIndex = 0;
        }

        private void Sekiller_ListChanged(object sender, ListChangedEventArgs e)
        {
            pnlCizim.Refresh();
        }

        private void pboRenk_Click(object sender, EventArgs e)
        {
            cdiRenk.ShowDialog();
            pboRenk.BackColor = cdiRenk.Color;
        }

        private void pnlCizim_Paint(object sender, PaintEventArgs e)
        {
            foreach (Sekil sekil in sekiller)
            {
                sekil.Ciz(e.Graphics);
            }
        }

        private void lstSekiller_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lstSekiller.SelectedIndex != -1)
            {
                sekiller.Remove(lstSekiller.SelectedItem as Sekil);
            }
        }

        private void pnlCizim_MouseClick(object sender, MouseEventArgs e)
        {
            nudX.Value = e.X;
            nudY.Value = e.Y;
        }
        private void btnYukari_Click(object sender, EventArgs e)
        {
            int sid = lstSekiller.SelectedIndex;
            if (sid < 1) return;
            object gecici = sekiller[sid - 1];
            sekiller[sid - 1] = sekiller[sid];
            sekiller[sid] = (Sekil)gecici;
            lstSekiller.SelectedIndex = sid - 1;
        }

        private void btnAsagi_Click(object sender, EventArgs e)
        {
            int sid = lstSekiller.SelectedIndex;
            if (sid == -1 || sid == sekiller.Count - 1) return;
            object gecici = sekiller[sid + 1];
            sekiller[sid + 1] = sekiller[sid];
            sekiller[sid] = (Sekil)gecici;
            lstSekiller.SelectedIndex = sid + 1;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Sekil yeni;
            if (cboTur.SelectedIndex == 0)
                yeni = new Dikdortgen();
            else
                yeni = new Elips();

            yeni.X = (int)nudX.Value;
            yeni.Y = (int)nudY.Value;
            yeni.Genislik = (int)nudGen.Value;
            yeni.Yukseklik = (int)nudYuk.Value;
            yeni.Renk = cdiRenk.Color;
            sekiller.Add(yeni);
        }

        private void btnSilme_Click(object sender, EventArgs e)
        {
            sekiller.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var jset = JsonConvert.SerializeObject(sekiller, Formatting.Indented, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            File.WriteAllText("kayit.json", jset);
        }
    }
}
