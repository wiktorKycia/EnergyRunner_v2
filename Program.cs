namespace EnergyRunner_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How big would you like to have a map? ");
            int x = int.Parse(Console.ReadLine());
            //pytanie do gracza jak duża mapa
            //na samym początku wyświetla się plansza z grą
            //jest pod nią instrukcja
            //jak gracz wykona ruch to plansza się resetuje
            //i tak w kółko aż nie dojdzie do celu
            //jak gracz wygra to gra go nagradza komplementem i się go pyta czy chce grać dalej
            //jak tak to tworzy nową grę, 
            //a jak nie to wychodzi z gry
        }
        static int GetUserInput(string message)
        {
            int result = 0;
            do
            {
                try
                {
                    Console.Write(message);
                    result = int.Parse(Console.ReadLine());
                    if (result <= 0) { throw new FormatException(); }
                    else { return result; }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.Write("The number must be a positive integer! Try again: ");
                }
            }
            while(result <= 0);
            return result;
        }
    }
}
