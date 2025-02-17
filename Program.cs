﻿using EnergyRunner_v2.classes;
namespace EnergyRunner_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            bool running = true;
            while (running)
            {
                Console.Clear();
                int size = GetUserInput("How big would you like to have a map? ");
                Game game = new Game(size);
                do
                {
                    if (game.Player.PositionX == game.Home.PositionX && game.Player.PositionY == game.Home.PositionY)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You won!");
                        Console.ResetColor();
                        Console.Write("Do you want to play again? (write 'Yes' to play again): ");
                        string answer = Console.ReadLine();
                        if (answer != "Yes")
                        {
                            running = false; 
                        }
                        GC.Collect();
                        break;
                    }
                    else if (game.Player.Energy <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You lost!");
                        Console.ResetColor();
                        Console.Write("Do you want to play again? (write 'Yes' to play again): ");
                        string answer = Console.ReadLine();
                        if (answer != "Yes")
                        {
                            running = false;
                        }
                        GC.Collect();
                        break;

                    }
                    game.UpdateBoard();
                    game.DisplayBoard();
                    game.GiveInstructions();

                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.UpArrow && game.Player.PositionY != 0)
                    {
                        game.Player.Move(Direction.Up);
                        game.Player.Energy += game.Board[game.Player.PositionY, game.Player.PositionX];
                    }
                    else if (key.Key == ConsoleKey.DownArrow && game.Player.PositionY != game.Size - 1)
                    {
                        game.Player.Move(Direction.Down);
                        game.Player.Energy += game.Board[game.Player.PositionY, game.Player.PositionX];
                    }
                    else if (key.Key == ConsoleKey.RightArrow && game.Player.PositionX != game.Size - 1)
                    {
                        game.Player.Move(Direction.Right);
                        game.Player.Energy += game.Board[game.Player.PositionY, game.Player.PositionX];
                    }
                    else if (key.Key == ConsoleKey.LeftArrow && game.Player.PositionX != 0)
                    {
                        game.Player.Move(Direction.Left);
                        game.Player.Energy += game.Board[game.Player.PositionY, game.Player.PositionX];
                    }
                    Console.Clear();
                }
                while (true);
                //pytanie do gracza jak duża mapa
                //na samym początku wyświetla się plansza z grą
                //jest pod nią instrukcja
                //jak gracz wykona ruch to plansza się resetuje
                //i tak w kółko aż nie dojdzie do celu
                //jak gracz wygra to gra go nagradza komplementem i się go pyta czy chce grać dalej
                //jak tak to tworzy nową grę, 
                //a jak nie to wychodzi z gry
            }
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
