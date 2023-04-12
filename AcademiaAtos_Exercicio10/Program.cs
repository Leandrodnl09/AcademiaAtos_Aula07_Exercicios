namespace AcademiaAtos_Exercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
            // Número de pessoas do sexo masculino.
            // Número de pessoas do sexo feminino.
            // Número de pessoas com idade inferior a 30 anos.
            // Número de pessoas com idade superior a 60 anos.
            // Média de idade das mulheres.

            int contador = 0;
            int masculino = 0;
            int feminino = 0;
            int idadeInferior30 = 0;
            int idadeSuperior60 = 0;
            int somaIdadeMulheres = 0;
            int quantidadeMulheres = 0;

            while (contador < 50)
            {
                Console.WriteLine($"Digite o nome da {contador + 1}ª pessoa:");
                string nome = Console.ReadLine();

                Console.WriteLine($"Digite o sexo da {contador + 1}ª pessoa (M/F):");
                char sexo = Console.ReadLine().ToUpper()[0];

                Console.WriteLine($"Digite a idade da {contador + 1}ª pessoa:");
                int idade = int.Parse(Console.ReadLine());

                if (sexo == 'M')
                {
                    masculino++;
                }
                else if (sexo == 'F')
                {
                    feminino++;
                    somaIdadeMulheres += idade;
                    quantidadeMulheres++;
                }

                if (idade < 30)
                {
                    idadeInferior30++;
                }
                else if (idade > 60)
                {
                    idadeSuperior60++;
                }

                contador++;
            }

            Console.WriteLine("Número de pessoas do sexo masculino: " + masculino);
            Console.WriteLine("Número de pessoas do sexo feminino: " + feminino);
            Console.WriteLine("Número de pessoas com idade inferior a 30 anos: " + idadeInferior30);
            Console.WriteLine("Número de pessoas com idade superior a 60 anos: " + idadeSuperior60);

            if (quantidadeMulheres > 0)
            {
                double mediaIdadeMulheres = (double)somaIdadeMulheres / quantidadeMulheres;
                Console.WriteLine("Média de idade das mulheres: " + mediaIdadeMulheres);
            }
            else
            {
                Console.WriteLine("Não há mulheres na lista.");
            }
        }
    }
}