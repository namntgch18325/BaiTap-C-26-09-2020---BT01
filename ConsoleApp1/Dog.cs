using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Dog : Animal
    {
        public Dog(string name,string favoritefood): base(name,favoritefood)
        {
            Console.WriteLine(this.ExplainSelf());
        }
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "BRAK";
        }
    }
}
