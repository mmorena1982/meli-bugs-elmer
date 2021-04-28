using System;

namespace BugsAndElmer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hunter elmer = new Hunter();
            Gun gun = new RemingtonRifle(model: "750", calibre: 45);
            Animal yogi = new Bear();
            
            elmer.Shoot(yogi, gun);

            System.Console.WriteLine(yogi.IsAlive() ? "Run Elmer!" : "Oh no, poor bear");

            Gun crossbow = new Crossbow();
            Animal duck = new Duck();
            elmer.Shoot(duck, crossbow);

            System.Console.WriteLine(duck.IsAlive() ? "You must change your gun, Elmer!" : "Oh no, poor duck!");
        }
    }
}
