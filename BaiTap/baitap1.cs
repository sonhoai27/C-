using System;

namespace QuickSharp
{
    public class Program
    {
        private static void Main()
        {
            int h = 6;
            for(int i = 1; i <= h; i++){
                for(int j = 1 ; j <= (2 * h - 1); j++){
                    if((j >= h - i + 1) && (j <= h + i - 1)){
                        Console.Write("*");
                        }else{
                            Console.Write(" ");
                            }
                    }
                    
                    Console.WriteLine("\n");
                }        
        }
    }
}