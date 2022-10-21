using System;

namespace ComparandoSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int mes;
            
            Console.WriteLine("WELCOME")
            Console.WriteLine("Olá qual é seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine($"Muito prazer, {nome}, escreva o número do mês a ser verificado");
            mes = Convert.ToInt16(Console.ReadLine());

            Switch(mes)
            {
                case1: 
                Console.WriteLine("Este mes possui 31 dia");
                break;

                case2: 
                Console.WriteLine("Este mes possui 28 ou 29 dia");
                break;

                case3: 
                Console.WriteLine("Este mes possui 31 dia");
                break;

                case4: 
                Console.WriteLine("Este mes possui 30 dia");
                break;

                case5: 
                Console.WriteLine("Este mes possui 31 dia");
                break;

                case6: 
                Console.WriteLine("Este mes possui 30 dia");
                break;

                case7: 
                Console.WriteLine("Este mes possui 31 dia");
                break;

                case8: 
                Console.WriteLine("Este mes possui 31 dia");
                break;

                case9: 
                Console.WriteLine("Este mes possui 30 dia");
                break;

                case10: 
                Console.WriteLine("Este mes possui 31 dia");
                break;

                case11: 
                Console.WriteLine("Este mes possui 30 dia");
                break;

                case12: 
                Console.WriteLine("Este mes possui 31 dia");
                break;
            }

        }   
    }
}
