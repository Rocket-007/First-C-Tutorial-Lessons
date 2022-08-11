using System;

public class lessonExceptionHandling
{
    static public void Main ()
    {
        try
        {
            int a = 1/0;
            Console.WriteLine(a);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine("erroor");
        }
    }

}
