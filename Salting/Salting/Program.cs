using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Salting
{
    class Program
    {
        static void Main(string[] args)
        {
            // string --> hash -- algo --> output
            // salt -- 1 of the hashing algos used
            // Generates a 128 bit salt
            // random sequence of non zero values 
            // uses random data to hash --> gain unique output

            // diff --> encryption / hashing / salting
            // Encryption 
            //-- Scrambles data / only a key can unlock it
            //-- intention is always de ryption as a point 
            // uses a CIPHER -- 2 way function 

            //  Hashing -- scrambling --> using an algo to map data -- to a 
            // fixed lenght 
            Console.WriteLine("Salting example >>>>");

            //input
            Console.WriteLine("Enter a string to hash >>>>");
            string entry = Console.ReadLine();  

            byte [] salt = new byte[128/8]; //to bites
            
            //algo
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }

            Console.WriteLine($"Salt:  { Convert.ToBase64String(salt)}");

            Console.ReadLine();
        }
    }
}
