using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Igloo : HouseBuilder
    {
        private House house;
        public Igloo()
        {
            house = new House();
        }
        public void BuildBasement()
        {
            this.house.setBasement("Igloo base");
        }

        public void BuildInterior()
        {
            house.setInterior("Igloo interior");
        }

        public void BuildRoof()
        {
            house.setRoof("Igloo Roof");
        }

        public void BuildStructure()
        {
            house.setStructure("igloo structure");
        }

        public House GetHouse()
        {
            return this.house;
        }
    }
}
