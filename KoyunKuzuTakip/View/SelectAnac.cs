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
    public partial class SelectAnac : Form
    {


        private SelectGender _selectGender;
        public AnaMenu anaMenu;

        public SelectAnac(SelectGender selectGender, AnaMenu anaMenu)
        {
            this.anaMenu = anaMenu;
            _selectGender = selectGender;
            InitializeComponent();
            getAnimals();
        }

        public void getAnimals()
        {
            anacList.Items.Clear();
            using (KoyunKuzuContext dbContext = new KoyunKuzuContext())
            {
                List<Animal> animals = dbContext.ANIMAL.ToList().Where(animal => animal.HayvanTuru == 0).ToList();
                animals.ForEach(animal => anacList.Items.Add(animal.KupeNo));
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void secButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (anacList.Text == "")
                MessageBox.Show("Luften Anac seciniz");
            else
                anaMenu.formInAnaPanel(new ListKoyun(anaMenu, Convert.ToInt32(anacList.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (NewAnac newAnac = new NewAnac(this))
            {
                newAnac.ShowDialog(this);
            }
        }
    }
}
