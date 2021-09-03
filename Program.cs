using System;

namespace Else_if_Enemies_Defeated
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = "Gulram Stonebeard";
            int defeatedEnemies = 1;
            int points = 0;
            int bonusPoints = 0;
            int totalPoints = 0;

            if (defeatedEnemies == 100)
            {
                points = 100;
                bonusPoints = (int)(points * .2);
                totalPoints = points + bonusPoints;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Congratulations, {playerName}! You defeated all the enemies! You receive {points} points and a bonus of {bonusPoints} points, for a total of {totalPoints} points!");
                Console.ResetColor();
            }
            else if (defeatedEnemies >= 75 && defeatedEnemies <= 99)
            {
                points = 81;
                bonusPoints = (int)(points * .05);
                totalPoints = points + bonusPoints;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Congratulations, {playerName}! You defeated many enemies! You receive {points} points and a bonus of {bonusPoints} points, for a total of {totalPoints} points!");
                Console.ResetColor();
            }
            else if(defeatedEnemies >= 50 && defeatedEnemies <= 74)
            {
                points = 64;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Congratulations, {playerName}! You defeated some enemies! You receive {points} points!");
                Console.ResetColor();
            }
            else if (defeatedEnemies >= 0 && defeatedEnemies <= 49)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Sorry, {playerName}, you were defeated.");
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Error. Invalid amount");
            }
        }
    }
}
