using System;
using System.Collections.Generic;
using System.Text;

namespace _1P6622_DamienPelaez
{
    class Feux
    {
        private int id;
        private string color;
        private bool on = false;

        public Feux(int id, string color)
        {
            this.color = color;
            this.id = id;
        }

        public void setColor(string color)
        {
            this.color = color;

        }

        public string getColor()
        {
            return this.color;
        }

        public int getId()
        {
            return this.id;
        }

        public void clignoter()
        {
            this.on = !this.on;
            string status = "";
            if(this.on)
            {
                status = "allumé";
            }
            else
            {
                status = "éteint";
            }
            Console.WriteLine($"Le feux {this.id} est {status}");
        }

        public override string ToString()
        {
            return $"Le feux de signalisation {this.id} est {this.color}";
        }
    }
}
