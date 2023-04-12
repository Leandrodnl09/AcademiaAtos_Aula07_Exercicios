namespace AcademiaAtos_Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
            // a média aritmética da turma e a quantidade de alunos da turma. Usar - 1 para encerrar a leitura.

            double nota, somaNotas = 0, notaMaisAlta = double.MinValue, notaMaisBaixa = double.MaxValue;
            // Declaração das variáveis.
            int contador = 0;
            // Declaração da variável contador, que será utilizada para contar o número de notas digitadas.

            Console.WriteLine("Digite as notas dos alunos (-1 para encerrar):");
            // Imprime uma mensagem solicitando ao usuário que digite as notas dos alunos.

            while (true)
            {
                nota = double.Parse(Console.ReadLine());
                // Lê uma nota digitada pelo usuário e armazena na variável nota.

                if (nota == -1)
                {
                    break;
                }
                // Verifica se a nota digitada é igual a -1. Se for, encerra o laço while com a instrução break.

                contador++;
                // Incrementa o contador.

                somaNotas += nota;
                // Soma a nota digitada à variável somaNotas.

                if (nota > notaMaisAlta)
                {
                    notaMaisAlta = nota;
                }
                // Verifica se a nota digitada é maior do que a nota armazenada em notaMaisAlta. Se for, atualiza a variável notaMaisAlta.

                if (nota < notaMaisBaixa)
                {
                    notaMaisBaixa = nota;
                }
                // Verifica se a nota digitada é menor do que a nota armazenada em notaMaisBaixa. Se for, atualiza a variável notaMaisBaixa.
            }

            if (contador == 0)
            {
                Console.WriteLine("Não foram digitadas notas.");
            }
            else
            {
                double media = somaNotas / contador;
                // Calcula a média aritmética das notas.

                Console.WriteLine("A nota mais alta é: " + notaMaisAlta);
                Console.WriteLine("A nota mais baixa é: " + notaMaisBaixa);
                Console.WriteLine("A média aritmética da turma é: " + media);
                Console.WriteLine("A quantidade de alunos da turma é: " + contador);
                // Imprime as informações solicitadas na tela.
            }
        }
    }
}