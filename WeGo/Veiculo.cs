using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeGo
{
    public class Veiculo
    {
        public int Escolha;

        public string EscolherCarro()
        {
            Console.WriteLine("Escolha o modelo do seu carro: ");
            Console.WriteLine("1 - Modelo Pratice");
            Console.WriteLine("2 - Modelo Classic");
            Escolha = int.Parse(Console.ReadLine());
            switch (Escolha)
            {
                case 1:
                    Console.WriteLine("Você escolheu a opção 1 - o modelo Pratice");
                    break;
                case 2:
                    Console.WriteLine("Você escolheu a opção 2 - o modelo Classic");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            return "";
        }
    }
}
