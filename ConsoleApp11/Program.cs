string[] nomes = new string[0];
int totalUsuario = 0;
string opcao = "";

while (opcao != "5")
{
    Console.WriteLine("====== SISTEMA DE USUÁRIOS ======");
    Console.WriteLine("1 - Cadastrar usuário");
    Console.WriteLine("2 - Listar usuários");
    Console.WriteLine("3 - Buscar usuário");
    Console.WriteLine("4 - Remover usuário");
    Console.WriteLine("5 - Sair");
    Console.Write("Escolha uma opção: ");
    opcao = Console.ReadLine();
}
    case "1":
        bool encontrado = false;
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nomeUsuario)
            {
                Console.WriteLine("Usuário encontrado: " + nomes[i]);
                encontrado = true;
                break;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("Usuário não encontrado.");
        }
        break;
    case "2":
        bool removido = false;
        for (int i = 0; i < nomes.Length; i++)
        {
            if (nomes[i] == nomeUsuario)
            {
                for (int j = i; j < nomes.Length - 1; j++)
                {
                    nomes[j] = nomes[j + 1];
                }
                Array.Resize(ref nomes, nomes.Length - 1);
                Console.WriteLine("Usuário removido: " + nomeUsuario);
                removido = true;
                break;
            }
        }
        if (!removido)
        {
            Console.WriteLine("Usuário não encontrado para remoção.");
        }
        break;
    default:
        Console.WriteLine("Ação inválida.");
        break;
}

