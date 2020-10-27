using System;
using System.Collections.Generic;

using Course224.Entities;

namespace Course224
{
    class Program
    {
        static void Main(string[] args)
        {
            //224. Action (exemplo com ForEach)

            List<Products> list = new List<Products>();

            list.Add(new Products("Tv", 900.00));
            list.Add(new Products("Mouse", 50.00));
            list.Add(new Products("Tablet", 350.50));
            list.Add(new Products("HD Case", 80.90));

            //FOREACH para a minha LISTA!
            list.ForEach(UpdatePrice);

            Console.WriteLine("--- LISTA DE PRODUTOS ATUALIZADOS---");
            foreach (Products p in list)
            {
                Console.WriteLine(p);

            }
        }

        static void UpdatePrice(Products p)
        {
            p.Price += p.Price * 0.1;

        }
    }

}
