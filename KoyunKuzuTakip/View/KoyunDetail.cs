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
    public partial class KoyunDetail : Form
    {
        int _kupeNo;
        Animal animal = new Animal();
        Animal _animal
        {
            get
            {

                animal.KupeNo = Convert.ToInt32(kupeNoTb.Text);
                animal.AnacKupeNo = Convert.ToInt32(anacKupeNoTb.Text);
                animal.KoyunIsletmeNo = Convert.ToInt32(koyunIsletmeNoTb.Text);
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

                animal.DevletAsilari = "";
                for (int i = 0; i < devletAsilariLb.Items.Count; i++)
                {
                    if (devletAsilariLb.Items[i].ToString() != "")
                    {
                        animal.DevletAsilari += devletAsilariLb.Items[i].ToString() + ",";
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
                catch (Exception){}
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
                    gercekDogumTarihiTb.Text = value.GercekDogurmaTarihi.ToString();
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
                catch (Exception) { }

            }
        }

        Func<String> _listKoyun;

        public KoyunDetail(int kupeNo, Func<String> listKoyun)
        {
            _listKoyun = listKoyun;
            _kupeNo = kupeNo;
            InitializeComponent();
            loadKoyun();
        }

        private void loadKoyun()
        {
            using (KoyunKuzuContext dbContext = new KoyunKuzuContext())
            {
                _animal = dbContext.ANIMAL.FirstOrDefault(item => item.KupeNo == _kupeNo);
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

        private void kaybetBtn_Click(object sender, EventArgs e)
        {
            using (KoyunKuzuContext dbContext = new KoyunKuzuContext())
            {
                Animal temp = dbContext.ANIMAL.FirstOrDefault(item=> item.KupeNo == _animal.KupeNo);
                _animal.id = temp.id;

                dbContext.Entry(temp).CurrentValues.SetValues(_animal);
                dbContext.SaveChanges();
                _listKoyun();
                this.Hide();
            }
        }

        private void KoyunDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
