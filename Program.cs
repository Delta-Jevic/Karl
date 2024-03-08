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
    using static Global; 

    public class Program
    {
        static void Main(string[] args)
        {
            // Create two Karl objects with different parameters
            Karl firstPerson = new Karl(); // Default constructor (Duty: FARMER)
            Karl secondPerson = new Karl("Vidar", 500, Global.Weapon.SWORD, true, Global.Duty.WARRIOR);

            // Create copy objects of the Karl instances
            Karl firstPersonCopy = new Karl(firstPerson); // Copy constructor
            Karl secondPersonCopy = new Karl(secondPerson); // Copy constructor

            // Print details of each Karl object and its copy
            Console.WriteLine("Printing First Person\n");
            Console.WriteLine(firstPerson.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Printing Second Person\n");
            Console.WriteLine(secondPerson.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Printing First Person Copy\n");
            Console.WriteLine(firstPersonCopy.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Printing Second Person Copy\n");
            Console.WriteLine(secondPersonCopy.ToString());
            Console.WriteLine("\n");
        }
    }
}
