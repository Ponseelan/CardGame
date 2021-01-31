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
    public class CardSuitFactory : AbstractCardSuitFactory
    {
        //Concrete implementaion for Card Suit
        public override AbstractSuit CreateCardSuit(string name)
        {
            return new CardSuit(name);
        }
    }
}
