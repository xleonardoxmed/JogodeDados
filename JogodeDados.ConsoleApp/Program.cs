using System.Globalization;

namespace JogodeDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int endLine = 30;

            while (true)
            {
                bool gameReading = true;
                int playerPosition = 0;
                int computerPosition = 0;

                while (gameReading)
                {
                    int playerResult = Start(playerPosition, endLine);
                    playerPosition += playerResult;
                    int computerResult = 0;                    

                    if (playerPosition > endLine)
                    {
                        playerPosition = endLine;
                    }

                    if (playerPosition == endLine)
                    {
                        Console.WriteLine($"Parabéns! Você chegou na casa: {playerPosition} de {endLine}!");
                        Console.WriteLine("--------------------------------------");
                        gameReading = false;
                        continue;
                    }
                    Console.WriteLine($"Você chegou na casa: {playerPosition} de {endLine}!");
                    Console.WriteLine("--------------------------------------");
                    playerEspecialCases(playerPosition, endLine);

                    if (playerPosition > endLine)
                    {
                        playerPosition = endLine;
                    }

                    if (playerPosition == endLine)
                    {
                        Console.WriteLine($"Parabéns! Você chegou na casa: {playerPosition} de {endLine}!");
                        Console.WriteLine("--------------------------------------");
                        gameReading = false;
                        continue;
                    }                                 


                    Console.Read();
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Rodada do Computador");
                    Console.WriteLine("--------------------------------------");
                    Console.Write("Pressione 'ENTER' para ver o resultado: ");
                    Console.ReadLine();
                    Console.ReadLine();

                    computerResult = roleDices();
                    computerPosition += computerResult;
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine($"O valor sorteado foi: {computerPosition}");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine($"O computador chegou a casa {computerPosition} de {endLine}!");
                    Console.WriteLine("--------------------------------------");

                    if (computerPosition > endLine)
                    {
                        computerPosition = endLine;
                    }

                    if (computerPosition >= endLine)
                    {   
                        computerPosition = endLine;
                        Console.WriteLine($"Você perdeu! O computador chegou na casa: {computerPosition} de {endLine}!");
                        Console.WriteLine("--------------------------------------");
                        gameReading = false;
                        continue;
                    }
                    ComputerEspecialCases(computerPosition, endLine);

                    Console.ReadLine();
                }
                string loop = ReplayCheck();
                if (loop != "S")
                    break;
            }
        }
        static int roleDices()
        {
            int result;
            Random NumbersGenerator = new Random();
            result = NumbersGenerator.Next(1, 7);
            return result;
        }
        static string ReplayCheck()
        {
            Console.Write("Deseja continuar? (S/N): ");
            string ToContinue = Console.ReadLine()!.ToUpper();
            return ToContinue;
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
            playerPosition = NumbersGenerator.Next(1, 7);  
            
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"O valor sorteado foi: {playerPosition}");
            Console.WriteLine("--------------------------------------");          
            return playerPosition;  
        }    
           static int playerEspecialCases(int playerPosition, int endLine)
        {
            if (playerPosition == 5 || playerPosition == 10 || playerPosition == 15 || playerPosition == 25)
            {             
                Console.WriteLine("Evento especial! Avanço extra de 3 casas!");
                playerPosition += 3;
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Você avançou para a posição: {playerPosition} de {endLine}!");
            }

            if (playerPosition == 7 || playerPosition == 14 || playerPosition == 20)
            {               
                Console.WriteLine("Evento especial! Recuo de 2 casas!");
                playerPosition -= 2;
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Você recuou para a posição: {playerPosition} de {endLine}!");
            }
            return playerPosition;
        }

        static int ComputerEspecialCases(int computerPosition, int endLine)
        {
            if (computerPosition == 5 || computerPosition == 10 || computerPosition == 15 || computerPosition == 25)
            {
                Console.WriteLine("Evento especial! Avanço extra de 3 casas!");
                computerPosition += 3;
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"O computador avançou para a posição: {computerPosition} de {endLine}!");
            }

            if (computerPosition == 7 || computerPosition == 14 || computerPosition == 20)
            {
                Console.WriteLine("Evento especial! Recuo de 2 casas!");
                computerPosition -= 2;
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"O computador recuou para a posição: {computerPosition} de {endLine}!");
            }
            return computerPosition;
        }
    }
}
