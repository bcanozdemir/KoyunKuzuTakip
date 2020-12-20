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

    public partial class NewKoyun : Form
    {
        ListKoyun _listKoyun;
        Animal animal = new Animal();
        Animal _animal
        {
            get
            {

                try
                {
                    animal.KupeNo = Convert.ToInt32(kupeNoTb.Text);
                    animal.AnacKupeNo = Convert.ToInt32(anacKupeNoTb.Text);
                    animal.KoyunIsletmeNo = Convert.ToInt32(koyunIsletmeNoTb.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Kupe ve İşletme Numaraları Boş Bırakılamaz");
                }
                animal.Cinsiyet = koyunCinsiyetCb.Text;
                animal.KoyunYasiyorMu = koyunYasiyorMuCb.Text;
                animal.OlumTarihi = olumTarihiTb.Text;
                animal.KoyunSatildiMi = koyunSatildiMiCb.Text;
                animal.SatisTarihi = satisTarihiTb.Text;
                animal.KocKatimTarihi = kocKatilimTarihiTb.Text;
                animal.TahminiDogurmaTarihi = tahminiDogurmaTarihiTb.Text;
                animal.GercekDogurmaTarihi = gercekDogumTarihiTb.Text;
                animal.DogumAgirligi = dogumAgirligiTb.Text;

                animal.AgirlikOlcumleri = "";
                for (int i = 0; i < agirlikOlcumleriLb.Items.Count; i++)
                {
                    if (agirlikOlcumleriLb.Items[i].ToString() != "")
                    {
                        animal.AgirlikOlcumleri += agirlikOlcumleriLb.Items[i].ToString() + ",";
                    }
                }

                animal.IsletmeAsilari = "";
                for (int i = 0; i < isletmeAsilariLb.Items.Count; i++)
                {
                    if (isletmeAsilariLb.Items[i].ToString() != "")
                    {
                        animal.IsletmeAsilari += isletmeAsilariLb.Items[i].ToString() + ",";
                    }
                }
                animal.Note = notlarTb.Text;
                return animal;
            }
            set
            {
                try
                {
                    kupeNoTb.Text = value.KupeNo.ToString();
                }
                catch (Exception) { }
                try
                {
                    anacKupeNoTb.Text = value.AnacKupeNo.ToString();
                }
                catch (Exception) { }
                try
                {
                    koyunIsletmeNoTb.Text = value.KoyunIsletmeNo.ToString();
                }
                catch (Exception) { }
                try
                {
                    koyunCinsiyetCb.Text = value.Cinsiyet;
                }
                catch (Exception) { }
                try
                {
                    koyunYasiyorMuCb.Text = value.KoyunYasiyorMu.ToString();
                }
                catch (Exception) { }
                try
                {
                    olumTarihiTb.Text = value.OlumTarihi.ToString();
                }
                catch (Exception) { }
                try
                {
                    koyunSatildiMiCb.Text = value.KoyunSatildiMi.ToString();
                }
                catch (Exception) { }
                try
                {
                    satisTarihiTb.Text = value.SatisTarihi.ToString();
                }
                catch (Exception) { }
                try
                {
                    kocKatilimTarihiTb.Text = value.KocKatimTarihi.ToString();
                }
                catch (Exception) { }
                try
                {
                    tahminiDogurmaTarihiTb.Text = value.TahminiDogurmaTarihi.ToString();
                }
                catch (Exception) { }
                try
                {
                    gercekDogumTarihi.Text = value.GercekDogurmaTarihi;
                }
                catch (Exception) { }
                try
                {
                    dogumAgirligiTb.Text = value.DogumAgirligi;
                }
                catch (Exception) { }
                try
                {
                    foreach (string agirlik in value.AgirlikOlcumleri.Split(','))
                    {
                        if (agirlik != "")
                        {
                            agirlikOlcumleriLb.Items.Add(agirlik);
                        }
                    }
                }
                catch (Exception) { }

                try
                {
                    foreach (string isletmeAsisi in value.IsletmeAsilari.Split(','))
                    {
                        if (isletmeAsisi != "")
                        {
                            isletmeAsilariLb.Items.Add(isletmeAsisi);
                        }
                    }
                }
                catch (Exception) { }

                try
                {
                    foreach (string devletAsisi in value.DevletAsilari.Split(','))
                    {
                        if (devletAsisi != "")
                        {
                            devletAsilariLb.Items.Add(devletAsisi);
                        }
                    }
                }
                catch (Exception) { }

                try
                {
                    notlarTb.Text = value.Note;
                }
                catch { }

            }
        }

        int _hayvanTur = 3;

        public NewKoyun(ListKoyun listKoyun)
        {
            _listKoyun = listKoyun;
            InitializeComponent();
            anacKupeNoTb.Text = Convert.ToString(listKoyun._anacKupeNo);
        }

        public NewKoyun(ListKoyun listKoyun,int hayvanTur)
        {
            _hayvanTur = hayvanTur;
            _listKoyun = listKoyun;
            InitializeComponent();
            anacKupeNoTb.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (_hayvanTur == 1)
            {
                //KOÇ EKLE
                _animal.HayvanTuru = 1;
                using (KoyunKuzuContext dbContext = new KoyunKuzuContext())
                {
                    dbContext.ANIMAL.Add(_animal);
                    dbContext.SaveChanges();
                    _listKoyun.addElementToDGV(_animal);
                    this.Hide();
                }
            }
            else
            {
                using (KoyunKuzuContext dbContext = new KoyunKuzuContext())
                {
                    dbContext.ANIMAL.Add(_animal);
                    dbContext.SaveChanges();
                    _listKoyun.addElementToDGV(_animal);
                    this.Hide();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void olcumEkle_Click(object sender, EventArgs e)
        {
            using (AddAgirlikOlcum addAgirlikOlcum = new AddAgirlikOlcum(agirlikOlcumEkle))
            {
                addAgirlikOlcum.ShowDialog(this);
            }
        }

        public String agirlikOlcumEkle(String agirlik)
        {
            agirlikOlcumleriLb.Items.Add(agirlik);
            return "";
        }

        private void isletmeAsisiEkle_Click(object sender, EventArgs e)
        {
            using (AddAsi addIsletmeAsisi = new AddAsi(IsletmeAsisiEkle))
            {
                addIsletmeAsisi.ShowDialog(this);
            }
        }

        public String IsletmeAsisiEkle(String asi)
        {
            isletmeAsilariLb.Items.Add(asi);
            return "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AddAsi addDevletAsisi = new AddAsi(DevletAsisiEkle))
            {
                addDevletAsisi.ShowDialog(this);
            }
        }

        public String DevletAsisiEkle(String asi)
        {
            devletAsilariLb.Items.Add(asi);
            return "";
        }

        private void NewKoyun_Load(object sender, EventArgs e)
        {

        }

        private void sil_devletAsisi_Click(object sender, EventArgs e)
        {
            int choise = devletAsilariLb.SelectedIndex;
            if (choise != -1)
            {
                devletAsilariLb.Items.RemoveAt(choise);
            }
        }

        private void Sil_agirlik_olcum(object sender, EventArgs e)
        {
            int choise = agirlikOlcumleriLb.SelectedIndex;
            if (choise != -1)
            {
                agirlikOlcumleriLb.Items.RemoveAt(choise);
            }

        }

        private void Sil_IsletmeAsisi_Click(object sender, EventArgs e)
        {
            int choise = isletmeAsilariLb.SelectedIndex;
            if (choise != -1)
            {
                isletmeAsilariLb.Items.RemoveAt(choise);
            }

        }

        private void notlarTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
