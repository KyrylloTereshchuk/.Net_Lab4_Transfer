using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class Sentence : ITextComponent
    {
        private readonly List<ITextComponent> components = new List<ITextComponent>();

        public void AddComponent(ITextComponent component)
        {
            if (component is Paragraph)
            {
                throw new ArgumentException("Paragraph objects cannot be added to Sentence.");
            }
            components.Add(component);
        }

        public void Display()
        {
            foreach (var component in components)
            {
                component.Display();
            }
        }
    }
}
