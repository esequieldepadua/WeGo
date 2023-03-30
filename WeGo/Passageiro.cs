using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WeGo
{
    public class Passageiro
    {
        public string Login = "";
        public string Senha= "";

        public string ConfirmarNome()
        {
            Console.Clear();
            Console.WriteLine("Informe seu login: ");
            Login = Console.ReadLine();
            return Login;
        }
        public string ConfirmarSenha()
        {
            Console.Clear();
            Console.WriteLine("Informe sua senha: ");
            Senha = Console.ReadLine();
            return Senha;
        }
    }
}
