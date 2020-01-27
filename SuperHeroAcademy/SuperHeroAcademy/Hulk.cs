using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroAcademy
{
    class Hulk : Superhero
    {
        //Subklass av Superhero.

        //Konstruktor
        public Hulk()
        {
            //Här defineras superhjältens atribut när en instans av klassen skapas.
            power = "Smash";
            //Man skulle också kunna slumpa ett passande värde för varge variabel.
            str = 10;
            wis = 1;
            agi = 3;
        }

        //Den här metoden overridar UsePower i basklassen Superhero.
        public override string UsePower()
        {
            //Returnar att superhjälten använder sin kraft.
            return (name + " uses " + power + "!");
        }
    }
}
