using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Listing : ITextComponent
    {
        private string content;

        public Listing(string content)
        {
            this.content = content;
        }

        public void Display()
        {
            Console.WriteLine("Listing: " + content);
        }
    }
}
