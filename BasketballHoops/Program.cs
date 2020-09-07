using System;
using System.Threading.Tasks;

namespace BasketballHoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string teamName1 = "";
            string teamName2 = "";


            Console.WriteLine("Welcome to Earl Weaver Basketball 1990!");
            Console.Write("Please enter the first team's name: ");
            teamName1 = Console.ReadLine();

            BBallTeam team1 = new BBallTeam(teamName1);

            Console.WriteLine();
            Console.Write("Please enter the second team's name: ");
            teamName2 = Console.ReadLine();

            BBallTeam team2 = new BBallTeam(teamName2);

            Console.WriteLine("Time to make the players for our teams...");
            Task.Delay(1000).Wait();
            Console.Clear();

            Console.WriteLine("Let's start with the {0} team!", team1);

            Player[] team1Players =
            {
                new Player(teamName1),
                new Player(teamName1),
                new Player(teamName1),
                new Player(teamName1),
                new Player(teamName1)
            };

            Console.WriteLine("Excelent! {0} consists of the following players: ", team1.teamName);

            for(int i = 0; i < team1Players.Length; i++)
            {
                Console.WriteLine(team1Players[i].playerName);
            }

            Console.Clear();
            Console.WriteLine("Time for the {0} team to create its players!", teamName2);

            Player[] team2Players =
            {
                new Player(teamName2),
                new Player(teamName2),
                new Player(teamName2),
                new Player(teamName2),
                new Player(teamName2)
            };

            Console.WriteLine("Excelent! {0} consists of the following players: ", team2.teamName);

            for (int i = 0; i < team2Players.Length; i++)
            {
                Console.WriteLine(team2Players[i].playerName);
            }

            Console.ReadLine();

        }
    }
}
