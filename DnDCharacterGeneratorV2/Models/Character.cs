using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnDCharacterGeneratorV2.Models
{
    public enum Race
    {
        Human,
        Elf,
        Dwarf,
        Halfling,
        Gnome,
        Tiefling,
        DragonBorn,
        HalfOrk,
        HalfElf
    }
    public enum Skills { 
        Acrobatics,
        AnimalHandling,
        Arcana,
        Athletics,
        Deception,
        History,
        Insight,
        Intimidation,
        Investigation,
        Medicine,
        Nature,
        Perception,
        Performance,
        Persuasion,
        Religion,
        SleightOfHand,
        Stealth,
        Survival
    }

    public class Character
    {
        //core character data
        public string Name { get; set; }
        public int Level { get; set; }
        public int HP { get; set; }
        public int AC { get; set; }
        
        public int Proficiency { get; set; }

        //parameter data
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Intelligence { get; set; }


        //Backstory data
        public string Alignment { get; set; }

        public Race get;

        //more to be added as needed
    }
}