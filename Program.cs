using System;

namespace sprint2superhero
{
    class Program
    {
        static void Main(string[] args)
        {
            Superhero superMan = new Superhero("Superman", 100, true, 100, 100);

            superMan.WhoAmI();

            //Choose a number to Impact the SuperHeros Health
            int healthImpact = -20;

            superMan.ImpactSuperHeroHealth(healthImpact);

            Console.WriteLine("My new Health Level: {0}", superMan.HealthLevel);

            Console.ReadKey();

        }
    }
}
