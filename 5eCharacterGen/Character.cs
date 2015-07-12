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
         System.Console.WriteLine("{0} {1} the {2} {3}", Background, Name, Race, Class);
      }

      public void SetName()
      {
         Console.Write("Enter your character's name: ");
         this.Name =  Console.ReadLine();
      }

      public void SetRace()
      {
         // Data Dictionary
         Boolean fValid = false;
         string sInput  = null;
         uint uiInput   = 0;

         // Main loop
         while (!fValid)
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
               if ((uiInput >= 1) && (uiInput <= 10))
               {
                  fValid = true;

                  switch (uiInput)
                  {
                     case 1:
                        this.Race =  "Dragonborn";
                        break;
                     case 2:
                        this.Race = "Dwarf";
                        break;
                     case 3:
                        this.Race = "Elf";
                        break;
                     case 4:
                        this.Race = "Genasi";
                        break;
                     case 5:
                        this.Race = "Gnome";
                        break;
                     case 6:
                        this.Race = "Half-Elf";
                        break;
                     case 7:
                        this.Race = "Half-Orc";
                        break;
                     case 8:
                        this.Race = "Halfling";
                        break;
                     case 9:
                        this.Race = "Human";
                        break;
                     case 10:
                        this.Race = "Tiefling";
                        break;
                     default:
                        fValid = false;
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
      }

      public void SetClass()
      {
         // Data Dictionary
         Boolean fValid = false;
         string sInput  = null;
         uint uiInput   = 0;

         // Main loop
         while (!fValid)
         {
            Console.WriteLine("Choose one of the following classes: ");
            Console.WriteLine("1.  Barbarian");
            Console.WriteLine("2.  Bard");
            Console.WriteLine("3.  Cleric");
            Console.WriteLine("4.  Druid");
            Console.WriteLine("5.  Fighter");
            Console.WriteLine("6.  Monk");
            Console.WriteLine("7.  Paladin");
            Console.WriteLine("8.  Ranger");
            Console.WriteLine("9.  Rogue");
            Console.WriteLine("10. Sorcerer");
            Console.WriteLine("11. Warlock");
            Console.WriteLine("12. Wizard");

            sInput = Console.ReadLine();

            if (UInt32.TryParse(sInput, out uiInput))
            {
               if ((uiInput >= 1) && (uiInput <= 12))
               {
                  fValid = true;
                  switch (uiInput)
                  {
                     case 1:
                        this.Class =  "Barbarian";
                        break;
                     case 2:
                        this.Class = "Bard";
                        break;
                     case 3:
                        this.Class = "Cleric";
                        break;
                     case 4:
                        this.Class = "Druid";
                        break;
                     case 5:
                        this.Class = "Fighter";
                        break;
                     case 6:
                        this.Class = "Monk";
                        break;
                     case 7:
                        this.Class = "Paladin";
                        break;
                     case 8:
                        this.Class = "Ranger";
                        break;
                     case 9:
                        this.Class = "Rogue";
                        break;
                     case 10:
                        this.Class = "Sorcerer";
                        break;
                     case 11:
                        this.Class = "Warlock";
                        break;
                     case 12:
                        this.Class = "Wizard";
                        break;
                     default:
                        fValid = false;
                        break;
                  }
               }
               else
               {
                  Console.WriteLine("Error! Invalid input, please enter a number in the range [1,12]");
               }
            }
            else
            {
               Console.WriteLine("Error! Invalid input, please enter a number in the range [1,12]");
            }
         }
      }

      public void SetBackground()
      {
         // Data Dictionary
         Boolean fValid = false;
         string sInput  = null;
         uint uiInput   = 0;

         // Main loop
         while (!fValid)
         {
            Console.WriteLine("Choose one of the following Backgrounds: ");
            Console.WriteLine("1.  Acolyte");
            Console.WriteLine("2.  Charlatan");
            Console.WriteLine("3.  Criminal");
            Console.WriteLine("4.  Entertainer");
            Console.WriteLine("5.  Folk Hero");
            Console.WriteLine("6.  Guild Artisan");
            Console.WriteLine("7.  Hermit");
            Console.WriteLine("8.  Noble");
            Console.WriteLine("9.  Outlander");
            Console.WriteLine("10. Sage");
            Console.WriteLine("11. Sailor");
            Console.WriteLine("12. Soldier");
            Console.WriteLine("13. Urchin");

            sInput = Console.ReadLine();

            if (UInt32.TryParse(sInput, out uiInput))
            {
               if ((uiInput >= 1) && (uiInput <= 13))
               {
                  fValid = true;
                  switch (uiInput)
                  {
                     case 1:
                        this.Background = "Acolyte";
                        break;
                     case 2:
                        this.Background = "Charlatan";
                        break;
                     case 3:
                        this.Background = "Criminal";
                        break;
                     case 4:
                        this.Background = "Entertainer";
                        break;
                     case 5:
                        this.Background = "Folk Hero";
                        break;
                     case 6:
                        this.Background = "Guild Artisan";
                        break;
                     case 7:
                        this.Background = "Hermit";
                        break;
                     case 8:
                        this.Background = "Noble";
                        break;
                     case 9:
                        this.Background = "Outlander";
                        break;
                     case 10:
                        this.Background = "Sage";
                        break;
                     case 11:
                        this.Background = "Sailor";
                        break;
                     case 12:
                        this.Background = "Soldier";
                        break;
                     case 13:
                        this.Background = "Urchin";
                        break;
                     default:
                        fValid = false;
                        break;
                  }
               }
               else
               {
                  Console.WriteLine("Error! Invalid input, please enter a number in the range [1,13]");
               }
            }
            else
            {
               Console.WriteLine("Error! Invalid input, please enter a number in the range [1,13]");
            }
         }
      }
   }
}
