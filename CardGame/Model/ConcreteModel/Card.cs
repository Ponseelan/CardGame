using CardGame.Model.AbstractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Model.ConcreteModel
{
    //Implementation of  the Abstract model. 
    //Any new Type of card can be introduced by Implementing the same Abstract Card
    class Card:AbstractModel.AbstractCard
    {
        public Card(string name,AbstractSuit suit):base(name,suit)
        {

        }
    }
}
