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
         string sInput  = null;
         uint uiInput   = 0;
         Boolean fValid = false;

         string sName         = null;
         string sRace         = null;
         string sClass        = null;
         string sBackground   = null;

         // TODO: make this a function
         // Get the PC's name
         Console.Write("Enter your character's name: ");
         sName = Console.ReadLine();

         // TODO: make this a function
         // Get the PC's race
         while(!fValid)
         {
            Console.WriteLine("Choose one of the following races: ");
            Console.WriteLine("1.  Dragonborn");
            Console.WriteLine("2.  Dwarf");
            Console.WriteLine("3.  Elf");
            Console.WriteLine("4.  Genasi");
            Console.WriteLine("5.  Gnome");
            Console.WriteLine("6.  Half-Elf");
            Console.WriteLine("7.  Half-Orc");
            Console.WriteLine("8.  Halfling");
            Console.WriteLine("9.  Human");
            Console.WriteLine("10. Tiefling");

            sInput = Console.ReadLine();

            if (UInt32.TryParse(sInput, out uiInput))
            {
               if((uiInput >= 1) && (uiInput <= 10))
               {
                  fValid = true;
                  switch(uiInput)
                  {
                     case 1:
                        sRace = "Dragonborn";
                        break;
                     case 2:
                        sRace = "Dwarf";
                        break;
                     case 3:
                        sRace = "Elf";
                        break;
                     case 4:
                        sRace = "Genasi";
                        break;
                     case 5:
                        sRace = "Gnome";
                        break;
                     case 6:
                        sRace = "Half-Elf";
                        break;
                     case 7:
                        sRace = "Half-Orc";
                        break;
                     case 8:
                        sRace = "Halfling";
                        break;
                     case 9:
                        sRace = "Human";
                        break;
                     case 10:
                        sRace = "Tiefling";
                        break;
                  }
               }
               else
               {
                  Console.WriteLine("Error! Invalid input, please enter a number in the range [1,10]");
               }
            }
            else
            {
               Console.WriteLine("Error! Invalid input, please enter a number in the range [1,10]");
            }
         }

         // TODO: make this a function
         // Get the PC's Class

         // TODO: make this a function
         // Get the PC's Background
      }
   }
}
