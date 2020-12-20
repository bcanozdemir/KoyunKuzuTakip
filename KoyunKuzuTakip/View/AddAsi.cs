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
    public partial class AddAsi : Form
    {
        Func<String, String> _func;
        public AddAsi(Func<String,String> func)
        {
            _func = func;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _func(aşıAdı.Text + "   " + aşıTarihi.Text);
        }

        private void aşıAdı_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
