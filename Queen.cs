using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesProject
{
    class Queen : Bee
    {
        private float DeadValue = 20;
        private string BeeType = "Queen";

        public Queen(int NumOfLegs, string Colour, string Name, string NickName) : base(NumOfLegs, Colour, Name)
        {

            SetDeadValue(this.DeadValue);
            setBeeType(BeeType);
            Console.WriteLine("Congratulations You just created a Queen Bee");

        }

    }
}
