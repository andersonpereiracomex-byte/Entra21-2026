Console.WriteLine("=== CADASTRO DE USUÁRIO ===");
Console.WriteLine();

Console.Write("Quantos usuários deseja cadastrar? ");
int totalUsuario = int.Parse(Console.ReadLine());

string[] nomes = new string[totalUsuario];

for (int i = 0; i < totalUsuario; i++)
{
    Console.Write("Digite o nome: ");
    string novoNome = Console.ReadLine();

    if (novoNome == "")
    {
        Console.WriteLine("Nome não pode ser vazio!");
        i--;
        continue;
    }

    nomes[i] = novoNome;
    Console.WriteLine($"Usuário '{novoNome}' cadastrado com sucesso!");
}

Console.WriteLine("== CADASTRO CONCLUÍDO ==");
Console.WriteLine($"Total de usuários cadastrados: {totalUsuario}");



Console.WriteLine("Busca ou Remoção de usuário:");
Console.WriteLine("Digite o nome do usuário:");
string nomeUsuario = Console.ReadLine();
Console.WriteLine("Digite a ação (buscar ou remover):");
Console.WriteLine("1 - Buscar");
Console.WriteLine("2 - Remover");
string acao = Console.ReadLine();
switch (acao)
{
    case "1":
        bool encontrado = false;
        for (int i = 0; i < nome.Length; i++)
        {
            if (nome[i] == nomeUsuario)
            {
                Console.WriteLine("Usuário encontrado: " + nome[i]);
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
        for (int i = 0; i < nome.Length; i++)
        {
            if (nome[i] == nomeUsuario)
            {
                for (int j = i; j < nome.Length - 1; j++)
                {
                    nome[j] = nome[j + 1];
                }
                Array.Resize(ref nome, nome.Length - 1);
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

