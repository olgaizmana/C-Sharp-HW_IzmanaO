using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_2
{
    public static class DogExtended
    {
        public static void DogExtend(this Dog message)
        {
            Console.WriteLine("message");
        }
    }
}
