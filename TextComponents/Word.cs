using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Word : ITextComponent
    {
        private string text;

        public Word(string text)
        {
            this.text = text;
        }

        public void Display()
        {
            Console.Write(" " + text);
        }
    }
}
