using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {   //Mensagem de Boas vindas e instruções ao usuário;
        //Destaco que está inscrito todas as requisições de senha reportado pela equipe da área de negócio;
        Console.WriteLine("Bem vindo! Digite uma senha que atenda os mínimos requisitos abaixo:");
        Console.WriteLine("08 caracteres;");
        Console.WriteLine("04 números;");
        Console.WriteLine("01 caractere especial;");
        Console.WriteLine("01 letras maiúscula;");
        Console.WriteLine("03 letras; \n");
        Console.WriteLine("Digite a senha:");
        //Usuário escreve a senha
        string senha = Console.ReadLine();

        //Mensagem ao usuário informando se a senha digitada atende ou não aos requisitos mínimos;
        if (ValidorDeSenha(senha))
        {
            Console.WriteLine("Parabéns, sua senha é valida"); Console.ReadLine();
        }
        else
        {
            Console.WriteLine("A senha escrita não atende os requisitos mínimos solicitados"); Console.ReadLine();
        }
    }

    static bool ValidorDeSenha(string senha)
    {
        // Verifica se a senha tem pelo menos 08 caracteres;
        if (senha.Length < 8) { return false; }
        // Verifica se a senha tem pelo menos 04 números;
        if (!Regex.IsMatch(senha, @"(?:.*[0-9]){4}")) {return false;}
        // Verifica se a senha tem pelo menos 01 caractere especial;
        if (!Regex.IsMatch(senha, @"[\W_]")) { return false; }
        // Verifica se a senha tem pelo menos 01 letras maiúscula;
        if (!Regex.IsMatch(senha, @"[A-Z]")) { return false; }
        // Verifica se a senha tem pelo menos 03 letras;
        if (!Regex.IsMatch(senha, @"(?:.*[a-z, A-Z]){3}")) {return false;}
        else
        {
            return true;
        }
    }
}
    
    

