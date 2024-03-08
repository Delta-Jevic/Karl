/**********************************************************************
*** NAME	    : Jevic Tshilumba                                   ***
*** CLASS	    : Object Oriented Programming                       ***
*** ASSIGNMENT	:  3                                                ***
*** DUE DATE	: 3-08-24                                           ***
*** INSTRUCTOR	: GAMRADT                                           ***
*********************************************************************************************
*** DESCRIPTION : Use Visual Studio Code to create a user-defined Abstract Data Type (ADT) using C# classes named VikingNS and Global along with interface named IView and an appropriate set of C# files as discussed in class                           ***
*********************************************************************************************/
using System;

namespace VikingNS
{
    public abstract class Viking
    {

        public string Name {get; set;}
        public short Health{get; set;}
        public Global.Weapon Weapon{get; set;}

        public bool Shield {get; set;}
        // Constructor to initialize the Viking object with default values
        public Viking(string name = "Olaf", short health = 100, Global.Weapon weapon = Global.Weapon.NONE, bool shield = false)
        {
            this.Name = name;
            this.Health = health;
            this.Weapon = weapon;
            this.Shield = shield;
        }

        
        public Viking(Viking viking)
        {
            Name = viking.Name;
            Health = viking.Health;
            Weapon = viking.Weapon;
            Shield = viking.Shield;
        }

        public override string ToString()
        {
            return($"Name:\t {Name}\nHealth:\t {Health}\nWeapon:\t {Weapon}\nSheild:\t {Shield}\n");
        }

    }
}


