using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesProject
{
    public class Bee
    {
        private float Health;
        private bool Dead;
        private float DeadValue;
        private string BeeType;
        public int NumOfLegs;
        public string Colour;
        public string Name;

        public Bee()
        {
            this.Health = 100;
            this.Dead = false;
        }

        public Bee(int NumOfLegs, string Colour, string Name)
        {
            this.NumOfLegs = NumOfLegs;
            this.Colour = Colour;
            this.Name = Name;
            this.Health = 100; //this will make sure thet Health is alway initialised at 100%
            this.Dead = false;

        }

        //public method to be used in derived classes to set up private individual Dead Value for each bee type. 
        public void SetDeadValue(float value)
        {
            this.DeadValue = value;
        }

        //method to access the pivate value of health
        public float getHealthValue()
        {
            return this.Health;
        }

        //private method used only withi damage method to set health value after damage value deduction
        private void setHealthValue(float newHealthVal)
        {
            this.Health = newHealthVal;
        }

        public string getDead()
        {
            string Status;
            if (this.Dead)
            {
                Status = " This Bee is Dead";
            }
            else
            {
                Status = "This Bee is Alive";
            }
            return Status;
        }
        
        //private method used within damage method to set bool Dead. It's private to unable manual alter of the value 
        private void setDead(bool DeadStatus)
        {
            this.Dead = DeadStatus;
        }

        public void setBeeType(string type)
        {
            this.BeeType = type;
        }

        public string getBeeType()
        {
            string type = this.BeeType;
            return type;
        }

        public int Damage(int DamageValue)
        {
            //calculating new health value
            float newHealthVal = getHealthValue() - DamageValue;

            //if current Health is already less than DeadValue then nothing change because animal is dead already
            if (getHealthValue() < DeadValue)
            {
                Console.Write(Name + "This Bee is already Dead therefore no more Health deductions will be made. \nHealth Value for this Bee will remain: " + getHealthValue().ToString() + "\n");
                getHealthValue();
            }
            else //if is still alive
            {
                //but new calculated health value is going to be less then the dead value then set bool Dead to true and set new health value for the last time. 
                if (newHealthVal < DeadValue)
                {
                    setDead(true);
                    setHealthValue(newHealthVal);
                }
                else //if is still alive and new calculated health value is greater than the dead value, then just set new health value .
                {
                    setHealthValue(newHealthVal);

                }
            }
            return DamageValue;
        }


        //overload of above Method to enable posibility of Unit Testing
        public float Damage(int DamageValue, float currentValue, float deadValue)
        {
            float newHealthVal = currentValue - DamageValue;
            float damage = DamageValue;
            if (currentValue < deadValue)
            {
                Console.Write(Name + "This Bee is already Dead therefore no more Health deductions will be made. \nHealth Value for this Bee will remain: " + getHealthValue().ToString() + "\n");
                return currentValue;
            }
            else
            {
                if (newHealthVal < deadValue)
                {
                    setDead(true);
                    currentValue=newHealthVal;
                    
                }
                else
                {
                    currentValue = newHealthVal;
                    return currentValue;
                }
            }
            return damage;

        }
    }
}
