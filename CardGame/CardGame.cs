using CardGame.Model.AbstractModel;
using CardGame.Model.ConcreteModel;
using CardGame.Strategies.AbstractStrategies;
using CardGame.Strategies.ConcreteStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    //Card Game Class which drives the functionlaity
    public class CardGame :ICardGame
    {
        AbstractCardDeck cardDeck;
        ICardShuffler cardShuffler;
        ICardDeckInitializer cardDeckInitilizer;
        //Injecting all the dependencies via Constructor. Hence it is loosely Coupled
        public CardGame(AbstractCardDeck cardDeck,ICardShuffler cardShuffler, ICardDeckInitializer cardDeckInitilizer)
        {
            this.cardDeck = cardDeck;
            this.cardShuffler = cardShuffler;
            this.cardDeckInitilizer = cardDeckInitilizer;
            Init();
        }
        //Filling the Deck initially
        private void Init()
        {
            cardDeck.InitializeDeck(cardDeckInitilizer);
            shuffletheDeck();
        }

        //resetting the cards
       public void RestartGame()
        {
            cardDeck.ResetCards();
        }
        //Suhffling the cards
        public void shuffletheDeck()
        {
            cardDeck.ShuffleCards(cardShuffler);
        }
        //Playing the Game
        public string PlayCards()
        {
            var firstCard= cardDeck.GetFirstCard();
            cardDeck.RemoveFirstCard();
            return firstCard.Name+" "+firstCard.suit.Name;
        }
    }
}
