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
    public partial class NewAnac : Form
    {
        SelectAnac _sAnac;

        public NewAnac(SelectAnac selectAnac)
        {
            _sAnac = selectAnac;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void secButton_Click(object sender, EventArgs e)
        {
            using (KoyunKuzuContext dbContext = new KoyunKuzuContext())
            {
                Animal animal = new Animal();
                animal.HayvanTuru = 0;
                animal.KupeNo = Convert.ToInt32(anacKupeNo.Text);
                dbContext.ANIMAL.Add(animal);
                try
                {
                    dbContext.SaveChanges();
                }
                catch (Exception)
                {
                    MessageBox.Show("Bir Hata Oluştu. Küpe Numara Kullanılıyor Olabilir.");
                }
                this.Hide();
                _sAnac.getAnimals();
            }
        }
    }
}
