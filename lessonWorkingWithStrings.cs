using System;

public class lessonWorkingWithStrings
{
    static public void Main ()
    {
        string text = "obinna " + "is cool";
        string text2 = "nil";
        Console.WriteLine(text);
        Console.WriteLine(text.Length); //14
        
        //these are methods
        Console.WriteLine(text.ToUpper());//this i3s a method
        Console.WriteLine(text.ToLower());
        Console.WriteLine(text.Contains("obinna"));//true
        
        //string indexing
        Console.WriteLine("\n");
        Console.WriteLine(text[0]);//"o"
        Console.WriteLine(text[1]);//"b"
        Console.WriteLine(text[2]);//"i"
        
        Console.WriteLine("\n");
        Console.WriteLine(text.IndexOf("obinna"));//0
        Console.WriteLine(text.IndexOf("o"));
        
        //grabbing and printing parts of a string 
        Console.WriteLine("\n");
        Console.WriteLine(text.Substring(7)); // "is cool"
        Console.WriteLine(text.Substring(7,2)); //"is"
    }

}
