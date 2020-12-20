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
    public partial class AnaMenu : Form
    {

        public AnaMenu()
        {
            InitializeComponent();
            initBody();
        }

        private void initBody()
        {
            formInAnaPanel(new SelectGender(this));
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void formInAnaPanel(object Formex)
        {
            Form frm = Formex as Form;
            if (bodyPanel.Controls.Count > 0)
            {
                bodyPanel.Controls.RemoveAt(0);
            }
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            bodyPanel.Controls.Add(frm);
            bodyPanel.Tag = frm;
            frm.Show();
        }
    }
}
