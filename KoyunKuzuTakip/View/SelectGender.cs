using KoyunKuzuTakip.Model;
using KoyunKuzuTakip.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoyunKuzuTakip
{
    public partial class SelectGender : Form
    {
        public AnaMenu _anaMenu;

        public SelectGender(AnaMenu anaMenu)
        {
            _anaMenu = anaMenu;
            InitializeComponent();
        }

        private void koyunResim_Click(object sender, EventArgs e)
        {
            using (SelectAnac selectAnac = new SelectAnac(this,_anaMenu))
            {
                selectAnac.ShowDialog(this);
            }
        }

        private void filtreAraBtn_Click(object sender, EventArgs e)
        {
            using (FiltreAraMenu filtreAraMenu = new FiltreAraMenu(_anaMenu))
            {
                filtreAraMenu.ShowDialog(this);
            }
        }

        private void kocResim_Click(object sender, EventArgs e)
        {
            List<Animal> kocList = null;
            _anaMenu.formInAnaPanel(new ListKoyun(_anaMenu, kocList, 1));
            
        }
    }
}
