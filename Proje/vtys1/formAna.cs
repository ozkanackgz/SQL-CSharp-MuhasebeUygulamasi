using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vtys1
{
    public partial class formAna : Form
    {
        public formAna()
        {
            InitializeComponent();
        }

        private void stokListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formStokListesi sl = new formStokListesi();
            sl.ShowDialog();
            sl.Dispose();
            
        }

        private void stokTanımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formStokTanim t = new formStokTanim();
            t.ShowDialog();
            t.Dispose();
        }

    

        private void kullanıcıListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formKullaniciiListesi liste = new formKullaniciiListesi();
            liste.ShowDialog();
            liste.Dispose();    
        }

        private void kullanıcıTanımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formKullaniciiTanim tanim = new formKullaniciiTanim(null);
            tanim.ShowDialog();
            tanim.Dispose();
        }

        private void logListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formLog log = new formLog();
            log.ShowDialog();
            log.Dispose();
        }

        private void cariHesapHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCariHesapHareketleri chh = new formCariHesapHareketleri();
            chh.ShowDialog();
            chh.Dispose();
        }

        private void cariListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCariListesi cl = new formCariListesi();
            cl.ShowDialog();
            cl.Dispose();
        }

        private void cariTanımıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formCariTanim cc = new formCariTanim();
            cc.ShowDialog();
            cc.Dispose();
        }
    }
}
