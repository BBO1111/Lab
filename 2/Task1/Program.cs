using System;

namespace Task1
{
    class program
    {
        static void Main()
        {
            Word w1 = new Word("Доброго");
            Word w2 = new Word("вечора");
            Word w3 = new Word("ми");
            Word w4 = new Word("з");
            Word w5 = new Word("України");

            Sentence s1 = new Sentence();
            s1.CreateSentence(w1);
            s1.CreateSentence(w2);
            s1.CreateSentence(w3);
            s1.PrintS();
            Console.WriteLine();
            
            Sentence s2 = new Sentence();
            s2.CreateSentence(w4);
            s2.CreateSentence(w5);
            s2.PrintS();
            Console.WriteLine();

            Text text = new Text();
            text.CreateText(s1.sentences);
            text.CreateText(s2.sentences);
            text.ShowText();
            Console.WriteLine();
            text.AddText("Ми похрестили ми і відспіваємо");
            text.ShowText();
            Console.WriteLine();
            text.HeaderOfText("Москалів на ножі");
            Console.WriteLine();




        }
    }
}
