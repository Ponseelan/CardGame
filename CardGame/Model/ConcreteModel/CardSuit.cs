using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Model.ConcreteModel
{
    //Implementation of  the Abstract model. 
    class CardSuit :AbstractModel.AbstractSuit
    {
        public CardSuit(string name):base(name)
        {

        }
    }
}
