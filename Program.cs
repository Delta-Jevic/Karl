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
namespace VikingNS;
using static Global; 

    public class Program
    {
        static void Main(string[] args)
        {
           
            // Create a new instance of the Karl class with default values
            Karl firstPerson = new();
            Karl secondPerson = new("Vidar", 50, Global.Weapon.SWORD, true, Global.Duty.WARRIOR);


            // Create a copy of the firstPerson using a copy constructor
            Karl firstPersonCopy = new(firstPerson);
            Karl secondPersonCopy = new(secondPerson);

            // Print information for the original and copied instances
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
        }
    }

