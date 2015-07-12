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
      private uint Strength;
      private uint Dexterity;
      private uint Constitution;
      private uint Intelligence;
      private uint Wisdom;
      private uint Charisma;

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

         // roll 4 dice, drop the lowest
         // save the that number to the scores
         // assign the scores to the stats
         for(uint i = 0; i < 6; i++)
         {
            for(uint c = 0; c < 4; c++)
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
      }

      public void Print()
         // Prints the attributes
      {
         Console.WriteLine("Strength:     {0}", Strength);
         Console.WriteLine("Dexterity:    {0}", Dexterity);
         Console.WriteLine("Constitution: {0}", Constitution);
         Console.WriteLine("Intelligence: {0}", Intelligence);
         Console.WriteLine("Wisdom:       {0}", Wisdom);
         Console.WriteLine("Charisma:     {0}", Charisma);
      }
   }
}
