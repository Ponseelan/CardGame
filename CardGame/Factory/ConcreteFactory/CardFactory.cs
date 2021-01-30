using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardGame.Model.AbstractModel;
using CardGame.Model.ConcreteModel;

namespace CardGame.Factory.ConcreteFactory
{
    public class CardFactory : AbstractFactory.AbstractCardFactory
    {
        //Concrete Implementaion for Card
        public override AbstractCard CreateCard(string name, AbstractSuit suit)
        {
            return new Card(name,suit);
        }
    }
}
