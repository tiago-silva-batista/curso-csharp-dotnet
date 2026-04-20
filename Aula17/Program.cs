namespace Aula17;

public class Program
{
    public static void Main()
    {
        string separator = "-------------------";

        //1. Declaração com Inicialização de Valores
        List<string> fruits = new List<string>()
        {
            "Manga",
            "Abacate",
            "Pêra"
        };

        //2. Acessar os Valores
        Console.WriteLine(fruits[2]);

        Console.WriteLine(separator);

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //3. Adicionar Elementos
        fruits.Add("Limão");
        fruits.Add("Laranja");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //4. Remover Elementos
        fruits.Remove("Limão");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //5. Contagem de Elementos
        Console.WriteLine("Quantidade de frutas: " + fruits.Count);

        Console.WriteLine(separator);

        //6. Modificar um Elemento
        fruits[2] = "Maracujá";

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //7. Limpas a Lista
        fruits.Clear();

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Console.WriteLine(separator);

        //8.Declarar sem Inicializar
        List<int> numbers = new List<int>();

        numbers.Add(1);
        numbers.Add(50);
        numbers.Add(74);

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}