using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5eCharacterGen
{
   class Character
   {
      private string Name;          // the name of the PC
      private string Race;          // the PC's race        (PH Chapter 2)
      private string Class;         // the PC's class       (PH Chapter 3)
      private string Background;    // the PC's background  (PH Chapter 4)

      public Character()
         // Default constructor, sets all fields to a garbage value
      {
         Name        = "N/A";
         Race        = "N/A";
         Class       = "N/A";
         Background  = "N/A";
      }

      public Character(string name)
         // Constructor that sets just the name, and all other fields to garbage values
      {
         this.Name         = name;
         this.Race         = "N/A";
         this.Class        = "N/A";
         this.Background   = "N/A";
      }

      public Character(string name, string race, string charClass, string background)
         // Constructor that sets all values
      {
         this.Name         = name;
         this.Race         = race;
         this.Class        = charClass;
         this.Background   = background;
      }

      public void Print()
      {
         System.Console.WriteLine("{0} {1} the {2} {3}\n", Background, Name, Race, Class);
      }
   }
}
