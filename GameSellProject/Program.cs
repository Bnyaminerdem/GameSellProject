using System;
using GameSellProject.Abstrack;
using GameSellProject.Concrete;
using GameSellProject.Entities;
using GameSellProject.Entities.Discounts;
using GameSellProject.Entities.Games;

class Program
{
    static void Main()
    {
        IUserValidationService userValidationService = new UserValidationService();
        IPlayerService playerManager = new PlayerManager(userValidationService);

        Player player = new Player
        {
            FirstName = "Bünyamin Erdem",
            LastName = "Çiftçi",
            DateOfBirth = new DateTime(2005, 8, 15),
            TcNo = "11263353538"
        };

        if (playerManager.CheckIfRealPerson(player))
        {
            playerManager.Add(player);

            IGameService gameManager = new GameManager();
            Game game = new Game
            {
                GameName = "Blazing Sails",
                GamePrice = 39.99
            };

            IGameService csGoManager = new CsGoManager();
            Game csGoGame = new Game
            {
                GameName = "Counter-Strike: Global Offensive",
                GamePrice = 59.75
            };

            csGoManager.Sell(csGoGame, player);

            IGameService gta5Manager = new GTA5Manager();
            Game gta5Game = new Game
            {
                GameName = "Grand Theft Auto V",
                GamePrice = 69.50
            };

            gta5Manager.Sell(gta5Game, player);
            gameManager.Sell(game, player);

            IDiscountService christmasDiscount = new ChristmasDiscount();
            IDiscountService summerDiscount = new SummerDiscount();
            IDiscountService welcomeDiscount = new WelcomeDiscount();

            Console.WriteLine("\nUygulanan İndirimler:");
            Console.WriteLine(christmasDiscount.Name());
            christmasDiscount.Discount();

            Console.WriteLine(summerDiscount.Name());
            summerDiscount.Discount();

            Console.WriteLine(welcomeDiscount.Name());
            welcomeDiscount.Discount();
        }
        else
        {
            Console.WriteLine("Oyuncu doğrulaması başarısız. Oyuncu eklenemedi.");
        }
    }
}
