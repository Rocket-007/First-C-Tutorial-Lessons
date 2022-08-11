using System;

public class lessonWhileLoo
{
    static public void Main ()
    {
        int index = 1;
        
        //while loop
        while(index < 5)
        {
            Console.WriteLine("Hello");
            index++;
        }
        
        Console.WriteLine("\n");
        
        //do while loop
        do
        {
            Console.WriteLine("Hello");
            index--;
        }while(index > 1);
    }
}
