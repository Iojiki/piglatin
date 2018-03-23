using System;



public class Program
{
    public static void Main()
    {
        //Creating final list of words
        string pigLatin = String.Empty;

        //User Prompt
        Console.WriteLine("Please enter a line of text");
        string testWord = Console.ReadLine();

        //Turn sentence into individual words


        string[] words = testWord.Split(null);






        //Convert Each word into it's pig latin form
        foreach (string singleWord in words)
        {
            string word = "";
            char temp = singleWord[0];
            if (singleWord != "!")
            {
                word = singleWord + temp + "ay";
            }
            else
            {
                word = singleWord + temp;
            }
            string finalWord = word.Substring(1);
            pigLatin = pigLatin + finalWord + " ";

        }
        Console.WriteLine(pigLatin);
        Console.ReadLine();
    }
}