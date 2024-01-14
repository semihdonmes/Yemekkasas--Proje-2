using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yemekkasası.Sınıf;

namespace Yemekkasası.Sınıf


{
    


    public class Giris : GirisKayit1,IGirisKayit
    {
        private string _epostaGiris;

        private string _sifreGiris;
        
        public string epostaGiris
        {
            get
            {
                return _epostaGiris;
            }
            set
            {
                _epostaGiris = value;

            }
        }

        
        public string Sifre
        {
            get
            {
                return _sifreGiris;
            }
            set
            {
                _sifreGiris = value;
            }
        }
            public override void BilgiGetir()
        {
            throw new NotImplementedException();
        }

        string IGirisKayit.OturumBilgisi()
        {
            return "Başarıyla giriş yaptınız.";
        }
    }
    public class Kayit : GirisKayit1, IGirisKayit
    {
        private string _epostaKayit;

        private string _sifreKayit;

        public string epostaKayit
        {
            get
            {
                return _epostaKayit;
            }
            set
            {
                _epostaKayit = value;
            }
        }
        public string sifreKayit
        {
            get
            {
                return _sifreKayit;
            }
            set
            {
                _sifreKayit = value;
            }
        }
        public override void BilgiGetir()
        {
            throw new NotImplementedException();
        }
        string IGirisKayit.OturumBilgisi()
        {
            return "Kaydınız başarıyla oluşturulmuştur.";
        }
    }
}
   


