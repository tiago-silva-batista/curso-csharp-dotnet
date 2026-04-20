namespace Aula08
{
    public class Program()
    {
        public static void Main()
        {
            Console.WriteLine("--------Operadores Relacionais--------\n");
            Console.WriteLine("Digite o primeiro número(x): ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número(y): ");
            int y = Convert.ToInt32(Console.ReadLine());

            string result;

            //Operador de Igualdade (==)
            if (x == y)
            {
                result = "x é igual a y";
            }
            else
            {
                result = "x é diferente de y";
            }
            Console.WriteLine("\nIgualdade (==): " + result);

            //Operador de Diferença (!=)
            if (x != y)
            {
                result = "x é diferente de y";
            }
            else
            {
                result = "x é igual a y";
            }
            Console.WriteLine("\nDiferença (!=): " + result);

            //Operador Maior Que (>)
            if (x > y)
            {
                result = "x é maior que y";
            }
            else
            {
                result = "x não é maior que y";
            }
            Console.WriteLine("\nMaior que (>): " + result);

            //Operador Menor Que (<)
            if (x < y)
            {
                result = "x é menor y";
            }
            else
            {
                result = "x não é menor que y";
            }
            Console.WriteLine("\nMenor que (<): " + result);

            //Operador Maior ou Igual (>=)
            if (x >= y)
            {
                result = "x é maior ou igual a y";
            }
            else
            {
                result = "x não é maior ou igual a y";
            }
            Console.WriteLine("\nMaior ou igual (>=): " + result);

            //Operador Menor ou Igual (<=)
            if (x <= y)
            {
                result = "x é menor ou igual a y";
            }
            else
            {
                result = "x não é menor ou igual a y";
            }
            Console.WriteLine("\nMenor ou igual (<=): " + result);
        }
    }

}