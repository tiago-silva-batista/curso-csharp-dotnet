namespace Aula14;

public class Program
{
    public static void Main()
    {
        /*
        for (condicao 1; condicao 2; condicao 3)
        {
            //Code que será executado
        }

            Declaração 1 é executada (uma vez) antes da execução do bloco do código.

            Declaração 2 define a condição para executar o bloco do código.

            Declaração 3 é executado (todas as vezes) após o bloco de código ter sido executado.
        */

        // Exemplo 1
        // for (int i = 1; i <= 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // Exemplo 2
        Console.WriteLine("--------Tabela de Multiplicação--------");

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{i * j,6}");
            }
            Console.WriteLine();
        }
    }
}