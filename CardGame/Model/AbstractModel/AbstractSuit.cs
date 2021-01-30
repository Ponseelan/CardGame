using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Model.AbstractModel
{
    // Abstract Model for Suit
    public abstract class AbstractSuit
    {
        public string Name { get; set; }
        public AbstractSuit(string name)
        {
            Name = name;
        }
    }
}
