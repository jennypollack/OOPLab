using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab
{
    class Program
    {

 
        static void Main(string[] args)
        {
            var test = new SquareRoots.HeronSquareRoot(0.0001);

            Console.WriteLine(test.findRoot(81, 81/2));
            Console.ReadLine();

            var test2 = new SquareRoots.SquareRoot();
            Console.WriteLine(test2.findRoot(81));
            Console.ReadLine();

            for (int i = 0; i < 10000; i++)
            {
                var rand1 = new Random();
                var rand = rand1.Next(0, 100000);
               
                if ((test.findRoot(rand, rand / 2) - test2.findRoot(rand)) > 0.0001)
                {
                    Console.WriteLine(rand);

                }
         
           }


           // var testTranspose = new CaesarCypher(" ABCDEFGHIJKLMNOPQRSTUVWXYZ");
           // testTranspose.setOffset(3);
           // testTranspose.transposeAlphabet();
           // string result = testTranspose.getTranspose();
           //// string expected = "DEFGHIJKLMNOPQRSTUVWXYZ ABC";
           // Console.ReadLine();





        }
    }
}
