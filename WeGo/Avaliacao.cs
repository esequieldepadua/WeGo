using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeGo
{
    public class Avaliacao
    {
        public int nota;
        public string AvaliacaoDaViagem()
        {
            Console.WriteLine("Obrigado por viajar com a WeGo");
            Console.WriteLine("Avalie sua Viagem");
            Console.WriteLine("1 - Ruim");
            Console.WriteLine("2 - Bom");
            Console.WriteLine("3 - Ótimo");
            nota = int.Parse(Console.ReadLine());
            switch (nota)
            {
                case 1:
                    Console.WriteLine("Você escolheu a opção 1 - Ruim");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a opção 2 - Bom");
                    break;
                case 3:
                    Console.WriteLine("Você escolheu a opção 3 - Ótimo");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            return "";
        }
    }
}
