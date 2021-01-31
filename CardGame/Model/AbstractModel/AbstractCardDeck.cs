using CardGame.Strategies.AbstractStrategies;
using CardGame.Strategies.ConcreteStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Model.AbstractModel
{

    //Abstract Model for Card Deck
    public abstract class AbstractCardDeck
    {
        private List<AbstractCard> Cards { get; set; }

        private List<AbstractCard> RemovedCards { get; set; }
        public AbstractCardDeck()
        {
            RemovedCards = new List<AbstractCard>();   
        }

        public virtual void InitializeDeck(ICardDeckInitializer creditCardInitializer)
        {
            Cards = creditCardInitializer.GetNewCards();
        }

        public virtual void ShuffleCards(ICardShuffler cardShuffler)
        {
            Cards= cardShuffler.ShuffleCards(Cards);
        }

        public AbstractCard  GetFirstCard()
        {
            if (Cards==null || Cards.FirstOrDefault() == null)
                throw new Exceptions.NoCardAvailableInDeckException();
            var firstCard = Cards.FirstOrDefault();
            return firstCard;
        }

        //instead of deleting and recreating a card. Maintained a Seperate holder to track the removed Cards
        public void RemoveFirstCard()
        {
            if (Cards == null || Cards.FirstOrDefault() == null)
                throw new Exceptions.NoCardAvailableInDeckException();
            var firstCard= Cards.FirstOrDefault();
            RemovedCards.Add(firstCard);
            Cards.RemoveAt(0);
        }

     

        public virtual void ResetCards()
        {
            Cards.AddRange(RemovedCards);
            RemovedCards.Clear();
        }
        
    }
}
