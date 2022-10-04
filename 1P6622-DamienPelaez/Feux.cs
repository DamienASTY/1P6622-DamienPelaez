using System;
using System.Collections.Generic;
using System.Text;

namespace _1P6622_DamienPelaez
{
    class Feux
    {
        private string id;
        private string color;
        private bool on = false;

        public Feux(string id, int colorId)
        {
            this.id = id;
            switch(colorId)
            {
                case 1:
                    this.color = "Rouge";
                    break;
                case 2:
                    this.color = "Vert";
                    break;
                case 3:
                    this.color = "Orange";
                    break;
            }

        }

        public void setColor(int colorId)
        {
            switch (colorId)
            {
                case 1:
                    this.color = "Rouge";
                    break;
                case 2:
                    this.color = "Vert";
                    break;
                case 3:
                    this.color = "Orange";
                    break;
            }
        }

        public string getColor()
        {
            return this.color;
        }

        public string getId()
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
