using System;

public class lessonReturnStatement
{
    static public void Main ()
    {
        Console.WriteLine(Cube(5));//125
    }
    
    static int Cube (int num)
    {
        int result = num*num*num;
        return result;
    }
}