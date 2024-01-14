namespace Yemekkasası.Sınıf
{
    public class Menu
    {
        public string menuIsim {  get; set; }

        private string _adres;
       public string Adres
        {
            get
            {
                return _adres;
            }
            set
            {
                if (value.Length <= 120)
                 _adres = value;                
            }                      
        }
        private int _menuMiktar;
        public int menuMiktar
        {
            get
            {
                return _menuMiktar;
            }
            set
            {
                if(value <= 5)
                    _menuMiktar = value;
            }


            
        }
    }
}