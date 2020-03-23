using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface HousePlan
    {
        public void setBasement(string basement);
        public void setRoof(string roof);
        public void setStructure(string structure);
        public void setInterior(string interior);
    }
}
