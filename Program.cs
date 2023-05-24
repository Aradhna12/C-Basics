using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*string inp = Console.ReadLine();
             Console.WriteLine(inp);
             Console.WriteLine("I love C#");
             Console.WriteLine("Hello Java");
             Console.ReadLine();*/


            //int a = 35;
            //float  b = 35.6F;
            //double c = 45.6D;
            //bool isGreat = true;
            //char d = 'c  ';
            //string e = "This is string";
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //Console.WriteLine(d);
            //Console.WriteLine(e);
            //Console.WriteLine(isGreat);
            //Console.ReadLine();

            //int x = 3;
            //double y = x;
            //float sx = Convert.ToInt32((32.4);
            //string s = "Random String";
            //Console.WriteLine(x);
            //Console.WriteLine(y);   
            //Console.ReadLine();

            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();   
            //Console.WriteLine( "Hey Hello" + name);
            //Console.ReadLine(); 

            //Console.WriteLine("How many candies do you have");
            //string can = Console.ReadLine();   
            //Console.WriteLine( "You will  get 4 more candies" + (Convert.ToInt32(can)+ 4));
            //Console.ReadLine(); 

            //int a = Math.Min(35,89);
            //double b = Math.Sqrt(34);
            //Console.WriteLine(a);
            //Console.WriteLine(b);   
            //Console.ReadLine();

            string hello = "TTN is amazing company";
            Console.WriteLine(hello.Length);
            Console.WriteLine(hello.ToLower());
            Console.WriteLine(hello.ToUpper());
            Console.WriteLine(hello + "You are dream");
            Console.WriteLine(string.Concat(hello, "You are dream"));
            Console.ReadLine();

            string name = Console.ReadLine();
            string candies = Console.ReadLine();
            Console.WriteLine($"Your name is {name} . You will get {candies} candies");

            string sharp = "I am learning /n C# sharp";
            Console.WriteLine(sharp[2]);
            Console.WriteLine(sharp.IndexOf("learning"));
            Console.WriteLine(sharp.Substring(5));
            Console.ReadLine();


        }


    }
}
