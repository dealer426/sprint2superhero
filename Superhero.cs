using System;
using System.Collections.Generic;
using System.Text;

namespace sprint2superhero
{
    public class Superhero
    {
        //Create 4 Fields
        private string name;
        private int strengthLevel;
        private bool hasCape;
        private int speedLevel;
        private int healthLevel;

        //Create 4 Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int StrengthLevel
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }
        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }
        public int SpeedLevel
        {
            get { return this.speedLevel; }
            set { this.speedLevel = value; }
        }
        public int HealthLevel
        {
            get { return this.healthLevel; }
            set { this.healthLevel = value; }
        }

        //Create 3 Constructors

        //Default Contstructor
        public Superhero()
        {

        }

        //Constructor 2
        public Superhero(int strengthLevel, bool hasCape)
        {
            StrengthLevel = strengthLevel;
            HasCape = hasCape;
        }

        //Constructor 3
        public Superhero(string name, int strengthLevel, bool hasCape, int speedLevel, int healthLevel)
        {
            Name = name;
            StrengthLevel = strengthLevel;
            HasCape = hasCape;
            SpeedLevel = speedLevel;
            HealthLevel = healthLevel;
        }

        //Create 2 Methods

        public void WhoAmI()
        {
            Console.WriteLine("I am " + name + "\nWith a Stregthlevel of:  " + strengthLevel +
                "\nWith a Speedlevel of: " + speedLevel + "\nMy current Healthlevel is: " + healthLevel);
        }

        //Impact Super Heros Health

        public int ImpactSuperHeroHealth(int healthAdjustmentNumber)
        {
           return HealthLevel += healthAdjustmentNumber;

        }

        //Give Super Hero a Power Boost

        public int ImpactSuperHeroPowerBoost(int powerBoostAdjustment)
        {
            return StrengthLevel += powerBoostAdjustment;

        }
    }
}
