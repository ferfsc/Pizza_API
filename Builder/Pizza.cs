namespace API_Pizza.Builder
{
    public class Pizza
    {
        public string Masa { get; set; }
        public string Salsa { get; set; }
        public string Relleno { get; set; }
        public string Tamano { get; set; }

        public string Forma { get; set; }

        public Pizza() { 
        
        }

        public Pizza(string tamano, string masa, string salsa, string relleno, string forma) : this()
        {
            Tamano = tamano;
            Masa = masa;
            Salsa = salsa;
            Relleno = relleno;
            Forma = forma;
        }
    }
}
