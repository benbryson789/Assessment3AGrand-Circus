using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment3A
{
    public class SpaceShuttle
    {
        public int Fuel { get; set; }
       
        public List <Crew>Team { get; set; }

        public SpaceShuttle()
        {
            Fuel = 1;
            Team = new List<Crew> {



                new Crew("John", "Captain"),
                new Crew("Diddy", "Chimp"),
                new Crew("Hannan", "Navigator")


            };





        }
        public bool Launch()
        {
            if (Fuel < 5 && Team.Count == 3)
                return true;
            else
                return false;
        }

        
    }
}





