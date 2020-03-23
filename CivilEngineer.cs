using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class CivilEngineer
    {
        private HouseBuilder housebuilder;
        public CivilEngineer(HouseBuilder houseBuilder)
        {
            this.housebuilder = houseBuilder;
        }
        public void constructHouse()
        {
            this.housebuilder.BuildBasement();
            this.housebuilder.BuildStructure();
            this.housebuilder.BuildRoof();
            this.housebuilder.BuildInterior();
        }
        public House getHouse()
        {
            return this.housebuilder.GetHouse();
        }
    }
}
