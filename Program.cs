using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Igloo igloo = new Igloo();
            CivilEngineer civilEngineer = new CivilEngineer(igloo);
            civilEngineer.constructHouse();
            House house = new House();
            Console.WriteLine("Builder Constructed {0} ", house.GetHashCode());
        }
    }
}
