using System;

public class lesson2dArray
{
    static public void Main ()
    { 
        int[,] Grid= 
        {{1,2},
        {3,4},
        {5,6}};
        Console.WriteLine(Grid[0,0]);//1
        Console.WriteLine(Grid[2,1]);//6
    }

}
