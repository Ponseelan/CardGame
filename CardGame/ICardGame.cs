using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    //Interface for the Game
    public interface ICardGame
    {
        void RestartGame();
        void shuffletheDeck();
        string PlayCards();
    }
}
