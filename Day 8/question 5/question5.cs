using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary11
{
    public class Animal
    {
        public virtual string speak()
        {
            return "I don't know how to speak";
        }
    }
    public class Dog : Animal
    {
        public override string speak()
        {
            return "Bhow Bhow";
        }
    }
    public class Cat : Animal
    {
        public override string speak()
        {
            return "Mewo Mewo";
        }
    }
    public class Donkey : Animal
    {

    }
}
