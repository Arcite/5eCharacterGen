using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _5eCharacterGen
{
   class Character
   {
      private string Name;          // the name of the PC
      private string Race;          // the PC's race           (PH Chapter 2)
      private string Class;         // the PC's class          (PH Chapter 3)
      private string Background;    // the PC's background     (PH Chapter 4)
      private AbilityScore stats;   // the PC's ability scores (PH Chapter 1)
      private uint age;             // PC's age

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
         stats.Print();
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
            Console.WriteLine("\nChoose one of the following races: ");
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
                        fValid = false;

                        while(!fValid)
                        {
                           Console.WriteLine("\nChoose a subrace: ");
                           Console.WriteLine("1. Hill Dwarf");
                           Console.WriteLine("2. Mountain Dwarf");

                           sInput = Console.ReadLine();

                           if (UInt32.TryParse(sInput, out uiInput))
                           {
                              if((uiInput == 1) || (uiInput == 2))
                              {
                                 fValid = true;

                                 if (uiInput == 1)
                                 {
                                    this.Race = "Hill Dwarf";
                                 }
                                 else
                                 {
                                    this.Race = "Mountain Dwarf";
                                 }
                              }
                              else
                              {
                                 Console.WriteLine(
                                    "Error! Invalid input, please enter a number " +
                                    "in the range [1,2]");
                              }
                           }
                           else
                           {
                              Console.WriteLine(
                                 "Error! Invalid input, please enter a number in" +
                                 "the range [1,2]");
                           }
                        }
                        break;
                     case 3:
                        fValid = false;

                        while(!fValid)
                        {
                           Console.WriteLine("\nChoose a subrace: ");
                           Console.WriteLine("1. High Elf");
                           Console.WriteLine("2. Wood Elf");
                           Console.WriteLine("3. Dark Elf (Drow)");

                           sInput = Console.ReadLine();

                           if (UInt32.TryParse(sInput, out uiInput))
                           {
                              if((uiInput >= 1) || (uiInput <= 3))
                              {
                                 fValid = true;

                                 switch (uiInput)
                                 {
                                    case 1:
                                       this.Race = "High Elf";
                                       break;
                                    case 2:
                                       this.Race = "Wood Elf";
                                       break;
                                    case 3:
                                       this.Race = "Dark Elf (Drow)";
                                       break;
                                    default:
                                       this.Race = "ERROR";
                                       break;
                                 }
                              }
                              else
                              {
                                 Console.WriteLine(
                                    "Error! Invalid input, please enter a number " +
                                    "in the range [1,3]");
                              }
                           }
                           else
                           {
                              Console.WriteLine(
                                 "Error! Invalid input, please enter a number in" +
                                 "the range [1,3]");
                           }
                        }
                        break;
                     case 4:
                        fValid = false;

                        while(!fValid)
                        {
                           Console.WriteLine("\nChoose a subrace: ");
                           Console.WriteLine("1. Air Genasi");
                           Console.WriteLine("2. Earth Genasi");
                           Console.WriteLine("3. Fire Genasi");
                           Console.WriteLine("4. Water Genasi");

                           sInput = Console.ReadLine();

                           if (UInt32.TryParse(sInput, out uiInput))
                           {
                              if((uiInput >= 1) || (uiInput <= 4))
                              {
                                 fValid = true;

                                 switch (uiInput)
                                 {
                                    case 1:
                                       this.Race = "Air Genasi";
                                       break;
                                    case 2:
                                       this.Race = "Earth Genasi";
                                       break;
                                    case 3:
                                       this.Race = "Fire Genasi";
                                       break;
                                    case 4:
                                       this.Race = "Water Genasi";
                                       break;
                                    default:
                                       this.Race = "ERROR";
                                       break;
                                 }
                              }
                              else
                              {
                                 Console.WriteLine(
                                    "Error! Invalid input, please enter a number " +
                                    "in the range [1,3]");
                              }
                           }
                           else
                           {
                              Console.WriteLine(
                                 "Error! Invalid input, please enter a number in" +
                                 "the range [1,3]");
                           }
                        }
                        break;
                     case 5:
                        fValid = false;

                        while(!fValid)
                        {
                           Console.WriteLine("\nChoose a subrace: ");
                           Console.WriteLine("1. Forest Gnome");
                           Console.WriteLine("2. Rock Gnome");

                           sInput = Console.ReadLine();

                           if (UInt32.TryParse(sInput, out uiInput))
                           {
                              if((uiInput == 1) || (uiInput == 2))
                              {
                                 fValid = true;

                                 if (uiInput == 1)
                                 {
                                    this.Race = "Forest Gnome";
                                 }
                                 else
                                 {
                                    this.Race = "Rock Gnome";
                                 }
                              }
                              else
                              {
                                 Console.WriteLine(
                                    "Error! Invalid input, please enter a number " +
                                    "in the range [1,2]");
                              }
                           }
                           else
                           {
                              Console.WriteLine(
                                 "Error! Invalid input, please enter a number in" +
                                 "the range [1,2]");
                           }
                        }

                        break;
                     case 6:
                        this.Race = "Half-Elf";
                        break;
                     case 7:
                        this.Race = "Half-Orc";
                        break;
                     case 8:
                        fValid = false;

                        while(!fValid)
                        {
                           Console.WriteLine("\nChoose a subrace: ");
                           Console.WriteLine("1. Lightfoot Halfling");
                           Console.WriteLine("2. Stout Halfling");

                           sInput = Console.ReadLine();

                           if (UInt32.TryParse(sInput, out uiInput))
                           {
                              if((uiInput == 1) || (uiInput == 2))
                              {
                                 fValid = true;

                                 if (uiInput == 1)
                                 {
                                    this.Race = "Lightfoot Gnome";
                                 }
                                 else
                                 {
                                    this.Race = "Stout Gnome";
                                 }
                              }
                              else
                              {
                                 Console.WriteLine(
                                    "Error! Invalid input, please enter a number " +
                                    "in the range [1,2]");
                              }
                           }
                           else
                           {
                              Console.WriteLine(
                                 "Error! Invalid input, please enter a number in" +
                                 "the range [1,2]");
                           }
                        }
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
                  Console.WriteLine(
                     "Error! Invalid input, please enter a number in the range [1,10]");
               }
            }
            else
            {
               Console.WriteLine(
                  "Error! Invalid input, please enter a number in the range [1,10]");
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
            Console.WriteLine("\nChoose one of the following classes: ");
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
            Console.WriteLine("\nChoose one of the following Backgrounds: ");
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

      public void SetScores()
      {
         stats = new AbilityScore();
      }
   }

   class AbilityScore
   {
      // Actual Scores
      private uint Strength;
      private uint Dexterity;
      private uint Constitution;
      private uint Intelligence;
      private uint Wisdom;
      private uint Charisma;

      // Modifiers
      private int strMod;
      private int dexMod;
      private int conMod;
      private int intMod;
      private int wisMod;
      private int chrMod;


      public AbilityScore()
         // randomly rolls 6 numbers, and allows the user to select which stats they go to
      {
         // Data Dictionary
         Random rand    = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
         uint[] dice    = new uint[4];
         uint[] scores  = new uint[6];
         Boolean fValid = false;
         string sInput  = null;
         uint uiInput   = 0;
         Boolean happy  = false;

         while (!happy)
         {
            fValid = false;

            // roll 4 dice, drop the lowest
            // save the that number to the scores
            // assign the scores to the stats
            for (uint i = 0; i < 6; i++)
            {
               for (uint c = 0; c < 4; c++)
               {
                  dice[c] = (uint)rand.Next(1, 7);
               }

               Array.Sort<uint>(dice);

               scores[i] = dice[1] + dice[2] + dice[3];
            }

            Array.Sort<uint>(scores);
            Array.Reverse(scores);

            Console.WriteLine("{0} {1}, {2}, {3}, {4}, {5}",
               scores[0], scores[1], scores[2], scores[3],
               scores[4], scores[5]);

            while(!fValid)
            {
               Console.WriteLine("Keep this roll? (1 for yes, 0 for no)");

               sInput = Console.ReadLine();

               if (UInt32.TryParse(sInput, out uiInput))
               {
                  if (uiInput == 0)
                  {
                     fValid = true;
                     happy = false;
                  }
                  else if (uiInput == 1)
                  {
                     fValid = true;
                     happy = true;
                  }
                  else
                  {
                     fValid = false;
                     Console.WriteLine("Error! Invalid input, please 1 or 0");
                  }
               }
               else
               {
                  fValid = false;
                  Console.WriteLine("Error! Invalid input, please 1 or 0");
               }
            }            
         }

         Strength       = 0;
         Dexterity      = 0;
         Constitution   = 0;
         Intelligence   = 0;
         Wisdom         = 0;
         Charisma       = 0;

         for(uint i = 0; i < 6; i++)
         {
            fValid = false;

            while (!fValid)
            {
               Console.WriteLine("\nPick a stat for {0}:", scores[i]);

               if (Strength == 0)
               {
                  Console.WriteLine("1. Strength ");
               }

               if (Dexterity == 0)
               {
                  Console.WriteLine("2. Dexterity ");
               }

               if (Constitution == 0)
               {
                  Console.WriteLine("3. Constitution ");
               }

               if (Intelligence == 0)
               {
                  Console.WriteLine("4. Intelligence ");
               }

               if (Wisdom == 0)
               {
                  Console.WriteLine("5. Wisdom ");
               }

               if (Charisma == 0)
               {
                  Console.WriteLine("6. Charisma ");
               }

               sInput = Console.ReadLine();

               if (UInt32.TryParse(sInput, out uiInput))
               {
                  if ((uiInput >= 1) && (uiInput <= 6))
                  {
                     switch (uiInput)
                     {
                        case 1:
                           if (Strength != 0)
                           {
                              Console.WriteLine(
                                 "Error! Invalid input, please enter " +
                                 "a number that was printed");
                              fValid = false;
                           }
                           else
                           {
                              Strength = scores[i];
                              fValid = true;
                           }
                           break;
                        case 2:
                           if (Dexterity != 0)
                           {
                              Console.WriteLine(
                                 "Error! Invalid input, please enter " +
                                 "a number that was printed");
                              fValid = false;
                           }
                           else
                           {
                              Dexterity = scores[i];
                              fValid = true;
                           }
                           break;
                        case 3:
                           if (Constitution != 0)
                           {
                              Console.WriteLine(
                                 "Error! Invalid input, please enter " +
                                 "a number that was printed");
                              fValid = false;
                           }
                           else
                           {
                              Constitution = scores[i];
                              fValid = true;
                           }
                           break;
                        case 4:
                           if (Intelligence != 0)
                           {
                              Console.WriteLine(
                                 "Error! Invalid input, please enter " +
                                 "a number that was printed");
                              fValid = false;
                           }
                           else
                           {
                              Intelligence = scores[i];
                              fValid = true;
                           }
                           break;
                        case 5:
                           if (Wisdom != 0)
                           {
                              Console.WriteLine(
                                 "Error! Invalid input, please enter " +
                                 "a number that was printed");
                              fValid = false;
                           }
                           else
                           {
                              Wisdom = scores[i];
                              fValid = true;
                           }
                           break;
                        case 6:
                           if (Charisma != 0)
                           {
                              Console.WriteLine(
                                 "Error! Invalid input, please enter " +
                                 "a number that was printed");
                              fValid = false;
                           }
                           else
                           {
                              Charisma = scores[i];
                              fValid = true;
                           }
                           break;
                     }
                  }
                  else
                  {
                     Console.WriteLine(
                        "Error! Invalid input, please enter a number that was printed");
                  }
               }
               else
               {
                  Console.WriteLine(
                     "Error! Invalid input, please enter a number that was printed");
               }
            }
         }

         SetMods();
      }

      public void SetMods()
      {
         SetStrMod();
         SetDexMod();
         SetConMod();
         SetIntMod();
         SetWisMod();
         SetChrMod();
      }

      private void SetStrMod()
      {
         switch (Strength)
         {
            case 1:
               strMod = -5;
               break;
            case 2:
            case 3:
               strMod = -4;
               break;
            case 4:
            case 5:
               strMod = -3;
               break;
            case 6:
            case 7:
               strMod = -2;
               break;
            case 8:
            case 9:
               strMod = -1;
               break;
            case 10:
            case 11:
               strMod = 0;
               break;
            case 12:
            case 13:
               strMod = 1;
               break;
            case 14:
            case 15:
               strMod = 2;
               break;
            case 16:
            case 17:
               strMod = 3;
               break;
            case 18:
            case 19:
               strMod = 4;
               break;
            case 20:
            case 21:
               strMod = 5;
               break;
            case 22:
            case 23:
               strMod = 6;
               break;
            case 24:
            case 25:
               strMod = 7;
               break;
            case 26:
            case 27:
               strMod = 8;
               break;
            case 28:
            case 29:
               strMod = 9;
               break;
            default:
               strMod = 10;
               break;
         }
      }

      private void SetDexMod()
      {
         switch (Dexterity)
         {
            case 1:
               dexMod = -5;
               break;
            case 2:
            case 3:
               dexMod = -4;
               break;
            case 4:
            case 5:
               dexMod = -3;
               break;
            case 6:
            case 7:
               dexMod = -2;
               break;
            case 8:
            case 9:
               dexMod = -1;
               break;
            case 10:
            case 11:
               dexMod = 0;
               break;
            case 12:
            case 13:
               dexMod = 1;
               break;
            case 14:
            case 15:
               dexMod = 2;
               break;
            case 16:
            case 17:
               dexMod = 3;
               break;
            case 18:
            case 19:
               dexMod = 4;
               break;
            case 20:
            case 21:
               dexMod = 5;
               break;
            case 22:
            case 23:
               dexMod = 6;
               break;
            case 24:
            case 25:
               dexMod = 7;
               break;
            case 26:
            case 27:
               dexMod = 8;
               break;
            case 28:
            case 29:
               dexMod = 9;
               break;
            default:
               dexMod = 10;
               break;
         }
      }

      private void SetConMod()
      {
         switch (Constitution)
         {
            case 1:
               conMod = -5;
               break;
            case 2:
            case 3:
               conMod = -4;
               break;
            case 4:
            case 5:
               conMod = -3;
               break;
            case 6:
            case 7:
               conMod = -2;
               break;
            case 8:
            case 9:
               conMod = -1;
               break;
            case 10:
            case 11:
               conMod = 0;
               break;
            case 12:
            case 13:
               conMod = 1;
               break;
            case 14:
            case 15:
               conMod = 2;
               break;
            case 16:
            case 17:
               conMod = 3;
               break;
            case 18:
            case 19:
               conMod = 4;
               break;
            case 20:
            case 21:
               conMod = 5;
               break;
            case 22:
            case 23:
               conMod = 6;
               break;
            case 24:
            case 25:
               conMod = 7;
               break;
            case 26:
            case 27:
               conMod = 8;
               break;
            case 28:
            case 29:
               conMod = 9;
               break;
            default:
               conMod = 10;
               break;
         }
      }

      private void SetIntMod()
      {
         switch (Intelligence)
         {
            case 1:
               intMod = -5;
               break;
            case 2:
            case 3:
               intMod = -4;
               break;
            case 4:
            case 5:
               intMod = -3;
               break;
            case 6:
            case 7:
               intMod = -2;
               break;
            case 8:
            case 9:
               intMod = -1;
               break;
            case 10:
            case 11:
               intMod = 0;
               break;
            case 12:
            case 13:
               intMod = 1;
               break;
            case 14:
            case 15:
               intMod = 2;
               break;
            case 16:
            case 17:
               intMod = 3;
               break;
            case 18:
            case 19:
               intMod = 4;
               break;
            case 20:
            case 21:
               intMod = 5;
               break;
            case 22:
            case 23:
               intMod = 6;
               break;
            case 24:
            case 25:
               intMod = 7;
               break;
            case 26:
            case 27:
               intMod = 8;
               break;
            case 28:
            case 29:
               intMod = 9;
               break;
            default:
               intMod = 10;
               break;
         }
      }

      private void SetWisMod()
      {
         switch (Wisdom)
         {
            case 1:
               wisMod = -5;
               break;
            case 2:
            case 3:
               wisMod = -4;
               break;
            case 4:
            case 5:
               wisMod = -3;
               break;
            case 6:
            case 7:
               wisMod = -2;
               break;
            case 8:
            case 9:
               wisMod = -1;
               break;
            case 10:
            case 11:
               wisMod = 0;
               break;
            case 12:
            case 13:
               wisMod = 1;
               break;
            case 14:
            case 15:
               wisMod = 2;
               break;
            case 16:
            case 17:
               wisMod = 3;
               break;
            case 18:
            case 19:
               wisMod = 4;
               break;
            case 20:
            case 21:
               wisMod = 5;
               break;
            case 22:
            case 23:
               wisMod = 6;
               break;
            case 24:
            case 25:
               wisMod = 7;
               break;
            case 26:
            case 27:
               wisMod = 8;
               break;
            case 28:
            case 29:
               wisMod = 9;
               break;
            default:
               wisMod = 10;
               break;
         }
      }

      private void SetChrMod()
      {
         switch (Charisma)
         {
            case 1:
               chrMod = -5;
               break;
            case 2:
            case 3:
               chrMod = -4;
               break;
            case 4:
            case 5:
               chrMod = -3;
               break;
            case 6:
            case 7:
               chrMod = -2;
               break;
            case 8:
            case 9:
               chrMod = -1;
               break;
            case 10:
            case 11:
               chrMod = 0;
               break;
            case 12:
            case 13:
               chrMod = 1;
               break;
            case 14:
            case 15:
               chrMod = 2;
               break;
            case 16:
            case 17:
               chrMod = 3;
               break;
            case 18:
            case 19:
               chrMod = 4;
               break;
            case 20:
            case 21:
               chrMod = 5;
               break;
            case 22:
            case 23:
               chrMod = 6;
               break;
            case 24:
            case 25:
               chrMod = 7;
               break;
            case 26:
            case 27:
               chrMod = 8;
               break;
            case 28:
            case 29:
               chrMod = 9;
               break;
            default:
               chrMod = 10;
               break;
         }
      }

      public void Print()
      {
         if (strMod >= 0)
         {
            Console.WriteLine("Strength:\t{0}\t(+{1})", Strength, strMod);
         }
         else
         {
            Console.WriteLine("Strength:\t{0}\t({1})", Strength, strMod);
         }

         if (dexMod >= 0)
         {
            Console.WriteLine("Dexterity:\t{0}\t(+{1})", Dexterity, dexMod);
         }
         else
         {
            Console.WriteLine("Dexterity:\t{0}\t({1})", Dexterity, dexMod);
         }

         if (conMod >= 0)
         {
            Console.WriteLine("Constitution:\t{0}\t(+{1})", Constitution, conMod);
         }
         else
         {
            Console.WriteLine("Constitution:\t{0}\t({1})", Constitution, conMod);
         }

         if (intMod >= 0)
         {
            Console.WriteLine("Intelligence:\t{0}\t(+{1})", Intelligence, intMod);
         }
         else
         {
            Console.WriteLine("Intelligence:\t{0}\t({1})", Intelligence, intMod);
         }

         if (wisMod >= 0)
         {
            Console.WriteLine("Wisdom:\t\t{0}\t(+{1})", Wisdom, wisMod);
         }
         else
         {
            Console.WriteLine("Wisdom:\t\t{0}\t({1})", Wisdom, wisMod);
         }

         if (chrMod >= 0)
         {
            Console.WriteLine("Charisma:\t{0}\t(+{1})", Charisma, chrMod);
         }
         else
         {
            Console.WriteLine("Charisma:\t{0}\t({1})", Charisma, chrMod);
         }
      }

      public void addStrength(uint modifier)
      {
         this.Strength += modifier;
      }

      public void addDexterity(uint modifier)
      {
         this.Dexterity += modifier;
      }

      public void addConstitution(uint modifier)
      {
         this.Constitution += modifier;
      }

      public void addIntelligence(uint modifier)
      {
         this.Intelligence += modifier;
      }

      public void addWisdom(uint modifier)
      {
         this.Wisdom += modifier;
      }

      public void addCharisma(uint modifier)
      {
         this.Charisma += modifier;
      }
   }
}
