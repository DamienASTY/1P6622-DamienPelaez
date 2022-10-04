using System;

namespace _1P6622_DamienPelaez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Etats des feux");
            Feux feu = new Feux(id: 1001, color: "Rouge");
            Console.WriteLine(feu);
            Feux feu2 = new Feux(id: 007, "Vert");
            Console.WriteLine(feu2);
            Console.WriteLine("Changement d'états");
            feu.setColor(color: "Orange");
            Console.WriteLine(feu);
            feu.setColor(color: "Vert");
            Console.WriteLine(feu);
            feu.setColor(color: "Rouge");
            Console.WriteLine(feu);
            feu.setColor(color: "Orange");
            Console.WriteLine(feu);
            feu.setColor(color: "Vert");
            Console.WriteLine(feu);
            Console.WriteLine("Feu Clignotant");
            Random rand = new Random();
            for(int i = 0; i < 5; i++)
            {
                feu2.clignoter();
            }
        }
    }
}
