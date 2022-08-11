using System;

public class lessonForLoop
{
    static public void Main ()
    {
        int[] nums = {10,5,9,21,20};
        
        for(int i = 1; i <= 5;i++)
        {
            Console.WriteLine(i);
        }
        
        Console.WriteLine("\n");
        
        for(int i = 0; i < nums.Length;i++)
        {
            Console.WriteLine(nums[i]);
        }
    }

}
