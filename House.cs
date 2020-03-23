using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class House : HousePlan
    {
        private string basement;
        private string roof;
        private string interior;
        private string structure;
        public void setBasement(string basement)
        {
            this.basement = basement;
        }

        public void setInterior(string interior)
        {
            this.interior = interior;
        }

        public void setRoof(string roof)
        {
            this.roof = roof;
        }

        public void setStructure(string structure)
        {
            this.structure = structure;
        }
    }
}
