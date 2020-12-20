using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace KoyunKuzuTakip.Model
{
    [Table("Animal")]
    public class Animal
    {
        [Key]
        public long id { get; set; }

        public long KupeNo { get; set; }

        public long? KoyunIsletmeNo { get; set; }

        public string Cinsiyet { get; set; }

        public long? HayvanTuru { get; set; }

        public long? AnacKupeNo { get; set; }

        public string KoyunYasiyorMu { get; set; }

        public string KoyunSatildiMi { get; set; }

        public string OlumTarihi { get; set; }

        public string SatisTarihi { get; set; }

        public string KocKatimTarihi { get; set; }

        public string TahminiDogurmaTarihi { get; set; }

        public string GercekDogurmaTarihi { get; set; }

        public string DogurduguKuzuSayisi { get; set; }

        public string DogumAgirligi { get; set; }

        public string AgirlikOlcumleri { get; set; }
        
        public string IsletmeAsilari { get; set; }

        public string DevletAsilari { get; set; }

        public string Note { get; set; }
    }
}
