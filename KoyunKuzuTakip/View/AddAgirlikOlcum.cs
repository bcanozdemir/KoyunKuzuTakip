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
    public partial class AddAgirlikOlcum : Form
    {
        Func<String,String> func;

        public AddAgirlikOlcum(Func<String,String> func)
        {
            this.func = func;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            func(agirlikTb.Text + " Kg   " + ayNum.Value + ". Ay");
        }
    }
}
