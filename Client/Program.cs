using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame;
using CardGame.Factory.AbstractFactory;
using CardGame.Factory.ConcreteFactory;
using CardGame.Logger;
using CardGame.Strategies.AbstractStrategies;
using CardGame.Strategies.ConcreteStrategies;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialising the logger
            ILogger consoleLogger = new ConsoleLogger();
            //Create Factory for Card type Suit
            AbstractCardSuitFactory CardSuitFactory = new CardSuitFactory();
            //Create Factory for Card Creation
            AbstractCardFactory CardFactory = new CardFactory();
            //Initiliasing card deck strategy
            ICardDeckInitializer cardDeckInitializer = new CardDeckInitializer(CardSuitFactory, CardFactory);
            //Initializing the Card Shuffler Strategy
            ICardShuffler cardShuffler = new CardShuffler();
            //Initialising the factory which provides object
            AbstractCardDeckFactory cardDeckCreator = new CardDeckFactory();
            var CardDeck = cardDeckCreator.CreateCardDeck();
           
            int option;
            bool toExit = false;
            //For Card game we are injecting the dependencies
            ICardGame game = new CardGame.CardGame(CardDeck, cardShuffler, cardDeckInitializer);
            while (true)
            {
                try
                {
                    //Displaying menu
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Play a Card");
                    Console.WriteLine("2. Shuffle a Deck");
                    Console.WriteLine("3. Restart the game");
                    Console.WriteLine("4. Exit");
                    //Getting the input from the users
                    option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            //Invoking playCards Functions.
                            Console.WriteLine("You Got a Card of   "+game.PlayCards());
                            break;
                        case 2:
                            //invoking shuffleDeck
                            game.shuffletheDeck();
                            Console.WriteLine("Shuffling is Done");
                            break;
                        case 3:
                            //restarting the game
                            game.RestartGame();
                            Console.WriteLine("Gamei is restarted");
                            break;
                        case 4:
                            //exit Scenario
                            toExit = true;
                            break;
                        default:
                            //Corner Cases
                            Console.WriteLine( "Wrong Option!! Taking to Main Menu");
                            break;

                    }
                }
                catch (Exception ex)
                {
                    //Based on the Logger. The System Logs the Messages
                    consoleLogger.Log(ex.Message);
                }
                if (toExit)
                    break;
            }
        }
    }
}
