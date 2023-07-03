namespace Pizza_API.Builder.ProdPizzas
{
    public class Pizza
    {
        public string Nombre { get; set; }
        public string Masa { get; set; }
        public string Salsa { get; set; }
        public string Relleno { get; set; }
        public string Tamano { get; set; }
        public string Forma { get; set; }
        public int Cantidad { get; set; }
        public Pizza()
        {

        }

        public Pizza(string nombre, string tamano, string masa, string salsa, string relleno, string forma, int cantidad) : this()
        {
            Nombre = nombre;
            Tamano = tamano;
            Masa = masa;
            Salsa = salsa;
            Relleno = relleno;
            Forma = forma;
            Cantidad = cantidad;
        }
    }
}
