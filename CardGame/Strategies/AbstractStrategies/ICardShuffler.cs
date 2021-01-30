using CardGame.Model.AbstractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Strategies.AbstractStrategies
{
    //Strategy interface for Card Shuffler
    public interface ICardShuffler
    {
        List<AbstractCard> ShuffleCards(List<AbstractCard> cards);
    }
}
