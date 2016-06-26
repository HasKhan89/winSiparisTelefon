namespace winSiparisTelefon
{
    public class Model
    {
        public string Marka { get; set; }
        public string Modeli { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return Marka + " - " + 
                Modeli + " - (" + 
                Adet.ToString() + ") - " + 
                Fiyat.ToString();
        }

    }
}