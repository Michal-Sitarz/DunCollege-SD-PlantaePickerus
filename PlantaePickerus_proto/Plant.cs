using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantaePickerus_proto
{

    class Plant
    {
        public int plantID { get; set; }
        public string plantName { get; set; }
        public string plantLatinName { get; set; }
        public string plantType { get; set; }
        public string plantSize { get; set; }
        public bool plantBlooming { get; set; }
        public string plantGrowingSpeed { get; set; }
        public int requireSunlight { get; set; }
        public int requireHumidity { get; set; }
        public string requireDirection { get; set; }
        public bool coldDrafts { get; set; }
        public int spotIDFK { get; set; }

        public Plant()
        {

        }
            
    }
}
