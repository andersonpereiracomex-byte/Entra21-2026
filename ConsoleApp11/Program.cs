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
       