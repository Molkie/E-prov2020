using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroAcademy
{
    class Superhero
    {
        //Variabler för samtliga variatoner av superhjältar
        public string name = "";
        protected string power;
        //Variabelnamnen har förkortats för underlätta projektet.
        //Strength
        protected int str;
        //Wisdom
        protected int wis;
        //Agility
        protected int agi;

        //Metod som overridas av subklasserna.
        public virtual string UsePower()
        {
            return ("Generic superhero power");
        }
    }
}
