using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    abstract class Animal
    {
        string name;
        string favouriteFood;

        public Animal(string name, string food)
        {
            this.name = name;
            this.favouriteFood = food;
        }

        public string Name
        {
            get { return name; }
            private set { Name = value; }
        }

        public string FavouriteFood
        {
            get { return favouriteFood; }
            private set { favouriteFood = value; }
        }


        public virtual string ExplainSelf()
        {
            return $"Hello I am  { Name } my favorite food is { FavouriteFood }" ;
        }
    }
}
