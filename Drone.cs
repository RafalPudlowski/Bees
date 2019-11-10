using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesProject
{
    class Drone : Bee
    {
        private float DeadValue = 50;
        private string BeeType = "Drone";

        public Drone(int NumOfLegs, string Colour, string Name, string NickName) : base(NumOfLegs, Colour, Name)
        {

            SetDeadValue(this.DeadValue);
            setBeeType(BeeType);
            Console.WriteLine("Congratulations You just created a Drone Bee");
        }

    }
}
