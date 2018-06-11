using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS479_Project3
{
    class Program
    {
        private static readonly Neopets _pets = new Neopets();
        static void Main(string[] args)
        {
            Run();
        }
        static void Run() {
            EvalAvailability();
            EvalBio();
            EvalPhysical();
            EvalPersonality();
        }
        static void EvalAvailability() { }
        static void EvalBio() { }
        static void EvalPhysical() { }
        static void EvalPersonality() { }
    }
}
