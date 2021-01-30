using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.ExtensionMethod.Integer
{
    //Extension Method for integer, used to get the random number for card shuffling
    public static class IntegerExtensionMethod
    {
        static Random random = new Random();
        public static int GetRandomNumberforCardShuffling(this int num1,int total)
        {
            return random.Next(num1, total);
        }
    }
}
