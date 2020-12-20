using KoyunKuzuTakip.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoyunKuzuTakip.View
{
    public partial class FiltreAraMenu : Form
    {
        AnaMenu _anaMenu;

        public FiltreAraMenu(AnaMenu anaMenu)
        {
            _anaMenu = anaMenu;
            InitializeComponent();
        }

        private void iptalBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (KoyunKuzuContext dbContext = new KoyunKuzuContext())
            {
                List<Animal> aList = dbContext.ANIMAL.Where(animal => 
                     (animal.Cinsiyet.Contains(koyunCinsiyetCb.Text) || animal.KoyunYasiyorMu.Contains(koyunYasiyorMuCb.Text) || animal.KoyunSatildiMi.Contains(koyunSatildiMiCb.Text)
                     || animal.DevletAsilari.Contains(devletAsi.Text) || animal.IsletmeAsilari.Contains(isletmeAsi.Text)) && (animal.HayvanTuru != 0 && animal.HayvanTuru != 1)
                ).ToList();
                _anaMenu.formInAnaPanel(new ListKoyun(_anaMenu, aList));
                this.Hide();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FiltreAraMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
