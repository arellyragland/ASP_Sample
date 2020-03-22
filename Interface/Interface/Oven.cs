using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Oven
    {
        public Oven()
        {

        }

        public void Bake(IPizza pizza)
        {
            Console.WriteLine("I baked a " + pizza.GetType() + " pizza.");
        }
    }
}
