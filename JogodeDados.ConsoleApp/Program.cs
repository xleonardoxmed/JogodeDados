using System.Globalization;

namespace JogodeDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Start();

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
