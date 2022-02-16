using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Animal:AManager, IBoss
    {
        private string name;
        private bool scream;
        //Abstract
        public override string Delegate()
        {
            return "Hallo";
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public bool Scream
        {
            get { return this.scream; }
            set { this.scream = value; }
        }

        public Animal() { }

        public Animal(string name)
        {
            this.name = name;
        }

        public void Age(int age)
        {
            Console.WriteLine(age);
        }

        public bool Anoying()
        {
            return true;
        }

        
        
    }
}
