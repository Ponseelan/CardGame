using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame.Logger
{
    public class ConsoleLogger : ILogger
    {
        //Implementaion of the logger to log in COnsole.
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
