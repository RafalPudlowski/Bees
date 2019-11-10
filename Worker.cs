using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesProject
{
    class Worker : Bee
    {
      
        private float DeadValue = 70;
        private string BeeType = "Worker";

        public Worker(int NumOfLegs, string Colour, string Name, string NickName) : base (NumOfLegs, Colour, Name)
        {
            SetDeadValue(this.DeadValue);
            setBeeType(BeeType);

            Console.WriteLine("Congratulations You just created a Worker Bee");

        }
    }
}
 