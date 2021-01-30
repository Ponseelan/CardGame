using CardGame.Model.AbstractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Factory.AbstractFactory
{
    //Abstract factory Pattern. Provides the interface for the Client to create Memory for the AbstractDeck
    public abstract class AbstractCardDeckFactory
    {
       public abstract AbstractCardDeck CreateCardDeck();
    }
}
