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
    public partial class ListKoyun : Form
    {
        public int _anacKupeNo;
        /// <summary>
        /// ANAÇ = 0
        /// KOÇ = 1
        /// YAVRU KOYUN = HERŞEY :D
        /// </summary>
        int hayvanTur = 3;
        AnaMenu _anaMenu;
        List<Animal> _aList;
        Func<String> refreshFunc;

        /// <summary>
        /// Normal Anaç No ile gelenler Koyundan
        /// </summary>
        /// <param name="anaMenu"></param>
        /// <param name="anacKupeNo"></param>
        public ListKoyun(AnaMenu anaMenu, int anacKupeNo)
        {
            _anaMenu = anaMenu;
            _anacKupeNo = anacKupeNo;
            InitializeComponent();
            refreshFunc = getSubAnimals;
            getSubAnimals();
        }

        /// <summary>
        /// Filtreden Gelenler
        /// </summary>
        /// <param name="anaMenu"></param>
        /// <param name="aList"></param>
        public ListKoyun(AnaMenu anaMenu,List<Animal> aList)
        {
            _anaMenu = anaMenu;
            InitializeComponent();
            _aList = aList;
            refreshFunc = listSubAnimals;
            listSubAnimals();
            yeniEkleBtn.Visible = false;
        }

        /// <summary>
        /// Koç İçin
        /// </summary>
        /// <param name="anaMenu"></param>
        /// <param name="aList"></param>
        /// <param name="hayvanTur"></param>
        public ListKoyun(AnaMenu anaMenu,List<Animal> aList, int hayvanTur)
        {
            _anaMenu = anaMenu;
            this.hayvanTur = hayvanTur;
            InitializeComponent();
            refreshFunc = loadKoc;
            yeniEkleBtn.Text = "Yeni Koç Ekle";
            _aList = new List<Animal>();
            loadKoc();
        }

        private String loadKoc()
        {
            using (KoyunKuzuContext dbContext = new KoyunKuzuContext())
            {
                _aList = dbContext.ANIMAL.Where(item => item.Cinsiyet == "ERKEK").ToList();
            }
            koyunDGV.Rows.Clear();
            _aList.ForEach(animal => addElementToDGV(animal));
            return "";
        }

        public String listSubAnimals()
        {
            koyunDGV.Rows.Clear();
            _aList.ForEach(animal => {
                addElementToDGV(animal);
            });
            return "";
        }

        /// <summary>
        /// gathering sub animals from context
        /// </summary>
        /// <param name="anacKupeNo"></param>
        public String getSubAnimals()
        {
            koyunDGV.Rows.Clear();
            using (KoyunKuzuContext koyunKuzuContext = new KoyunKuzuContext())
            {
                List<Animal> animalList = koyunKuzuContext.ANIMAL.Where(item => item.AnacKupeNo == _anacKupeNo).ToList();
                animalList.ForEach(animal => {
                    addElementToDGV(animal);                    
                });
            }
            return "";
        }

        public void addElementToDGV(Animal animal)
        {
            int i = koyunDGV.Rows.Count;
            koyunDGV.Rows.Add();
            koyunDGV.Rows[i].Cells[0].Value = animal.KupeNo;
            koyunDGV.Rows[i].Cells[1].Value = animal.KoyunIsletmeNo;
            koyunDGV.Rows[i].Cells[2].Value = animal.Cinsiyet;
            koyunDGV.Rows[i].Cells[3].Value = animal.TahminiDogurmaTarihi;
            koyunDGV.Rows[i].Cells[4].Value = animal.DogumAgirligi;
            koyunDGV.Rows[i].Cells[5].Value = animal.KoyunYasiyorMu;
            koyunDGV.Rows[i].Cells[6].Value = animal.KoyunSatildiMi;
        }

        private void koyunDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showDetails(Convert.ToInt32(koyunDGV.SelectedRows[0].Cells[0].Value.ToString()));
        }

        private void showDetails(int kupeNo)
        {
            using (KoyunDetail koyunDetail = new KoyunDetail(kupeNo, refreshFunc))
            {
                koyunDetail.ShowDialog(this);
            }
        }

        private void koyunDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showDetails(Convert.ToInt32(koyunDGV.SelectedRows[0].Cells[0].Value.ToString()));
        }

        private void koyunDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            showDetails(Convert.ToInt32(koyunDGV.SelectedRows[0].Cells[0].Value.ToString()));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _anaMenu.formInAnaPanel(new SelectGender(_anaMenu));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (hayvanTur == 1)
            {
                using (NewKoyun newKoyun = new NewKoyun(this,hayvanTur))
                {
                    newKoyun.ShowDialog(this);
                }
            }
            else
            {
                using (NewKoyun newKoyun = new NewKoyun(this))
                {
                    newKoyun.ShowDialog(this);
                }
            }
        }
    }
}
