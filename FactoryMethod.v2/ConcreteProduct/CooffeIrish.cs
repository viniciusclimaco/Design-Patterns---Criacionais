﻿using FactoryMethod.v2.Product;

namespace FactoryMethod.v2.ConcreteProduct
{
    public class CooffeIrish : Cooffe
    {
        public override string Nome => _nome;
        private readonly string _nome;
        public CooffeIrish()
        {
            _nome = "Café Irlandês";            
            Ingredientes.Add("Café Puro");
            Ingredientes.Add("Camada de Creme");
            Ingredientes.Add("Uísque Irlandês");
        }

        public override void Servir()
        {
            Console.WriteLine($"Servindo o café de nome: {Nome}");
        }

        public override void Preparar()
        {
            Console.WriteLine($"Preparando o café {Nome}");
            Console.WriteLine($"Com os seguintes ingredientes:");
            for (int i = 0; i < Ingredientes.Count; i++)
            {
                Console.WriteLine($" - {Ingredientes[i]}");
            }
        }
    }
}
