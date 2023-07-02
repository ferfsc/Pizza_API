﻿using Pizza_API.Builder;

namespace Pizza_API.Services.Cocina
{
    public interface IPedidoCocina
    {
        Pizza SolicitarPizza(int cantidad);

        List<Pizza> VerMenu();

        Pizza CrearPizza(Pizza datos, string nombre, int cantidad);
    }
}
