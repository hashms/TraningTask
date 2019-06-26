using System;

public class MultiConvert
{
    public static void Main(string[] args)
    {
        int num = 0;

        if (args[0] == "10to2" )
        {
            //num = int.Parse(args[1]);
            //num = int.Parse(Convert.ToString(num, 2));
            //Console.WriteLine($"2進数：{num}" );
            Console.WriteLine($"16進数：{Convert.ToString(int.Parse(args[1]), 2)}");
        }
        else if (args[0] == "10to16")
        {
            Console.WriteLine($"16進数：{Convert.ToString(int.Parse(args[1]), 16)}");
        }
    }    
}

