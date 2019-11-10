using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeesProject
{
    public partial class Part2 : Form
    {

        public Part2()
        {
            InitializeComponent();

        }

        List<Bee> AllBees = new List<Bee>();
     

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            Random randomeDamage = new Random();
            foreach (var val in AllBees)
            {
                richTextBox1.AppendText("\n  "+val.Name + " Had Health Value of : " + val.getHealthValue()+"%.");
                var damage = val.Damage(randomeDamage.Next(80));
                richTextBox1.AppendText("  Damage value was: " + damage + ".  New Health Value is: "+ val.getHealthValue() + "%.  Curent Dead status is: "+val.getDead().ToString());
            }
        }

        private void Part2_Load(object sender, EventArgs e)
        {
            if (AllBees.Count == 0)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Worker WorkerBee = new Worker(6, "Red", "Worker_" + i.ToString(), i.ToString());
                    AllBees.Add(WorkerBee);

                    Queen QueenBee = new Queen(6, "Yellow", "Queen_" + i.ToString(), i.ToString());
                    AllBees.Add(QueenBee);

                    Drone DroneBee = new Drone(6, "Black", "Drone_" + i.ToString(), i.ToString());
                    AllBees.Add(DroneBee);
                }
            }

            foreach (var val in AllBees)
            {
                richTextBox1.AppendText("\n  " + val.Name + " Had Health Value of : " + val.getHealthValue() + "%");
            }
        }
    }
}
