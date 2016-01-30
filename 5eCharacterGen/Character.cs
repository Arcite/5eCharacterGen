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
      private string Race;          // the PC's race           (PH Chapter 2)
      private string Class;         // the PC's class          (PH Chapter 3)
      private string Background;    // the PC's background     (PH Chapter 4)
      private AbilityScore stats;   // the PC's ability scores (PH Chapter 1)
      private uint age;             // PC's age
      private uint speed;           // PC's speed
      private string abilities;     // PC's abilities
      private string proficiencies; // PC's proficiencies
      private string languages;     // PC's languages
      private string equipment;     // PC's equipment          (PH Chapter 5)
      private uint health;          // PC's health

      public Character()
         // Default constructor, sets all fields to a garbage value
      {
         this.Name            = "";
         this.Race            = "";
         this.Class           = "";
         this.Background      = "";
         this.age             = 0;           
         this.speed           = 30;
         this.abilities       = "";
         this.proficiencies   = "";
         this.languages       = "";
         this.equipment       = "";
         this.health          = 0;
      }

      public Character(string name)
         // Constructor that sets just the name, and all other fields to garbage values
      {
         this.Name            = name;
         this.Race            = "";
         this.Class           = "";
         this.Background      = "";
         this.age             = 0;           
         this.speed           = 30;
         this.abilities       = "";
         this.proficiencies   = "";
         this.languages       = "";
         this.equipment       = "";
         this.health          = 0;
      }

      public Character(string name, string race, string charClass, string background, uint age)
         // Constructor that sets all values
      {
         this.Name            = name;
         this.Race            = race;
         this.Class           = charClass;
         this.Background      = background;
         this.age             = age;
         this.speed           = 30;
         this.abilities       = "";
         this.proficiencies   = "";
         this.languages       = "";
         this.equipment       = "";
         this.health          = 0;
      }

      public void Print()
      {
         Console.Out.WriteLine("\n{0} {1} the {2} {3}", Background, Name, Race, Class);
         stats.Print();
         Console.Out.WriteLine("\nHealth: {0}", health);
         Console.Out.WriteLine("Speed: {0}", speed);
         Console.Out.WriteLine("\nAbilities:\n{0}", abilities);
         Console.Out.WriteLine("Proficiencies:\n{0}", proficiencies);
         Console.Out.WriteLine("Languages:\n{0}", languages);
         Console.Out.WriteLine("Equipment:\n{0}", equipment);
      }

      public void SetName()
      {
         Console.Write("Enter your character's name: ");
         this.Name =  Console.ReadLine();
      }

      public void SetAge()
      {
         // TODO: put this in SetRace and make the bounds based on the Race
         this.age = getValidUINT("Enter your character's age: (1-1500 depending on race)", 1, 1500);
      }

      public void SetRace()
      {
         // Data Dictionary
         uint uiInput = 0;

         uiInput = getValidUINT(
            "\nChoose one of the following races: \n" +
            "1.  Dragonborn\n"                        +
            "2.  Dwarf\n"                             +
            "3.  Elf\n"                               +
            "4.  Genasi\n"                            +
            "5.  Gnome\n"                             +
            "6.  Half-Elf\n"                          +
            "7.  Half-Orc\n"                          +
            "8.  Halfling\n"                          +
            "9.  Human\n"                             +
            "10. Tiefling\n"                          +
            "11. Aarakocra\n"                         +
            "12. Goliath\n", 1, 12);

         switch (uiInput)
         {
            case 1:
               this.Race = "Dragonborn";
               break;
            case 2:
               uiInput = getValidUINT(
                  "\nChoose a subrace: \n"   +
                  "1. Hill Dwarf\n"          +
                  "2. Mountain Dwarf\n"      +
                  "3. Duergar\n", 1, 3);
               if(uiInput == 1)
               {
                  this.Race = "Hill Dwarf";
               }
               else if(uiInput == 2)
               {
                  this.Race = "Mountain Dwarf";
               }
               else
               {
                  this.Race = "Duergar";
               }
               break;
            case 3:
               uiInput = getValidUINT(
                  "\nChoose a subrace: \n"   +
                  "1. High Elf\n"            +
                  "2. Wood Elf\n"            +
                  "3. Dark Elf (Drow)", 1, 3);

               if(uiInput == 1)
               {
                  this.Race = "High Elf";
               }
               else if(uiInput == 2)
               {
                  this.Race = "Wood Elf";
               }
               else
               {
                  this.Race = "Dark Elf (Drow)";
               }
               break;
            case 4:
               uiInput = getValidUINT("\nChoose a subrace: \n" +
                  "1. Air Genasi\n"                            +
                  "2. Earth Genasi\n"                          +
                  "3. Fire Genasi\n"                           +
                  "4. Water Genasi", 1, 4);
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
               break;
            case 5:
               uiInput = getValidUINT("\nChoose a subrace:\n"  +
                  "1. Forest Gnome\n"                          +
                  "2. Rock Gnome\n"                            +
                  "3. Deep Gnome (Svirfneblin)\n", 1, 3);

               if (uiInput == 1)
               {
                  this.Race = "Forest Gnome";
               }
               else if (uiInput == 2)
               {
                  this.Race = "Rock Gnome";
               }
               else
               {
                  this.Race = "Deep Gnome";
               }
               break;
            case 6:
               this.Race = "Half-Elf";
               break;
            case 7:
               this.Race = "Half-Orc";
               break;
            case 8:
               uiInput = getValidUINT("\nChoose a subrace:\n"  +
                  "1. Lightfoot Halfling\n"                    +
                  "2. Stout Halfling\n", 1, 2);
               if (uiInput == 1)
               {
                  this.Race = "Lightfoot Halfling";
               }
               else
               {
                  this.Race = "Stout Halfling";
               }
               break;
            case 9:
               this.Race = "Human";
               break;
            case 10:
               this.Race = "Tiefling";
               break;
            case 11:
               this.Race = "Aarakocra";
               break;
            case 12:
               this.Race = "Goliath";
               break;
            default:
               break;
         }
      }

      public void SetClass()
      {
         // Data Dictionary
         uint uiInput   = 0;

         uiInput = getValidUINT(
            "\nChoose one of the following classes:\n" +
            "1.  Barbarian\n" +
            "2.  Bard\n" +
            "3.  Cleric\n" +
            "4.  Druid\n" +
            "5.  Fighter\n" +
            "6.  Monk\n" +
            "7.  Paladin\n" +
            "8.  Ranger\n" +
            "9.  Rogue\n" +
            "10. Sorcerer\n" +
            "11. Warlock\n" +
            "12. Wizard", 1, 12);

         switch (uiInput)
         {
            case 1:
               this.Class = "Barbarian";
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
               this.Class = "ERROR";
               break;
         }
      }

      public void SetBackground()
      {
         // Data Dictionary
         uint uiInput   = 0;

         uiInput = getValidUINT(
            "\nChoose one of the following Backgrounds:\n"   +
            "1.  Acolyte\n"                                 +
            "2.  Charlatan\n"                               +
            "3.  Criminal\n"                                +
            "4.  Entertainer\n"                             +
            "5.  Folk Hero\n"                               +
            "6.  Guild Artisan\n"                           +
            "7.  Hermit\n"                                  +
            "8.  Noble\n"                                   +
            "9.  Outlander\n"                               +
            "10. Sage\n"                                    +
            "11. Sailor\n"                                  +
            "12. Soldier\n"                                 +
            "13. Urchin\n"                                  +
            "14. City Watch\n"                              +
            "15. Clan Crafter\n"                            +
            "16. Cloistered Scholar\n"                      +
            "17. Courtier\n"                                +
            "18. Faction Agent\n"                           +
            "19. Far Traveler\n"                            +
            "20. Inheritor\n"                               +
            "21. Knight of the Order\n"                     +
            "22. Mercenary Veteran\n"                       +
            "23. Urban Bount Hunter\n"                      +
            "24. Uthgardt Tribe Member\n"                   +
            "25. Waterdhavian Noble\n", 1, 25);

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
            case 14:
               this.Background = "City Watch";
               break;
            case 15:
               this.Background = "Clan Crafter";
               break;
            case 16:
               this.Background = "Cloistered Scholar";
               break;
            case 17:
               this.Background = "Courtier";
               break;
            case 18:
               this.Background = "Faction Agent";
               break;
            case 19:
               this.Background = "Far Traveler";
               break;
            case 20:
               this.Background = "Inheritor";
               break;
            case 21:
               this.Background = "Knight of the Order";
               break;
            case 22:
               this.Background = "Mercenary Veteran";
               break;
            case 23:
               this.Background = "Urban Bount Hunter";
               break;
            case 24:
               this.Background = "Uthgardt Tribe Member";
               break;
            case 25:
               this.Background = "Waterdhavian Noble";
               break;
            default:
               this.Background = "ERROR";
               break;
         }

         addBackground();
         addClass();
      }

      public void SetScores()
      {
         stats = new AbilityScore();
         AddRacial();
         stats.SetMods();
      }

      private void AddRacial()
      {
         switch (Race)
         {
            case "Dragonborn":
               stats.addStrength(2);
               stats.addCharisma(1);
               speed = 30;
               addAbility("Draconic Ancestry (PH 34)\n");
               addAbility("Breath Weapon (PH 34)\n");
               addAbility("Damage Resistance (PH 34)\n");
               addLanguage("Common\n");
               addLanguage("Draconic\n");
               break;
            case "Hill Dwarf":
               // Dwarf
               stats.addConstitution(2);
               speed = 25;
               addAbility("Darkvision (60 ft)\n");
               addAbility("Dwarven Resiliencen (PH 20)\n");
               addProficiency("Dwarven Combat Training (PH 20)\n");
               addProficiency("Tool Proficiency (PH 20)\n");
               addLanguage("Common\n");
               addLanguage("Dwarvish\n");
               
               // Hill Dwarf
               stats.addWisdom(1);
               addProficiency("Dwarven Toughness (PH 20)\n");
               break;
            case "Mountain Dwarf":
               // Dwarf
               stats.addConstitution(2);
               speed = 25;
               addAbility("Darkvision (60 ft)\n");
               addAbility("Dwarven Resiliencen");
               addProficiency("Dwarven Combat Training (PH 20)\n");
               addProficiency("Tool Proficiency (PH 20)\n");
               addLanguage("Common\n");
               addLanguage("Dwarvish\n");

               // Mountain Dwarf
               stats.addStrength(2);
               addProficiency("Dwarven Armor Training (PH 20)\n");
               break;
            case "Duergar":
               // Dwarf
               stats.addConstitution(2);
               speed = 25;
               addAbility("Dwarven Resiliencen");
               addProficiency("Dwarven Combat Training (PH 20)\n");
               addProficiency("Tool Proficiency (PH 20)\n");
               addLanguage("Common\n");
               addLanguage("Dwarvish\n");

               // Duergar
               stats.addStrength(1);
               addAbility("Darkvision (120 ft)\n");
               addLanguage("Undercommon\n");
               addAbility("Duergar Resilience (SCAG 104)\n");
               addAbility("Duergar Magic (SCAG 104)\n");
               addAbility("Sunlight Sensitivity\n");
               break;
            case "High Elf":
               // Elf
               stats.addDexterity(2);
               speed = 30;
               addProficiency("Darkvision (60 ft)\n");
               addProficiency("Keen Senses: Perception\n");
               addAbility("Fey Ancestry (PH 23)\n");
               addAbility("Trance (PH 23)\n");
               addLanguage("Common\n");
               addLanguage("Elvish\n");

               // High Elf
               stats.addIntelligence(1);
               addProficiency("Elf Weapon Training (PH 23)\n");
               addAbility("Cantrip\n");
               addLanguage("Another language of your choice\n");
               break;
            case "Wood Elf":
               // Elf
               stats.addDexterity(2);
               speed = 30;
               addProficiency("Darkvision (60 ft)\n");
               addProficiency("Keen Senses: Perception\n");
               addAbility("Fey Ancestry (PH 23)\n");
               addAbility("Trance (PH 23)\n");
               addLanguage("Common\n");
               addLanguage("Elvish\n");

               // Wood Elf
               stats.addWisdom(1);
               addProficiency("Elf Weapon Training (PH 24)\n");
               speed = 35;
               addAbility("Mask of the Wild (PH 24)\n");
               break;
            case "Dark Elf (Drow)":
               // Elf
               stats.addDexterity(2);
               speed = 30;
               addProficiency("Keen Senses: Perception\n");
               addAbility("Fey Ancestry (PH 23)\n");
               addAbility("Trance (PH 23)\n");
               addLanguage("Common\n");
               addLanguage("Elvish\n");

               // Dark Elf (Drow)
               stats.addCharisma(1);
               addAbility("Superior Darkvision (120 ft)\n");
               addAbility("Sunlight Sensitivity (PH 24)\n");
               addAbility("Drow Magic (PH 24)\n");
               addProficiency("Drow Weapon Training (PH 24)\n");
               break;
            case "Air Genasi":
               // Genasi
               stats.addConstitution(2);
               speed = 30;
               addLanguage("Common\n");
               addLanguage("Primordial\n");

               // Air Genasi
               stats.addDexterity(1);
               addAbility("Unending Breath (PotA 229)\n");
               addAbility("Mingle with the Wind (PotA 229)\n");
               break;
            case "Earth Genasi":
               // Genasi
               stats.addConstitution(2);
               speed = 30;
               addLanguage("Common\n");
               addLanguage("Primordial\n");

               // Earth Genasi
               stats.addStrength(1);
               addAbility("Earth Walk (PotA 229)\n");
               addAbility("Merge with Stone (PotA 229)\n");
               break;
            case "Fire Genasi":
               // Genasi
               stats.addConstitution(2);
               speed = 30;
               addLanguage("Common\n");
               addLanguage("Primordial\n");

               // Fire Genasi
               stats.addIntelligence(1);
               abilities = String.Concat(abilities,
                  "Darkvision (60 ft)\n");
               addAbility("Fire Resistance\n");
               addAbility("Reach to the Blaze (PotA 229)\n");
               break;
            case "Water Genasi":
               // Genasi
               stats.addConstitution(2);
               speed = 30;
               addLanguage("Common\n");
               addLanguage("Primordial\n");

               // Water Genasi
               stats.addWisdom(1);
               addAbility("Acid Resistance\n");
               addAbility("Amphibious (PotA 229)\n");
               addAbility("Swim (30 ft)\n");
               addAbility("Call to the Wave (PotA 229)\n");
               break;
            case "Forest Gnome":
               // Gnome
               stats.addIntelligence(2);
               speed = 25;
               addAbility("Darkvision (60 ft)\n");
               addAbility("Gnome Cunning (PH 37)\n");
               addLanguage("Common\n");
               addLanguage("Gnomish\n");

               // Forest Gnome
               stats.addDexterity(1);
               addAbility("Natural Illusionist (PH 37)\n");
               addAbility("Speak with Small Beasts (PH 37)\n");
               break;
            case "Rock Gnome":
               // Gnome
               stats.addIntelligence(2);
               speed = 25;
               addAbility("Darkvision (60 ft)\n");
               addAbility("Gnome Cunning (PH 37)\n");
               addLanguage("Common\n");
               addLanguage("Gnomish\n");

               // Rock Gnome
               stats.addConstitution(1);
               addAbility("Artificer's Lore (PH 37)\n");
               addAbility("Tinker (PH 37)\n");
               break;
            case "Deep Gnome":
               // Gnome
               stats.addIntelligence(2);
               speed = 25;
               addAbility("Gnome Cunning (PH 37)\n");
               addLanguage("Common\n");
               addLanguage("Gnomish\n");

               // Svirfneblin
               stats.addDexterity(1);
               addAbility("Darkvision (120 ft)\n");
               addAbility("Stone Camouflage\n");
               addLanguage("Undercommon\n");
               break;
            case "Half-Elf":
               Boolean fValid = false;
               String sInput = null;
               uint uiInput = 0;

               stats.addCharisma(2);
               while(!fValid)
               {
                  Console.Out.WriteLine("Choose two other ability scores to increase.");
                  Console.Out.WriteLine("1.  Strength and Dexterity");
                  Console.Out.WriteLine("2.  Strength and Constitution");
                  Console.Out.WriteLine("3.  Strength and Intelligence");
                  Console.Out.WriteLine("4.  Strength and Wisdom");
                  Console.Out.WriteLine("5.  Dexterity and Constitution");
                  Console.Out.WriteLine("6.  Dexterity and Intelligence");
                  Console.Out.WriteLine("7.  Dexterity and Wisdom");
                  Console.Out.WriteLine("8.  Constitution and Intelligence");
                  Console.Out.WriteLine("9.  Constitution and Wisdom");
                  Console.Out.WriteLine("10. Intelligence and Wisdom");

                  sInput = Console.ReadLine();

                  if (UInt32.TryParse(sInput, out uiInput))
                  {
                     if((uiInput >= 1) && (uiInput <= 10))
                     {
                        fValid = true;
                        switch(uiInput)
                        {
                           case 1:
                              stats.addStrength(1);
                              stats.addDexterity(1);
                              break;
                           case 2:
                              stats.addStrength(1);
                              stats.addConstitution(1);
                              break;
                           case 3:
                              stats.addStrength(1);
                              stats.addIntelligence(1);
                              break;
                           case 4:
                              stats.addStrength(1);
                              stats.addWisdom(1);
                              break;
                           case 5:
                              stats.addDexterity(1);
                              stats.addConstitution(1);
                              break;
                           case 6:
                              stats.addDexterity(1);
                              stats.addIntelligence(1);
                              break;
                           case 7:
                              stats.addDexterity(1);
                              stats.addWisdom(1);
                              break;
                           case 8:
                              stats.addConstitution(1);
                              stats.addIntelligence(1);
                              break;
                           case 9:
                              stats.addConstitution(1);
                              stats.addWisdom(1);
                              break;
                           case 10:
                              stats.addWisdom(1);
                              stats.addIntelligence(1);
                              break;
                           default:
                              fValid = false;
                              break;
                        }
                     }
                  }
               }

               speed = 30;
               addAbility("Darkvision (60 ft)\n");
               addAbility("Fey Ancestry (PH 39)\n");
               addProficiency("Skill Versatility (PH 39)\n");
               addLanguage("Common\n");
               addLanguage("Elvish\n");
               addLanguage("Another language of your choice\n");
               break;
            case "Half-Orc":
               stats.addStrength(2);
               stats.addConstitution(1);
               speed = 30;
               addAbility("Darkvision (60 ft)\n");
               addProficiency("Menacing: Intimidation\n");
               addAbility("Relentless Endurance (PH 41)\n");
               addAbility("Savage Attacks (PH 41)\n");
               addLanguage("Common\n");
               addLanguage("Orc\n");
               break;
            case "Lightfoot Halfling":
               // Halfling
               stats.addDexterity(2);
               speed = 25;
               addAbility("Lucky (PH 28)\n");
               addAbility("Brave (PH 28)\n");
               addAbility("Halfling Nimbleness (PH 28)\n");
               addLanguage("Common\n");
               addLanguage("Halfling\n");

               // Lightfood
               stats.addCharisma(1);
               addAbility("Naturally Stealthy (PH 28)\n");
               break;
            case "Stout Halfling":
               // Halfling
               stats.addDexterity(2);
               speed = 25;
               addAbility("Lucky (PH 28)\n");
               addAbility("Brave (PH 28)\n");
               addAbility("Halfling Nimbleness (PH 28)\n");
               addLanguage("Common\n");
               addLanguage("Halfling\n");

               // Stout
               stats.addConstitution(1);
               addAbility("Stout Resilience (PH 28)\n");
               break;
            case "Human":
               stats.addCharisma(1);
               stats.addConstitution(1);
               stats.addDexterity(1);
               stats.addIntelligence(1);
               stats.addStrength(1);
               stats.addWisdom(1);
               speed = 30;
               addLanguage("Common\n");
               addLanguage("Another language of your choice\n");
               break;
            case "Tiefling":
               stats.addIntelligence(1);
               stats.addCharisma(2);
               speed = 30;
               addAbility("Darkvision (60 ft)\n");
               addAbility("Hellish Resistance (PH 43)\n");
               addAbility("Infernal Legacy (PH 43)\n");
               addLanguage("Common\n");
               addLanguage("Infernal\n");
               break;
            case "Aarakocra":
               stats.addDexterity(2);
               stats.addWisdom(1);
               speed = 25;
               addAbility("Flight (50ft)\n");
               addAbility("Talons: unarmed strikes deal 1d4 slashing\n");
               addLanguage("Comon\n");
               addLanguage("Aarakocra\n");
               addLanguage("Auran\n");
               break;
            case "Goliath":
               stats.addStrength(2);
               stats.addConstitution(1);
               speed = 30;
               addProficiency("Athletics\n");
               addAbility("Stone's Endurance (EEC 11)\n");
               addAbility("Powerful Build (EEC 11)\n");
               addAbility("Mountain Born (EEC 11)\n");
               addLanguage("Common\n");
               addLanguage("Giant\n");
               break;
         }

         stats.SetMods();
      }

      private void addBackground()
      {
         switch(Background)
         {
            case "Acolyte":
               addProficiency("Insight\n");
               addProficiency("Religion\n");
               addLanguage("Two of your choice\n");
               // TODO: add equipment
               break;
            case "Charlatan":
               addProficiency("Deception\n");
               addProficiency("Sleight of Hand\n");
               addProficiency("Disguise kit\n");
               addProficiency("Forgery kit\n");
               // TODO: add equipment
               break;
            case "Criminal":
               addProficiency("Deception\n");
               addProficiency("Stealth\n");
               addProficiency("One type of gaming set\n");
               addProficiency("Thieve's tools\n");
               // TODO: add equipment
               break;
            case "Entertainer":
               addProficiency("Acrobatics\n");
               addProficiency("Performance\n");
               addProficiency("Disguise Kit\n");
               addProficiency("One type of musical instrument\n");
               // TODO: add equipment
               break;
            case "Folk Hero":
               addProficiency("Animal Handling\n");
               addProficiency("Survival\n");
               addProficiency("One type of artisan's tools\n");
               addProficiency("Vehicles (land)\n");
               // TODO: add equipment
               break;
            case "Guild Artisan":
               addProficiency("Insight\n");
               addProficiency("Persuasion\n");
               addProficiency("One type of artisan's tools\n");
               addLanguage("One of your choice\n");
               // TODO: add equipment
               break;
            case "Hermit":
               addProficiency("Medicine\n");
               addProficiency("Religion\n");
               addProficiency("Herbalism kit\n");
               addLanguage("One of your choice\n");
               // TODO: add equipment
               break;
            case "Noble":
               addProficiency("History\n");
               addProficiency("Persuasion\n");
               addProficiency("One type of gaming set\n");
               addLanguage("One of your choice\n");
               // TODO: add equipment
               break;
            case "Outlander":
               addProficiency("Athletics\n");
               addProficiency("Survival\n");
               addProficiency("One type of musical instrument\n");
               addLanguage("One of your choice\n");
               // TODO: add equipment
               break;
            case "Sage":
               addProficiency("Arcana\n");
               addProficiency("History\n");
               addLanguage("Two of your choice\n");
               // TODO: add equipment
               break;
            case "Sailor":
               addProficiency("Athletics\n");
               addProficiency("Perception\n");
               addProficiency("Navigator's tools\n");
               addProficiency("Vehicles (Water)\n");
               // TODO: add equipment
               break;
            case "Soldier":
               addProficiency("Athletics\n");
               addProficiency("Intimidation\n");
               addProficiency("One type of gaming set\n");
               addProficiency("Vehicles (land)\n");
               // TODO: add equipment
               break;
            case "Urchin":
               addProficiency("Sleight of Hande\n");
               addProficiency("Stealth\n");
               addProficiency("Disguise kit\n");
               addProficiency("Thieve's tools\n");
               // TODO: add equipment
               break;
            case "City Watch":
               addProficiency("Athletics\n");
               addProficiency("Insight\n");
               addLanguage("Two of your choice\n");
               addEquipment("Uniform\n");
               addEquipment("Horn\n");
               addEquipment("Manacles\n");
               addEquipment("Pouch containing 10 gp\n");
               break;
            case "Clan Crafter":
               addProficiency("History\n");
               addProficiency("Insight\n");
               addProficiency("One type of artisan's tools\n");
               addLanguage("Dwarvish (or one of your choice if you already speak Dwarvish)\n");
               addEquipment("Artisan's tools (must be proficient)\n");
               addEquipment("Maker's mark chisel\n");
               addEquipment("Traveler's clothes\n");
               addEquipment("Pouch containing 5 gp\n");
               addEquipment("Gem worth 10 gp\n");
               break;
            case "Cloistered Scholar":
               addProficiency("History\n");
               addProficiency("Your choice of one from among Arcana, Nature, and Religion\n");
               addLanguage("Two of your choice\n");
               addEquipment("Scholar's robes\n");
               addEquipment("Writing kit:\n\tSmall pouch with a quill\n\tInk\n\t" +
                              "Folded parchment\n\tSmall penknife");
               addEquipment("Borrowed book\n");
               // TODO: 10 gp
               break;
            case "Courtier":
               addProficiency("Insight\n");
               addProficiency("Persuasion\n");
               addLanguage("Two of your choice\n");
               addEquipment("Set of fine clothes\n");
               // TODO: 5 gp
               break;
            case "Faction Agent":
               addProficiency("Insight\n");
               addProficiency("One Intelligence, Wisdow, or Charisma skill of your choice, " +
                              "as appropriate to your faction\n");
               addLanguage("Two of your choice\n");
               addEquipment("Badge or emblem of your faction\n");
               addEquipment("Copy of a seminal faction text (or code book)\n");
               addEquipment("Common clothes\n");
               // TODO: 15 gp
               break;
            case "Far Traveler":
               addProficiency("Insight\n");
               addProficiency("Perception\n");
               addProficiency("Any one musical instrument or gaming set of your choice\n");
               addLanguage("Any one of your choice\n");
               addEquipment("Traveler's clothes\n");
               addEquipment("The musical instrument or gaming set of your choice\n");
               addEquipment("Poorly wrought maps from your homeland\n");
               addEquipment("Jewelry from your homeland, worth 10 gp\n");
               // TODO: 5 gp
               // TODO: WHy areyou Here? Traits, Ideals, Bonds, and Flaws
               break;
            case "Inheritor":
               addProficiency("Survival\n");
               addProficiency("One from among Arcana, History, and Religion\n");
               addProficiency("Your choice of a gaming set or musical instrument\n");
               addLanguage("Any one of your choice\n");
               addEquipment("Your inheritance (work with your DM)\n");
               addEquipment("Traveler's clothes\n");
               addEquipment("Any item with which you are proficient\n");
               // TODO: 15 gp
               break;
            case "Knight of the Order":
               addProficiency("Persuasion\n");
               addProficiency("One from among Arcana, History, Nature, and Religion\n");
               addProficiency("One type of gaming set or musical instrument\n");
               addLanguage("One of your choice\n");
               addEquipment("Traveler's clothes\n");
               addEquipment("Signet\n");
               addEquipment("Banner of seal representing your place or rank\n");
               // TODO: 10 gp
               // TODO: ask for Order?
               break;
            case "Mercenary Veteran":
               addProficiency("Athletics\n");
               addProficiency("Persuasion\n");
               addProficiency("One type of gaming set\n");
               addProficiency("Land Vehicles\n");
               addEquipment("Uniform of your company (Traveler's clothes)\n");
               addEquipment("Insignia of your rank\n");
               // TODO: 10 gp
               break;
            case "Urban Bount Hunter":
               addProficiency("Choose two from among:\n" + 
                              "\tDeception\n\tInsight\n\tPersuasion\n\tStealth\n");
               addProficiency("Choose two from among one type of:\n\t" +
                              "Gaming set\n\tOne musical instrument\n\tThieves' tools\n");
               addEquipment("Clothes appropriate to your duties\n");
               // TODO: 20 gp
               break;
            case "Uthgardt Tribe Member":
               addProficiency("Athletics\n");
               addProficiency("Survival\n");
               addProficiency("One type of musical instrument or artisan's tools\n");
               addLanguage("One of your choice\n");
               addEquipment("Hunting trap\n");
               addEquipment("Totemic token or set of tattooes marking your loyalty to Uthgar or your tribal totem\n");
               addEquipment("Traveler's clothes\n");
               // TODO: 10 gp
               break;
            case "Waterdhavian Noble":
               addProficiency("History\n");
               addProficiency("Persuasion\n");
               addProficiency("One type of gaming set or one musical instrument\n");
               addLanguage("One of your choice\n");
               addEquipment("Set of fine clothes\n");
               addEquipment("Signet ring or brooch\n");
               addEquipment("Scroll of pedigree\n");
               addEquipment("Skinf of fine zzar or wine\n");
               // TODO: 20 gp
               break;
            default:
               break;
         }
      }

      private void addAbility(String ability)
      {
         abilities = String.Concat(abilities, "\t");
         abilities = String.Concat(abilities, ability);
      }

      private void addProficiency(String proficiency)
      {
         proficiencies = String.Concat(proficiencies, "\t");
         proficiencies = String.Concat(proficiencies, proficiency);
      }

      private void addLanguage(String language)
      {
         languages = String.Concat(languages, "\t");
         languages = String.Concat(languages, language);
      }

      private void addEquipment(String equipment)
      {
         this.equipment = String.Concat(this.equipment, "\t");
         this.equipment = String.Concat(this.equipment, equipment);
      }

      private uint getValidUINT(String prompt, uint lowerBound, uint upperBound)
      {
         Boolean fValid = false;    // flag for validity of user input
         String sInput  = null;     // user input
         uint uiInput   = 0;        // parsed user input

         while(!fValid)
         {
            Console.Out.WriteLine(prompt);

            sInput = Console.ReadLine();

            if (UInt32.TryParse(sInput, out uiInput))
            {
               if ((uiInput >= lowerBound) && (uiInput <= upperBound))
               {
                  fValid = true;
               }
            }

            if(!fValid)
            {
               Console.Out.WriteLine("Error! Invalid input; please try again\n");
            }
         }

         return uiInput;
      }

      private void addClass()
      {
         uint uiInput = 0;

         switch(Class)
         {
            case "Barbarian":
               health = (uint)(12 + stats.GetConMod());
               addProficiency("Light armor\n");
               addProficiency("Medium armor\n");
               addProficiency("Shields\n");
               addProficiency("Simple weapons\n");
               addProficiency("Martial weapons\n");
               addProficiency("Strength saving throws\n");
               addProficiency("Constitution saving throws\n");
               addProficiency("Choose two from:\n\t\tAnimal Handling\n\t\t" +
                  "Athletics\n\t\tIntimidation\n\t\tNature\n\t\tPerception" +
                  "\n\t\tSurvival\n");
               
               uiInput = getValidUINT("\nChoose one of following:\n" +
                  "1. Greataxe\n2. Any martial weapon\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Greataxe\n");
               }
               else
               {
                  addEquipment("Any Martial weapon\n");
               }

               uiInput = getValidUINT("\nChoose one of the following:\n" +
                  "1. Two handaxes\n2. Any simple weapon\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Two handaxes\n");
               }
               else
               {
                  addEquipment("Any simple weapon\n");
               }

               addEquipment("An explorer's pack\n");
               addEquipment("Javelin x4\n");
               break;
            case "Bard":
               addProficiency("Leather armor\n");
               addProficiency("Simple weapons\n");
               addProficiency("Hand crossbows\n");
               addProficiency("Longswords\n");
               addProficiency("Rapiers\n");
               addProficiency("Shortswords\n");
               addProficiency("Three musical instruments of your choice\n");
               addProficiency("Dexterity saving throws\n");
               addProficiency("Charisma saving throws\n");
               addProficiency("Any three skills\n");

               health = (uint)(8 + stats.GetConMod());
               uiInput = getValidUINT("\nChoose one of following:\n" +
                  "1. Rapier\n2. Longsword\n3. Any simple weapon\n", 1, 3);
               if(uiInput == 1)
               {
                  addEquipment("Rapier\n");
               }
               else if(uiInput == 2)
               {
                  addEquipment("Longsword\n");
               }
               else
               {
                  addEquipment("Any simple weapon\n");
               }

               uiInput = getValidUINT("\nChoose one of the following:\n" +
                  "1. Diplomat's pack\n2. Entertainer's pack\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Diplomat's pack\n");
               }
               else
               {
                  addEquipment("Entertainer's pack\n");
               }

               uiInput = getValidUINT("\nChoose one of the following:\n" +
                  "1. Lute\n2. Any other musical instrument\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Lute\n");
               }
               else
               {
                  addEquipment("Any non-lute musical instrument\n");
               }

               addEquipment("Leaather armor\n");
               addEquipment("Dagger\n");
               break;
            case "Cleric":
               health = (uint)(8 + stats.GetConMod());
               addProficiency("Light armor\n");
               addProficiency("Medium armor\n");
               addProficiency("Shields\n");
               addProficiency("Simple weapons\n");
               addProficiency("Wisdom saving throws\n");
               addProficiency("Charisma saving throws\n");
               addProficiency("Choose two from:\n\t\tHistory\n\t\tInsight\n\t\t" +
                  "Medicine\n\t\tPersuasion\n\t\tReligion.\n");
               
               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Mace\n2. Warhammer\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Mace\n");
               }
               else
               {
                  addEquipment("Warhammer\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n"  +
                  "1. Scale mail\n"                                     +
                  "2. Leather armor\n"                                  +
                  "3. Chain mail (if proficient)\n", 1, 3);
               if(uiInput == 1)
               {
                  addEquipment("Scale mail\n");
               }
               else if(uiInput == 2)
               {
                  addEquipment("Leather armor\n");
               }
               else
               {
                  addEquipment("Chain mail\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Light crossbow and 20 bolts\n" +
                  "2. Any simple weapon\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Light crossbow\n");
                  addEquipment("Crossbow bolt x20\n");
               }
               else
               {
                  addEquipment("Any simple weapon\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Priest's pack\n2. Explorer's pack\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Priest's pack\n");
               }
               else
               {
                  addEquipment("Explorer's pack\n");
               }

               addEquipment("Shield\n");
               addEquipment("Holy symbol\n");
               break;
            case "Druid":
               health = (uint)(8 + stats.GetConMod());
               addProficiency("Light armor\n");
               addProficiency("Medium armor\n");
               addProficiency("Shields\n");
               addProficiency(
                  "Note: Druids will not wear armor or use shields made of metal\n");

               addProficiency("Clubs\n");
               addProficiency("Daggers\n");
               addProficiency("Darts\n");
               addProficiency("Javelins\n");
               addProficiency("Maces\n");
               addProficiency("Quartersaffs\n");
               addProficiency("Scimitars\n");
               addProficiency("Sickles\n");
               addProficiency("Slings\n");
               addProficiency("Spears\n");
               addProficiency("Herbalism kit\n");
               addProficiency("Intelligence saving throws\n");
               addProficiency("Wisdom saving throws\n");
               addProficiency(
                  "Choose two from:\n\t\tArcana\n\t\tAnimal Handling\n\t\tInsight" +
                  "\n\t\tMedicine\n\t\t" + 
                  "Nature\n\t\tPerception\n\t\tReligion\n\t\tSurvival");

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Wooden shield\n2. Any simple weapon\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Wooden shield\n");
               }
               else
               {
                  addEquipment("Any simple weapon\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Scimitar\n2. Any simple weapon\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Scimitar\n");
               }
               else
               {
                  addEquipment("Any simple weapon\n");
               }

               addEquipment("Leather armor\n");
               addEquipment("Explorer's pack\n");
               addEquipment("Druidic focus\n");
               break;
            case "Fighter":
               health = (uint)(10 + stats.GetConMod());
               addProficiency("All armor\n");
               addProficiency("Shields\n");
               addProficiency("Simple weapons\n");
               addProficiency("Martial weapons\n");
               addProficiency("Strength saving throws\n");
               addProficiency("Constitution saving throws\n");
               addProficiency("Choose two from:\n\t\tAcrobatics\n\t\t" +
                  "Animal Handling\n\t\tAthletics\n\t\tHistory\n\t\tInsight\n\t\t" +
                  "Intimidation\n\t\tPerception\n\t\tSurvival\n");

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Chain mail\n2. Leather armor, longbow, and 20 arrows\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Chain mail\n");
               }
               else
               {
                  addEquipment("Leather armor\n");
                  addEquipment("Longbow\n");
                  addEquipment("Arrows x20\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Martial weapon and a shield\n2. Two martial weapons\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Any martial weapon\n");
                  addEquipment("Shield\n");
               }
               else
               {
                  addEquipment("Any martial weapon\n");
                  addEquipment("Any martial weapon\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Light crossbow and 20 bolts\n2. Two handaxes\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Light crossbow\n");
                  addEquipment("Crossbow bolt x20\n");
               }
               else
               {
                  addEquipment("Handaxe\n");
                  addEquipment("Handaxe\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Dungeoneer's pack\n2. Explorer's pack\n", 1, 2);

               if(uiInput == 1)
               {
                  addEquipment("Dungeoneer's pack\n");
               }
               else
               {
                  addEquipment("Explorer's pack\n");
               }
               break;
            case "Monk":
               health = (uint)(8 + stats.GetConMod());
               addProficiency("Simple weapons\n");
               addProficiency("Shortswords\n");
               addProficiency(
                  "Choose one type of artisan's tools or one musical instrument\n");
               addProficiency("Strength saving throws\n");
               addProficiency("Dexterity saving throws\n");
               addProficiency("Choose two from:\n\t\tAcrobatics\n\t\t" +
                  "Athletics\n\t\tHistory\n\t\tInsight\n\t\tReligion\n\t\tStealth\n");

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1.Shortsword\n2.Any simple weapon\n", 1, 2);

               if(uiInput == 1)
               {
                  addEquipment("Shortsword\n");
               }
               else
               {
                  addEquipment("Any simple weapon\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Dungeoneer's pack\n2. Explorer's pack\n", 1, 2);

               if(uiInput == 1)
               {
                  addEquipment("Dungeoneer's pack\n");
               }
               else
               {
                  addEquipment("Explorer's pack\n");
               }

               addEquipment("Darts x10\n");
               break;
            case "Paladin":
               health = (uint)(10 + stats.GetConMod());
               addProficiency("All armor\n");
               addProficiency("Shields\n");
               addProficiency("Simple weapons\n");
               addProficiency("Martial weapons\n");
               addProficiency("Wisdom saving throws\n");
               addProficiency("Charisma saving throws\n");
               addProficiency("Choose two from:\n\t\tAthletics\n\t\t" +
                  "Insight\n\t\tIntimidation\n\t\tMedicine\n\t\tPersuasion\n\t\t" +
                  "Religion\n");

               break;
            case "Ranger":
               health = (uint)(10 + stats.GetConMod());
               addProficiency("Light armor\n");
               addProficiency("Medium armor\n");
               addProficiency("Shields\n");
               addProficiency("Simple weapons\n");
               addProficiency("Martial weapons\n");
               addProficiency("Strength saving throws\n");
               addProficiency("Dexterity saving throws\n");
               addProficiency("Choose three from:\n\t\tAnimal Handling\n\t\t" +
                  "Athletics\n\t\tInsight\n\t\tInvestigation\n\t\t" +
                  "Nature\n\t\tPerception\n\t\tStealth\n\t\tSurvival\n");

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Scale mail\n2. Leather armor\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Scale mail\n");
               }
               else
               {
                  addEquipment("Leather armor\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Two shortswords\n2. Two simple melee weapons\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Shortsword\n");
                  addEquipment("Shortsword\n");
               }
               else
               {
                  addEquipment("Any simple melee weapon\n");
                  addEquipment("Any simple melee weapon\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Dungeoneer's pack\n2. Explorer's pack\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Dungeoneer's pack\n");
               }
               else
               {
                  addEquipment("Explorer's pack\n");
               }

               addEquipment("Longbow\n");
               addEquipment("Arrows x20\n");
               break;
            case "Rogue":
               health = (uint)(8 + stats.GetConMod());
               addProficiency("Light armor\n");
               addProficiency("Simple weapons\n");
               addProficiency("Hand crossbows\n");
               addProficiency("Longswords\n");
               addProficiency("Rapiers\n");
               addProficiency("Shortswords\n");
               addProficiency("Thieve's tools\n");
               addProficiency("Dexterity saving throws\n");
               addProficiency("Intelligence saving throws\n");
               addProficiency("Choose four from:\n\t\tAcrobatics\n\t\t" +
                  "Athletics\n\t\tDeception\n\t\tPerformance\n\t\t" +
                  "Persuasion\n\t\tSleight of Hand\n\t\tStealth\n");

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Rapier\n2. Shortsword\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Rapier\n");
               }
               else
               {
                  addEquipment("Shortsword\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Shortbow and quiver of 20 arrows\n2. Shortsword\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Shortbow\n");
                  addEquipment("Quiver\n");
                  addEquipment("Arrows x20\n");
               }
               else
               {
                  addEquipment("Shortsword\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Burglar's pack\n2. Dungeoneer's pack\n3. Explorer's pack\n", 1, 3);
               if(uiInput == 1)
               {
                  addEquipment("Burglar's pack\n");
               }
               else if (uiInput == 2)
               {
                  addEquipment("Dungeoneer's pack\n");
               }
               else
               {
                  addEquipment("Explorer's pack\n");
               }

               addEquipment("Leather armor\n");
               addEquipment("Dagger\n");
               addEquipment("Dagger\n");
               addEquipment("Thieves' tools\n");
               break;
            case "Sorcerer":
               health = (uint)(6 + stats.GetConMod());
               addProficiency("Daggers\n");
               addProficiency("Darts\n");
               addProficiency("Slings\n");
               addProficiency("Quarterstaffs\n");
               addProficiency("Light crossbows\n");
               addProficiency("Constitution saving throws\n");
               addProficiency("Charisma saving throws\n");
               addProficiency("Choose two from:\n\t\tArcana\n\t\t" +
                  "Deception\n\t\tInsight\n\t\tIntimidation\n\t\t" +
                  "Persuasion\n\t\tReligion\n");

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Light crossbow and 20 bolts\n2. Any simple weapon\n", 1, 2);
               if (uiInput == 1)
               {
                  addEquipment("Light crossbow\n");
                  addEquipment("Crossbow bolt x20\n");
               }
               else
               {
                  addEquipment("Any simple weapon\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Component pouch\n2. Arcane focus\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Component pouch\n");
               }
               else
               {
                  addEquipment("Arcane focus\n");
               }

               addEquipment("Dagger\n");
               addEquipment("Dagger\n");
               break;
            case "Warlock":
               health = (uint)(8 + stats.GetConMod());
               addProficiency("Light armor\n");
               addProficiency("Simple weapons\n");
               addProficiency("Wisdom saving throws\n");
               addProficiency("Charisma saving throws\n");
               addProficiency("Choose two skills from:\n\t\t" +
                  "Arcana\n\t\tDeception\n\t\tHistory\n\t\tIntimidation\n\t\t" +
                  "Investigation\n\t\tNature\n\t\tReligion\n");

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Light crossbow and 20 bolts\n2. Any simple weapon\n", 1, 2);

               if(uiInput == 1)
               {
                  addEquipment("Light crossbow\n");
                  addEquipment("Crossbow bolt x20\n");
               }
               else
               {
                  addEquipment("Any simple weapon\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Component pouch\n2. Arcane focus\n", 1, 2);

               if(uiInput == 1)
               {
                  addEquipment("Component pouch\n");
               }
               else
               {
                  addEquipment("Arcane focus\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Scholar's pack\n2. Dungeoneer's pack\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Scholar's pack\n");
               }
               else
               {
                  addEquipment("Dungeoneer's pack\n");
               }

               addEquipment("Leather armor\n");
               addEquipment("Any simple weapon\n");
               addEquipment("Dagger\n");
               addEquipment("Dagger\n");
               break;
            case "Wizard":
               health = (uint)(6 + stats.GetConMod());
               addProficiency("Daggers\n");
               addProficiency("Darts\n");
               addProficiency("Slings\n");
               addProficiency("Quarterstaffs\n");
               addProficiency("Light crossbows\n");
               addProficiency("Intelligence saving throws\n");
               addProficiency("Wisdom saving throws\n");
               addProficiency("Choose two from:\n\t\tArcana\n\t\t" +
                  "History\n\t\tInsight\n\t\tInvestigation\n\t\t" +
                  "Medicine\n\t\tReligion\n");

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Quarterstaff\n2. Dagger\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Quarterstaff\n");
               }
               else
               {
                  addEquipment("Dagger\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n" + 
                  "1. Component pouch\n2. Arcane focus\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Component pouch\n");
               }
               else
               {
                  addEquipment("Arcane focus\n");
               }

               uiInput = getValidUINT("Choose one of the following:\n" +
                  "1. Scholar's pack\n2. Explorer's pack\n", 1, 2);
               if(uiInput == 1)
               {
                  addEquipment("Scholar's pack\n");
               }
               else
               {
                  addEquipment("Explorer's pack\n");
               }

               addEquipment("Spellbook\n");
               break;
            default:
               break;
         }
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
               do
               {

                  for (uint c = 0; c < 4; c++)
                  {
                     dice[c] = (uint)rand.Next(1, 7);
                  }

                  Array.Sort<uint>(dice);

                  scores[i] = dice[1] + dice[2] + dice[3];

               } while (scores[i] < 6);
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

      public int GetConMod()
      {
         SetConMod();
         return conMod;
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

   class Money
   {
      public uint Platinum;
      public uint Gold;
      public uint Electrum;
      public uint Silver;
      public uint Copper;

      public Money()
      {
         this.Platinum  = 0;
         this.Gold      = 0;
         this.Electrum  = 0;
         this.Silver    = 0;
         this.Copper    = 0;
      }

      // TODO: Buy function
      // TODO: Sell function
   }
}
