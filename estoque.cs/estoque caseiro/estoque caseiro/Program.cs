using System;

namespace estoque_caseiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao programa de estoque!");
            Console.WriteLine("                                  ");

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine("Por favor digite o item!");
                string nome = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Qual a quantidade de " + nome + " utilizado na semana?: ");
                int valordesc = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Qual a quantidade atual de " + nome + " em estoque?: ");
                int valoratual = Convert.ToInt32(Console.ReadLine());

                int total = valoratual - valordesc;

                if (total < 2)
                {
                    Console.WriteLine(nome + " disponíveis: " + total);
                    Console.WriteLine("Comprar mais urgente! ESTOQUE ABAIXO DO PADRÃO MÍNIMO!");
                    Console.WriteLine("------------------------------------------------------------");
                }
                else if (total > 2 & total < 5)
                {
                    Console.WriteLine(nome + " disponíveis: " + total);
                    Console.WriteLine("Atenção!! Estoque em alerta! ");
                    Console.WriteLine("------------------------------------------------------------");
                }
                else
                {
                    Console.WriteLine(nome + " disponíveis: " + total);
                    Console.WriteLine("Estoque cheio! Não é necessário comprar!");
                    Console.WriteLine("------------------------------------------------------------");
                }
            }
            Console.Read();

        }
    }
}
