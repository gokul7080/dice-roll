using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {Random randomgenerator = new Random();
        int roll=0;
        int attempt=0;
        while(roll!=6)
        { 
            roll = randomgenerator.Next(1,7);
           Console.WriteLine("you rolled :" + roll);
           attempt++ ;
        }
        if(attempt<10)
        {
            Console.WriteLine("you have luck");
        }
        if(attempt>10)
        {
            Console.WriteLine("you have no luck .too much attempts. get lost");
        }
        Console.WriteLine("you rolled six in "+ attempt+ " attempts" );
            
        }
    }
}
