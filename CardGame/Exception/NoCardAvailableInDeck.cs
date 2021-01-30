using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Exceptions
{
    class NoCardAvailableInDeckException:Exception
    {
        public override string Message => "No Cards are Available in the deck";
    }
}
