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