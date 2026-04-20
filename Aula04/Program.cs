namespace Aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("-----CADASTRO DE USUÁRIO-----");

        //Solicitar o nome de usuário
        Console.WriteLine("Digite seu nome: ");
        string name = Console.ReadLine();
        Console.WriteLine("Nome do usuário: " + name);

        //Solicitar a idade do usuário
        Console.WriteLine("Digite sua idade: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("-----------------------------------------");

        Console.WriteLine("Nome do usuário: " + name);
        Console.WriteLine("Idade do usuário: " + age);

    }
}