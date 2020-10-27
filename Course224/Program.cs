using System;
using System.Collections.Generic;
using System.Linq;

using Course224.Entities;

namespace Course224
{
    class Program
    {
        static void Main(string[] args)
        {
            /* USANDAO O ACTION
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

            // SEM ESTE ACTION2 o resultado era:
             
             //--- LISTA DE PRODUTOS COM PREÇOS INCREMENTADOS em 10%---
             //   Nome: Tv, | Preço: R$990,00
             

            //FOREACH para a minha LISTA! -- RECEBE UM ACTION
            list.ForEach(action2);

            //Expressao lambda IN LINE
            list.ForEach(p =>
                             {
                                 p.Price = p.Price / 2;

                             });
           

            // COM ESTE ACTION2 o resultado era:
             //
             //--- LISTA DE PRODUTOS COM PREÇOS INCREMENTADOS em 10%---
             //   Nome: Tv, | Preço: R$495,00
             //

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

            */

            //USANDO O DELEGATE FUNC
            //225. Func (exemplo com Select)


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


            List<string> result = list.Select(NameUpper).ToList();

            foreach (string p in result)
            {
                Console.WriteLine(p);

            }

            Console.WriteLine();

            Func<Products, string> func = NameLower;

            List<string> result2 = list.Select(func).ToList();

            foreach (string p in result2)
            {
                Console.WriteLine(p);

            }

            Console.WriteLine();

            //Já que a func retorna alguma coisa, não precisa das chaves e do RETURN, pois com as chaves é um comando completo
            Func<Products, string> func2 = p => p.Name.Length.ToString();
            //ou com as chaves tem que usar o RETURN
            //Func<Products, string> func3 = p => { return p.Name.Length.ToString(); }
            //IN LINE
            // List<string> result3 = list.Select(p => p.Name.Length.ToString()).ToList();

            List<string> result3 = list.Select(func2).ToList();

            foreach (string p in result3)
            {
                Console.WriteLine(p);

            }

            Console.WriteLine("--- MINHA FUNCAO RETORNADO NUMEROS DO SELECT ---");

            //com base acima eu gostaria assim

            List<int> result4 = list.Select(p => p.Name.Length).ToList();

            foreach (int p in result4)
            {
                Console.WriteLine(p);

            }

            Console.WriteLine();
        }

        static string NameUpper(Products p)
        {
            return p.Name.ToUpper();

        }

        static string NameLower(Products p)
        {
            return p.Name.ToLower();

        }

        /* USANDO O ACTION
        static void UpdateAumentaPrice(Products p)
        {
            p.Price += p.Price * 0.1;

        }

        static void UpdateDiminuiPrice(Products p)
        {
            p.Price -= p.Price * 0.2;

        }
        */

        //USANDO O FUNC


    }

    }
