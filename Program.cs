using System;
using System.Collections.Generic;

namespace Lab4
{


    class Program
    {
        static void Main(string[] args)
        {

            var paragraph1 = new Paragraph();
            var sentence1 = new Sentence();
            sentence1.AddComponent(new Word("Це"));
            sentence1.AddComponent(new Word("приклад"));
            sentence1.AddComponent(new Punctuation('?'));
            paragraph1.AddComponent(sentence1);

            var sentence2 = new Sentence();
            sentence2.AddComponent(new Word("Друге"));
            sentence2.AddComponent(new Word("речення"));
            sentence2.AddComponent(new Punctuation('!'));
            paragraph1.AddComponent(sentence2);

            var paragraph2 = new Paragraph();
            var sentence3 = new Sentence();
            sentence3.AddComponent(new Word("Новий"));
            sentence3.AddComponent(new Word("абзац"));
            sentence3.AddComponent(new Punctuation('!'));
            paragraph2.AddComponent(sentence3);

         
            var header = new Header("Заголовок тексту");

      
            var listing = new Listing("for (int i = 0; i < 10; i++) { Console.WriteLine(i); }");

     
            paragraph1.Display();
            paragraph2.Display();
            header.Display();
            listing.Display();
        }
    }

}

