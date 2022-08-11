using System;

public class lessonMoreIfStatemets
{
    static public void Main ()
    {
        Console.WriteLine(GetMax(7,5));

    }
    static int GetMax (int num1, int num2)
    {
        int result;
        if (num1 > num2)
        {
            result = num1;
        }else
        {
            result = num2;
        }
        return result;
    }

}
