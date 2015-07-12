using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _5eCharacterGen
{
   // TODO: add a enter your own skills
   // TODO: add racial abilities
   // TODO: add background ailities

   class Program
   {

      static void Main(string[] args)
      {

         // Data Dictionary
         Character dood = new Character();

         // Get the PC's name
         dood.SetName();

         // Get the PC's Class
         dood.SetClass();

         // Roll some stats
         dood.SetScores();

         // Get the PC's race
         dood.SetRace();

         // Get the PC's Background
         dood.SetBackground();

         // Test it
         dood.Print();

         Console.WriteLine("\nPress any key to exit.");
         Console.ReadLine();
      }
   }
}
