using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Punctuation : ITextComponent
    {
        private char symbol;

        public Punctuation(char symbol)
        {
            this.symbol = symbol;
        }

        public void Display()
        {
            Console.Write(symbol);
        }
    }
}
