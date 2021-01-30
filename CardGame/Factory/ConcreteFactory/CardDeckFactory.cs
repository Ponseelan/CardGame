using CardGame.Factory.AbstractFactory;
using CardGame.Model.AbstractModel;
using CardGame.Model.ConcreteModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Factory.ConcreteFactory
{
    public class CardDeckFactory : AbstractCardDeckFactory
    {
        //Concrete implementation for CardDeck Creation
        public override AbstractCardDeck CreateCardDeck()
        {
            return new CardDeck();
        }
    }
}
