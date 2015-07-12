using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _5eCharacterGen
{
   class Program
   {


      static void Main(string[] args)
      {

         // Data Dictionary
         Character dood       = new Character();

         // Get the PC's name
         dood.SetName();

         // Get the PC's race
         dood.SetRace();

         // Get the PC's Class
         dood.SetClass();

         // Get the PC's Background
         dood.SetBackground();

         dood.SetScores();

         // Test it
         dood.Print();
      }
   }
}
