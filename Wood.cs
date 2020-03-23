using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Wood : HouseBuilder
    {
        private House house;
        public Wood()
        {
            house = new House();
        }

        
        public void BuildBasement()
        {
            house.setBasement("Wooden base");
        }

        public void BuildInterior()
        {
            house.setInterior("Timber");
        }

        public void BuildRoof()
        {
            house.setRoof("Wooden roof");
        }

        public void BuildStructure()
        {
            house.setStructure("Rectangle");
        }

        public House GetHouse()
        {
            return house;
        }
    }
}
