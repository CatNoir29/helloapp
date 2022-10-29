using System;
namespace BlackProject
{
    static class Black
    {
        public static void Main()
        {
            Console.WriteLine("Hello, I'm Black! Hi everyone!");
            GreetWhite();
            GreetBlack();
        }
        
        public static void GreetWhite()
        {
            Console.WriteLine("Hi, bro! This is me, your friend White!");
        }

        public static void GreetBlack()
        {
            Console.WriteLine("Hello Black!");
        }
    }
}