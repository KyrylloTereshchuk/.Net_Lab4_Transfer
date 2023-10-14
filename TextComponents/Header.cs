using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Header : ITextComponent
    {
        private string text;

        public Header(string text)
        {
            this.text = text;
        }

        public void Display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n" + text + "\n");
            Console.ResetColor();
        }
    }
}
