namespace Aula19;

public class Program
{
    public static void Main()
    {
        //1. Estrutura
        string path = @"C:\Users\tiago\OneDrive\Área de Trabalho\Curso-Csharp-DotNet\Aula19\";
        string fileName = "shopping_list.txt";
        string filePath = path + fileName;

        List<string> shoppingList = new List<string>();

        //2. Lógica
        if (File.Exists(filePath))
        {
            shoppingList.AddRange(File.ReadAllLines(filePath));
        }

        while (true)
        {
            Console.WriteLine("\n=== Lista de Compras ===");
            Console.WriteLine("1. Adicionar item");
            Console.WriteLine("2. Remover item");
            Console.WriteLine("3. Exibir lista");
            Console.WriteLine("4. Exportar a lista em .txt");
            Console.WriteLine("Escolha um número para continuar:");

            string choiceUser = Console.ReadLine();

            switch (choiceUser)
            {
                case "1":
                    Console.WriteLine("Digite o nome do item para adicionar: ");
                    string itemInsert = Console.ReadLine();

                    if (!string.IsNullOrEmpty(itemInsert))
                    {
                        shoppingList.Add(itemInsert);
                        Console.WriteLine($"Item '{itemInsert}' adicionado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("O item não pode ser vazio!");
                    }
                    break;

                case "2":
                    Console.WriteLine("Digite o nome do item para remover: ");
                    string itemToRemove = Console.ReadLine();

                    if (shoppingList.Remove(itemToRemove))
                    {
                        Console.WriteLine($"Item '{itemToRemove}' removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine($"Item '{itemToRemove}' não encontrado");
                    }
                    break;

                case "3":
                    Console.WriteLine("\n Itens na sua lista de compras: ");

                    if (shoppingList.Count == 0)
                    {
                        Console.WriteLine("Sua lista está vazia");
                    }
                    else
                    {
                        for (int i = 0; i < shoppingList.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {shoppingList[i]}");
                        }
                    }
                    break;

                case "4":
                    File.WriteAllLines(filePath, shoppingList);
                    Console.WriteLine("Lista salva com sucesso! Saindo...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente");
                    break;
            }
        }
    }
}