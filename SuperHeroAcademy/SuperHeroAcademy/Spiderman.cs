using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroAcademy
{
    class Spiderman : Superhero
    {
        //Subklass av Superhero.

        //Konstruktor
        public Spiderman()
        {
            //Här defineras superhjältens atribut när en instans av klassen skapas.
            power = "Webb sling";
            //Man skulle också kunna slumpa ett passande värde för varje variabel.
            str = 7;
            wis = 5;
            agi = 9;
        }

        //Den här metoden overridar UsePower i basklassen Superhero.
        public override string UsePower()
        {
            //Returnar att superhjälten använder sin kraft.
            return (name + " uses " + power + "!");
        }
    }
}
