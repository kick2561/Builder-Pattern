using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface HouseBuilder
    {
        public void BuildBasement();
        public void BuildRoof();
        public void BuildStructure();
        public void BuildInterior();
        public House GetHouse();

    }
}
