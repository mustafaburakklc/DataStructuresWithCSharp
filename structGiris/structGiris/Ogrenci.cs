namespace structGiris
{
    public struct Ogrenci
    {
        //constructor--geri dönüş tipi olmayan metot gibi
        public Ogrenci(int numara, string adi, string soyadi, bool cinsiyet=true)
        {
            Numara = numara;
            Adi = adi;
            Soyadi = soyadi;
            Cinsiyet = cinsiyet;
        }

        public int Numara { get; set; }  //Property-Özellik   prop tab
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public bool Cinsiyet { get; set; }

        // Bir metodu ezmek /Geçersiz kılmak/Override
        public override string ToString()
        {
            return $"{Numara,-5} " +
                $"{Adi,-10} " +
                $"{Soyadi,-10}" +
                string.Format("{0,-8}", Cinsiyet == true ? "Bay" : "Bayan");
        }
    }
}
