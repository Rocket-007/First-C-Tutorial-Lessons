using System;

public class lessonIfStatement
{
    static public void Main ()
    {
        if (true)
        {
            Console.WriteLine(1);
        }else if(true)
        {
            Console.WriteLine(2);
        }else
        {
            Console.WriteLine(3);
        }
        
        
        if (true || false)
        {
            Console.WriteLine(11);
        }else
        {
            Console.WriteLine(22);
        }
        
        
        if (false && true)
        {
            Console.WriteLine(111);
        }else
        {
            Console.WriteLine(222);
        }

    }

}
