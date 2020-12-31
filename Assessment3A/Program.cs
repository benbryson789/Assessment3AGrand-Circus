using System;

namespace Assessment3A
{
    class Program
    {
        static void Main(string[] args)
        {
            SpaceShuttle spaceShuttle = new SpaceShuttle();
            //spaceShuttle = 6;
            spaceShuttle.Team.Add(new Crew("Peter", "Accountant"));
            bool result = spaceShuttle.Launch();
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
