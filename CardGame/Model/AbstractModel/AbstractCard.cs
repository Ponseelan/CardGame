using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Model.AbstractModel
{
    //Abstract Model for Card
    public abstract class AbstractCard
    {
        public string Name { get; set; }

        public AbstractSuit suit { get; set; }
        public AbstractCard(string name,AbstractSuit suit)
        {
            Name = name;
            this.suit = suit;
        }
    }
}
