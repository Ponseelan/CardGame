using CardGame.Factory.AbstractFactory;
using CardGame.Model.AbstractModel;
using CardGame.Strategies.AbstractStrategies;
using System;
using System.Collections.Generic;

namespace CardGame.Strategies.ConcreteStrategies
{

    //Implementation of the Card Deck initializer Strategy
    //In future if any chnages needed. Same Kind of implementation can be done
    public class CardDeckInitializer : ICardDeckInitializer
    {
        List<AbstractCard> cards;
        List<String> typeofCards;
        AbstractCardSuitFactory CardSuitFactory;
        AbstractCardFactory CardFactory;
        //All the dependencies are injected through the Constructor
        public CardDeckInitializer(AbstractCardSuitFactory factory, AbstractCardFactory CardFactory)
        {
            cards = new List<AbstractCard>();
            typeofCards = new List<string>();
            CardSuitFactory = factory;
            this.CardFactory = CardFactory;
        }

        //Setting up all the type of cards Ex:A,K J
        public virtual void InitializetypeOfCards()
        {
            typeofCards.Add("A");
            typeofCards.Add("2");
            typeofCards.Add("3");
            typeofCards.Add("4");
            typeofCards.Add("5");
            typeofCards.Add("6");
            typeofCards.Add("7");
            typeofCards.Add("8");
            typeofCards.Add("9");
            typeofCards.Add("10");
            typeofCards.Add("J");
            typeofCards.Add("Q");
            typeofCards.Add("K");
        }
        //To Create a new set of cards
        public List<AbstractCard> GetNewCards()
        {
            InitializetypeOfCards();
            CreateCardSetForGivenSuitType("Club");
            CreateCardSetForGivenSuitType("Heart");
            CreateCardSetForGivenSuitType("Spades");
            CreateCardSetForGivenSuitType("Diamonds");
            return cards;
        }
       
        public void CreateCardSetForGivenSuitType(string suitType)
        {
            var suit = CardSuitFactory.GetCardSuit(suitType);

            foreach (var cardtype in typeofCards)
            {
               cards.Add(CardFactory.CreateCard(cardtype,suit));
            }
          
        }

        
    }
}
