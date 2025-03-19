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
                bool gameReading = true;

                while (gameReading)
                {
                    int result = Start();

                    playerPosition += result;

                    if (playerPosition >= endLine)
                    {
                        gameReading = false;
                        Console.WriteLine("Parabéns! Você chegou na ultima casa!");
                        Console.WriteLine("--------------------------------------");
                    }
                    else
                        Console.WriteLine($"Você chegou na casa: {playerPosition} de {endLine}!");
     
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
        static int Start()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("JOGO DE DADOS LAGEANO");
            Console.WriteLine("--------------------------------------");

            Console.Write("Pressione 'ENTER' para jogar os dados");
            Console.ReadLine();

            Random NumbersGenerator = new Random();
            int result = NumbersGenerator.Next(1, 7);
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"O valor sorteado foi: {result}");
            Console.WriteLine("--------------------------------------");
            return result;
        }
    }
}
