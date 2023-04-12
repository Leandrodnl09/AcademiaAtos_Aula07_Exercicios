using System.Diagnostics.Metrics;

namespace AcademiaAtos_Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
            // Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
            // Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA. 
            // Você também pode aceitar votos em branco(palavra BRANCO).O programa em VS termina quando o usuário
            // escrever FIM.Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número
            // de votos em branco.

            // 5.Modifique o programa em VS anterior para aceitar votos nulos
            // (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO).
            // Ao final, informe o nome do candidato vencedor, o número de votos nulos
            // e o número de pessoas que votaram.

            int votosJoao = 0;
            int votosZeca = 0;
            int votosBranco = 0;
            int votosNulos = 0;
            int totalVotos = 0;

            Console.WriteLine("Digite o nome do candidato (JOAO ou ZECA) ou BRANCO para voto em branco. Digite FIM para encerrar a votação.");

            while (true)
            {
                string voto = Console.ReadLine().ToUpper();

                if (voto == "FIM")
                {
                    break;
                }
                else if (voto == "JOAO")
                {
                    votosJoao++;
                    totalVotos++;
                }
                else if (voto == "ZECA")
                {
                    votosZeca++;
                    totalVotos++;
                }
                else if (voto == "BRANCO")
                {
                    votosBranco++;
                    totalVotos++;
                }
                else
                {
                    votosNulos++;
                    totalVotos++;
                }
            }

            Console.WriteLine("Total de votos para JOAO: " + votosJoao);
            Console.WriteLine("Total de votos para ZECA: " + votosZeca);
            Console.WriteLine("Total de votos em branco: " + votosBranco);
            Console.WriteLine("Total de votos nulos: " + votosNulos);
            Console.WriteLine("Total de votos válidos: " + (totalVotos - votosNulos));

            if (votosJoao > votosZeca)
            {
                Console.WriteLine("O candidato vencedor é JOAO, com " + votosJoao + " votos.");
            }
            else if (votosZeca > votosJoao)
            {
                Console.WriteLine("O candidato vencedor é ZECA, com " + votosZeca + " votos.");
            }
            else
            {
                Console.WriteLine("Houve um empate entre os candidatos.");
            }
        }
    }
}