/**********************************************************************
*** NAME	    : Jevic Tshilumba                                   ***
*** CLASS	    : Object Oriented Programming                       ***
*** ASSIGNMENT	:  3                                                ***
*** DUE DATE	: 03-08-24                                          ***
*** INSTRUCTOR	: GAMRADT                                           ***
*********************************************************************************************
*** DESCRIPTION : Use Visual Studio Code to create a user-defined Abstract Data Type (ADT) using C# classes named VikingNS and Global along with interface named IView and an appropriate set of C# files as discussed in class                           ***
*********************************************************************************************/
using System;

namespace VikingNS
{
    public class Karl : Viking // Assuming Viking class exists
    {
        public Global.Duty Duty { get; set; }

        public Karl() : base() // Calls the base class constructor 
        {
            Duty = Global.Duty.FARMER; // Default duty for a Karl
        }

        
        public Karl(string Name, short Health, Global.Weapon Weapon, bool Shield, Global.Duty Duty = Global.Duty.FARMER)
            : base(Name, Health, Weapon, Shield) // Calls the base class constructor with arguments
        {
            this.Duty = Duty; // Set the Karl's specific duty
        }

        public Karl(Karl other) : base(other) // Copy constructor for inheritance
        {
            this.Duty = other.Duty; // Copy the duty from another Karl object
        }

        public override string ToString()
        {
            return base.ToString() + $"Duty:\t{Duty}"; // Combine base class string representation with duty information
        }
    }
}
