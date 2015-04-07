using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipAMania
{
    class Program
    {
        static Random rng = new Random();
        static int numberOfHeads = 0;
        static int numberOfTails = 0;
        static void Main(string[] args)
        {
        }
        public static string numberOfFlips()
        {
            if (rng.Next(2) == 0)
            {
                numberOfHeads++;
                return "Heads";
            }
            else 
            {
                numberOfTails++;
                return "Tails";
            }
    }
}
