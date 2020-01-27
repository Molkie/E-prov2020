using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroAcademy
{
    class IronMan : Superhero
    {
        //Subklass av Superhero.

        //Konstruktor
        public IronMan()
        {
            //Här defineras superhjältens atribut när en instans av klassen skapas.
            power = "Fly";
            //Man skulle också kunna slumpa ett passande värde för varge variabel.
            str = 5;
            wis = 9;
            agi = 4;
        }

        //Den här metoden overridar UsePower i basklassen Superhero.
        public override string UsePower()
        {
            //Returnar att superhjälten använder sin kraft.
            return (name + " man uses " + power + "!");
        }
    }
}
