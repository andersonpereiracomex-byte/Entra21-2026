Console.WriteLine("=== CADASTRO DE USUÁRIO ===");
Console.WriteLine();

Console.Write("Quantos usuários deseja cadastrar? ");
if (!int.TryParse(Console.ReadLine(), out int totalUsuario) || totalUsuario <= 0)
{
    Console.WriteLine("Número inválido. O programa será encerrado.");
    return;
}

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