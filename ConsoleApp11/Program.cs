Console.WriteLine("=== Listagem e exibição dos usuários ===\n");
Console.Write("Digite um nome de usuário: ");
string nome = Console.ReadLine();

if (nome != null)
{
    Console.WriteLine($"\nNome de usuário encontrado, Bem vindo {nome}!");
}
else if (nome == null)
{
    Console.WriteLine("Nome de usuário INVÁLIDO, tente novamente!");
}

Console.WriteLine("Listagem de Usuários");
for (int i = 0; i < nome.Length; i++)
{
    Console.WriteLine($" {nome[i]}");
}

Console.WriteLine("Deseja exibir os contatos dos usuários? (s/n)");
string resposta = Console.ReadLine();
switch (resposta)
{
    case "s":
        Console.WriteLine("Exibindo contatos dos usuários...");
        for (int i = 0; i < nome.Length; i++)
        {
            Console.WriteLine($" {nome[i]}");
        }
        break;
    case "n":
        Console.WriteLine("Contatos dos usuários não serão exibidos.");
        break;
    default:
        Console.WriteLine("Resposta inválida.");
        break;
}