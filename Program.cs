using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Exercise_7_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Hazel";
            char dogNickname = 'N';
            decimal dogAge = 1.5m;
            int dogWeight = 37;
            double treat = +3 - +1;
            bool isDog = true;

            Console.WriteLine($"My dog's name is {dogName} her nickname is {dogNickname}, she is {dogAge} years old. She weighs {dogWeight} pounds. She gets {treat} treats at night. Is hazel a dog? {isDog}");
        }
    }
}
