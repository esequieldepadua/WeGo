using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeGo
{
    public class Viagem
    {
        public string Saida = "";
        public string Chegada = "";
        public string Resposta = "";

        public string Inicio()
        {
            Console.WriteLine("Informe o endereço do início da viagem: ");
            Saida = Console.ReadLine();
            Console.Clear();
            return Saida;
        }
        public string Destino()
        {
            Console.WriteLine("Informe o endereço de chegada: ");
            Chegada = Console.ReadLine();
            Console.Clear();
            return Chegada;
        }
        public string ConfirmarViagem()
        {
            Console.WriteLine("Saida: " + Saida);
            Console.WriteLine("Chegada: " + Chegada);
            Console.WriteLine("Deseja confirmar a viagem? (S/N)");

            string resposta = Console.ReadLine().ToLower();

            if (resposta == "s")
            {
                Console.Clear();
                return "s";
            }
            else
            {
                Console.Clear();
                return "n";
            }
        }
    }
}
