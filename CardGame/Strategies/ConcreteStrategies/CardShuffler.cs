using CardGame.ExtensionMethod.Integer;
using CardGame.Model.AbstractModel;
using CardGame.Strategies.AbstractStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Strategies.ConcreteStrategies
{

    //Implementation of the Card Shuffler Strategy
    //In future if any chnages needed. Same Kind of implementation can be done
    public class CardShuffler : ICardShuffler
    {
        //Shuffle Cards
        public List<AbstractCard> ShuffleCards(List<AbstractCard> Cards)
        {
            int totalNumberofCards = Cards.Count();
            if (totalNumberofCards <= 0)
                throw new Exceptions.NoCardAvailableInDeckException();
            for(int i=0;i< totalNumberofCards; i++)
            {
                var firstCardIndex = i;
                var secondCardIndex=i.GetRandomNumberforCardShuffling(totalNumberofCards);
                SwapCards(firstCardIndex,secondCardIndex,Cards);
              
            }

            return Cards;
        }

        //Swapping Two cards
        public void SwapCards(int firstIndex,int secondIndex, List<AbstractCard> Cards)
        {
            var temp = Cards[firstIndex];

            Cards[firstIndex] = Cards[secondIndex];
            Cards[secondIndex] = temp;
        }

        

    }
}
