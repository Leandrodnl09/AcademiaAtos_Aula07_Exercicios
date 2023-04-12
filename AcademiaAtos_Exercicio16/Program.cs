namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
            // multiplicação sucessiva de N por 3 enquanto o produto for menor que 250
            // (N * 3; N * 3 * 3; N * 3 * 3 * 3; etc).

            // Imprime na tela uma mensagem pedindo para o usuário digitar um número
            Console.Write("Digite um número N menor ou igual a 50: ");
            // Lê a entrada do usuário como uma string, converte para inteiro e atribui à variável n

            int n = int.Parse(Console.ReadLine()); 
            int produto = n; // Inicializa a variável produto com o valor de n
          
            while (produto < 250)
            { // Inicia um loop while que executa enquanto produto for menor que 250
                
                Console.WriteLine(produto); // Imprime o valor atual de produto na tela
                produto *= 3; // Multiplica produto por 3 e armazena o resultado em produto
            }
        }
    }
}