using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemekkasası.Sınıf
{
    public abstract class GirisKayit1
    {
        public string ePosta {  get; set; }
        public string sifre {  get; set; }


        public abstract void BilgiGetir();
    }

}
