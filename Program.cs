using System;

namespace Condicionais_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if(idade >= 18) {
                Console.WriteLine("Você gostaria participar do time de CS GO? - SIM ou NÃO");
                string resposta = Console.ReadLine();
                if(resposta == "SIM") {
                    Console.WriteLine("Compareça à Secretaria e fale com a Sara");
                }
                else {
                    Console.WriteLine("Beleza. Passar bem!");
                }
            }

            else {
                Console.WriteLine("Você gostaria de participar do time de LoL? - SIM ou NÃO");
                string resposta = Console.ReadLine();
                if(resposta == "SIM") {
                    Console.WriteLine("Compareça à Secretaria e fale com o Juscelino");
                }
                else {
                    Console.WriteLine("Muito obrigado!");
                }
            }
        }
    }
}
