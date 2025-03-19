using System.Globalization;

namespace JogodeDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int endLine = 30;

            while(true)
            {
                int playerPosition = 0;
                int computerPosition = 0;
                bool gameReading = true;

                while (gameReading)
                {
                    int playerResult = Start(playerPosition, endLine);
                    playerPosition += playerResult;

                    if (playerPosition >= endLine)
                    {
                        playerWon(gameReading, playerPosition);
                        Console.WriteLine("Parabéns! Você terminou! 30 de 30!");
                        Console.WriteLine("--------------------------------------");
                        break;
                    }
                    Console.WriteLine($"Você chegou na casa: {playerPosition} de {endLine}!");
                    playerEspecialCases(playerPosition, endLine);

                    if (playerPosition >= endLine)
                    {
                        playerWon(gameReading, playerPosition);
                        
                        break;
                    }

                    Console.ReadLine();
                }
                int loop = ReplayCheck();
                if (loop != 0)
                    break;
            }
        }
        static int ReplayCheck()
        {
            Console.Write("Deseja continuar? (S/N): ");
            string ToContinue = Console.ReadLine()!.ToUpper();
            if (ToContinue != "S")
                return 1;//sim
            else
                return 0;//nao
        }
        static int Start(int playerPosition, int endLine)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("JOGO DE DADOS LAGEANO");
            Console.WriteLine("--------------------------------------");           
            Console.WriteLine("Rodada do usuário");
            Console.WriteLine("--------------------------------------");
            Console.Write("Pressione 'ENTER' para jogar os dados: ");
            Console.ReadLine();

            Random NumbersGenerator = new Random();
            int playerResult = NumbersGenerator.Next(1, 7);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"O valor sorteado foi: {playerResult}");
            Console.WriteLine("--------------------------------------");          
            return playerResult;  
        }
           static bool playerWon(bool gameReading, int playerPosition)
        {
                playerPosition = 30;         

                return gameReading = false;
        }
        
           static int playerEspecialCases(int playerPosition, int endLine)
        {
            if (playerPosition == 5 || playerPosition == 10 || playerPosition == 15 || playerPosition == 25)
            {
                
                Console.WriteLine("Evento especial! Avanço extra de 3 casas!");
                playerPosition += 3;
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Você avançou para a posição: {playerPosition}");
            }
            

            if (playerPosition == 7 || playerPosition == 14 || playerPosition == 20)
            {
                
                Console.WriteLine("Evento especial! Recuo de 2 casas!");
                playerPosition -= 2;
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Você recuou para a posição: {playerPosition}");
            }
            return playerPosition;
        }
    }
}
