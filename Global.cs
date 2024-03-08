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
    public static class Global
    {
        public enum Duty { 
        CRAFTSMAN, 
        FARMER, 
        WARRIOR,
        SAILOR 
        }
        public enum Weapon 
        {
        AXE, 
        NONE,
        SWORD
        }
    }
}