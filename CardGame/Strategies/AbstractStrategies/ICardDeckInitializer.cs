using CardGame.Model.AbstractModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Strategies.AbstractStrategies
{
    //implemented the Strategy Pattern. 
    //IMplementation for this interface will be injected through Client code.
    public interface ICardDeckInitializer
    {
         List<AbstractCard> GetNewCards();
       
    }
}
