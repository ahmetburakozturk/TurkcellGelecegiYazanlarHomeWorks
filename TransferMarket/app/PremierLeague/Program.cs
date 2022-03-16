using PremierLeague.Businness.Concrete;
using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Runtime.InteropServices;
using PremierLeague.Entities;

namespace PremierLeague
{
    public class Program
    {
        public static CountryManager countryManager = new CountryManager(new GenericRepository<Country>());
        public static CoachManager coachManager = new CoachManager(new GenericRepository<Coach>());
        public static LeagueManager leagueManager = new LeagueManager(new GenericRepository<League>());
        public static PlayerManager playerManager = new PlayerManager(new GenericRepository<Player>());
        public static TeamManager teamManager = new TeamManager(new GenericRepository<Team>());

        public static User user;

        static void Main(string[] args)
        {
            user = CreateUser();
            ChooseTeams();
        }

        public static User CreateUser()
        {
            User user = new User();
            return user;
        }

        public static void ChooseTeams()
        {
            Console.WriteLine("Takiminizi Seciniz");
            foreach (var team in teamManager.GetAll())
            {
                Console.WriteLine(team.TeamID+" - "+team.TeamName);
            }
            int choosenID = Convert.ToInt32(Console.ReadLine());
            SetUserTeam(choosenID);
        }

        public static void SetUserTeam(int id)
        {
            if (teamManager.Get(id)!=null)
            {
                user.userTeam = teamManager.Get(id);
                ShowMenu();
            }
            else
            {
                Console.WriteLine("Please enter a valid input!");
                ChooseTeams();
            }
            
        }

        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("1 - Transfer Market");
            Console.WriteLine("2 - Sell Player");
            Console.WriteLine("3 - My Team");
            Console.WriteLine("4 - Quit");
            int userChoose = Convert.ToInt32(Console.ReadLine());
            ChooseMenuItem(userChoose);
        }

        private static void ChooseMenuItem(int userChoose)
        {
            switch (userChoose)
            {
                case 1:
                    ShowMarket();
                    break;
                case 2:
                    SellMenu();
                    break;
                case 3:
                    GetTeamDetails();
                    break;
                case 4:
                    QuitMenu(1);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Lutfen Bir Secim Yapiniz");
                    ShowMenu();
                    break;
            }
        }

        private static void QuitMenu(int v)
        {
            Console.Clear();
            Console.WriteLine("Are you sure want to exit?");
            Console.WriteLine("1: Yes");
            Console.WriteLine("2: No");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    switch (v)
                    {
                        case 1:
                            Environment.Exit(1);
                            ShowMenu();
                            break;
                        case 2:
                            ShowMenu();
                            break;
                        case 3:
                            ShowMenu();
                            break;
                        case 4:
                            ShowMenu();
                            break;
                        case 5:
                            SellMenu();
                            break;
                        case 6:
                            ShowMenu();
                            break;
                    }
                    break;
                case 2:
                    switch (v)
                    {
                        case 1:
                            ShowMenu();
                            break;
                        case 2:
                            ShowMarket();
                            break;
                        case 3:
                            QuitMenu(3);
                            break;
                        case 4:
                            SellMenu();
                            break;
                        case 5:
                            SellPlayer();
                            break;
                        case 6:
                            GetTeamDetails();
                            break;
                    }
                    break;
                default:
                    ShowMenu();
                    break;
            }
        }

        private static void GetTeamDetails()
        {
            Console.Clear();
            Console.WriteLine($" Team: {user.userTeam.TeamName}\n Total Team Value: {user.userTeam.TeamValue}\n Team Budget: {user.userTeam.Budget}\n Players: ");
            ShowPlayersWithTeam();
            Console.WriteLine("Press E to exit...");
            if (Console.ReadLine().ToString()=="e" || Console.ReadLine().ToString()=="E")
            {
                QuitMenu(6);
            }
            else
            {
                Console.WriteLine("Please Enter a valid input!");
                QuitMenu(6);
            }
        }

        private static void ShowMarket()
        {
            Console.Clear();
            foreach (var player in playerManager.GetPlayersForSale())
            {
                Console.WriteLine($" ID: {player.PlayerID}\n Player: {player.PlayerName +" "+ player.PlayerLastName}\n Value: {player.PlayerValue}\n" +
                                  $" Age: {player.Age}\n Team: {player.Team.TeamName}\n Country: {player.Country.CountryName}\n\n");
            }
            Console.WriteLine("Buy Player: 1");
            Console.WriteLine("Exit: 2");

            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter Player Id: ");
                    BuyPlayer(Convert.ToInt32(Console.ReadLine()));
                    break;
                case 2:
                    QuitMenu(2);
                    break;
                default:
                    QuitMenu(2);
                    break;
            }
        }

        private static void BuyPlayer(int v)
        {
            Console.Clear();
            var player = playerManager.Get(v);
            var teamIn = teamManager.Get(user.userTeam.TeamID);
            var teamOut = teamManager.Get(player.TeamID);
            if (player.PlayerValue<=teamIn.Budget)
            {
                teamOut.Budget += player.PlayerValue;
                teamManager.Update(teamOut);
                player.TeamID = user.userTeam.TeamID;
                player.Team = user.userTeam;
                player.State = false;
                playerManager.Update(player);
                Console.WriteLine($"successful purchase \n You Bought {player.PlayerName} {player.PlayerLastName} \n Press E and Enter to Exit...");
                teamIn.Budget -= player.PlayerValue;
                teamManager.Update(teamIn);
            }
            else
            {
                Console.WriteLine("your budget is less than player value!");
                Console.WriteLine("Press E to exit...");
            }
            
            string userInput = Console.ReadLine().ToString();
            if (userInput=="e" || userInput=="E")
            {
                QuitMenu(3);
            }
            else
            {
                Console.WriteLine("Please enter a valid input");
                QuitMenu(3);
            }
        }

        private static void SellMenu()
        {
            Console.Clear();
            ShowPlayersWithTeam();

            Console.WriteLine("Sell Player: 1");
            Console.WriteLine("Exit: 2");
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        SellPlayer();
                        break;
                    case 2:
                        QuitMenu(4);
                        break;
                    default:
                        QuitMenu(4);
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter A Valid Input!");
                SellPlayer();
            }
            
            
        }

        private static void ShowPlayersWithTeam()
        {
            foreach (var player in playerManager.GetPlayerWithTeam(user.userTeam.TeamID))
            {
                Console.WriteLine($"Id: {player.PlayerID}\n Player: {player.PlayerName} {player.PlayerLastName}\n Current Value: {player.PlayerValue}\n\n");
            }
        }

        private static void SellPlayer()
        {
            Console.WriteLine("Enter Player Id: ");
            var player = playerManager.Get(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine($"Player Current Value is {player.PlayerValue}\n Enter a Value For {player.PlayerName} {player.PlayerLastName}: ");
            player.PlayerValue = Convert.ToInt32(Console.ReadLine()); ;
            player.State = true;
            playerManager.Update(player);
            Console.WriteLine("Player Successfully Added in Transfer Market \n Enter E to exit...");
            if (Console.ReadLine().ToString() == "e" || Console.ReadLine().ToString() == "E")
            {
                QuitMenu(5);
            }
            else
            {
                Console.WriteLine("Please enter a valid input");
                QuitMenu(5);
            }

        }

        
    }
}
