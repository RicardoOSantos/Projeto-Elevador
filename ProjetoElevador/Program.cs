using ProjetoElevador.Model;
using System;

namespace ProjetoElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuarB = false;


            //do
            //{           

            Console.WriteLine("qual a capacidade do elevador?");
            int capacidade = int.Parse(Console.ReadLine());

            Console.WriteLine("quantos andares tem o elevador?");
            int totalAndares = int.Parse(Console.ReadLine());

            Elevador el = new Elevador();
            el.Inicializar(capacidade, totalAndares);

            do
            {
                Console.WriteLine($@" O que você deseja fazer?
                        E - Entrar uma pessoa
                        S - Sair uma pessoa
                        Su - Subir
                        D - Descer");

                string opcao = Console.ReadLine().ToUpper();

                switch (opcao)
                {
                    case "E":
                        el.Entrar();
                        break;

                    case "S":
                        el.Sair();
                        break;

                    case "SU":
                        el.Subir();
                        break;

                    case "D":
                        el.Descer();
                        break;

                    default:
                        Console.WriteLine("Essa opcao é invalida, digite uma valida");
                        break;
                }

                Console.WriteLine("Deseja continuar? s para sim");
                string continuar = Console.ReadLine().ToLower();

                if (continuar == "s")
                {
                    continuarB = true;
                }
                else
                {
                    continuarB = false;
                }

            } while (continuarB == true);

            // break;



            // } while (continuarB == false);



        }
    }
    
}
