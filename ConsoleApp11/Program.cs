using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Busca ou remoção de usuário:");
        Console.WriteLine("Digite o nome do usuário:");
        string nomeUsuario = Console.ReadLine();
        Console.WriteLine("Digite a ação (buscar ou remover):");
        Console.WriteLine("1 - Buscar");
        Console.WriteLine("2 - Remover");
        string acao = Console.ReadLine();
        if (acao == "1")
        {
            Console.WriteLine($"Buscando usuário: {nomeUsuario}");
            // Lógica de busca aqui
        }
        else if (acao == "2")
        {
            Console.WriteLine($"Removendo usuário: {nomeUsuario}");
            // Lógica de remoção aqui
        }
        else
        {
            Console.WriteLine("Ação inválida. Por favor, escolha 1 ou 2.");
        }
        

    }
}
