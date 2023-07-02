namespace Pizza_API.Builder
{
    public class Pizza
    {
        public string Masa { get; set; }
        public string Salsa { get; set; }
        public string Relleno { get; set; }
        public string Tamano { get; set; }

        public string Forma { get; set; }

        public int Cantidad { get; set; }
        public Pizza() { 
        
        }

        public Pizza(string tamano, string masa, string salsa, string relleno, string forma, int cantidad) : this()
        {
            Tamano = tamano;
            Masa = masa;
            Salsa = salsa;
            Relleno = relleno;
            Forma = forma;
            Cantidad = cantidad;
        }
    }
}
