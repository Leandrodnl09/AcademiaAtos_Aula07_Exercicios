namespace AcademiaAtos_Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 14. Mostrar as potências de 2 variando de 0 a 10.

            int baseNum = 2; // define a base da potência como sendo 2
            int i = 0; // define o contador do loop como 0

            while (i <= 10)
            { // executa o loop enquanto o contador for menor ou igual a 10
                int potencia = (int)Math.Pow(baseNum, i); // calcula a potência de 2 elevado a i

                Console.WriteLine("2 elevado a {0} é igual a {1}", i, potencia); // exibe o resultado formatado

                i++; // incrementa o contador do loop em 1
            }
        }
    }
}