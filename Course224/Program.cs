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

            Console.WriteLine("--- LISTA DE PRODUTOS ---");
            foreach (Products p in list)
            {
                Console.WriteLine(p);

            }

            Console.WriteLine();

            //criando um objeto do tipo DELEGATE ACTION
            Action<Products> action = UpdateAumentaPrice;

            //Com a expressao LAMBDA
            Action<Products> action2 = p =>
                                            {
                                                p.Price = p.Price / 2;

                                            };


            //FOREACH para a minha LISTA! -- RECEBE UM ACTION
            list.ForEach(action);

            /* SEM ESTE ACTION2 o resultado era:
             
             --- LISTA DE PRODUTOS COM PREÇOS INCREMENTADOS em 10%---
                Nome: Tv, | Preço: R$990,00
             */

            //FOREACH para a minha LISTA! -- RECEBE UM ACTION
            list.ForEach(action2);

            //Expressao lambda IN LINE
            list.ForEach(p =>
                             {
                                 p.Price = p.Price / 2;

                             });
           

            /* COM ESTE ACTION2 o resultado era:
             
             --- LISTA DE PRODUTOS COM PREÇOS INCREMENTADOS em 10%---
                Nome: Tv, | Preço: R$495,00
             */

            Console.WriteLine("--- LISTA DE PRODUTOS COM PREÇOS INCREMENTADOS em 10%---");
            foreach (Products p in list)
            {
                Console.WriteLine(p);

            }

            //FOREACH para a minha LISTA! -- RECEBE UM ACTION
            list.ForEach(UpdateDiminuiPrice);

            Console.WriteLine("--- LISTA DE PRODUTOS COM PREÇOS DESCONTADOS em 20%---");
            foreach (Products p in list)
            {
                Console.WriteLine(p);

            }

            
        }

        static void UpdateAumentaPrice(Products p)
        {
            p.Price += p.Price * 0.1;

        }

        static void UpdateDiminuiPrice(Products p)
        {
            p.Price -= p.Price * 0.2;

        }
    }

}
