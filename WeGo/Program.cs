using System;

namespace WeGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Passageiro Passageiro = new Passageiro();
            Console.WriteLine(Passageiro.ConfirmarNome());
            Console.WriteLine(Passageiro.ConfirmarSenha());
            Console.Clear();
            Console.WriteLine($"Bem vindo ao WeGo {Passageiro.Login}");

            Viagem Viagem = new Viagem();
            Console.WriteLine(Viagem.Inicio());
            Console.WriteLine(Viagem.Destino());
            Console.Clear();

            string retorno = Viagem.ConfirmarViagem();
            if (retorno == "s")
            {
                Veiculo Veiculo = new Veiculo();
                Console.WriteLine(Veiculo.EscolherCarro());

                Avaliacao Avaliacao = new Avaliacao();
                Console.WriteLine(Avaliacao.AvaliacaoDaViagem());
            }
            else
            {
                Console.WriteLine("Viagem cancelada");
            }
        }
    }
}