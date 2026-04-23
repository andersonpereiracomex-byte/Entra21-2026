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