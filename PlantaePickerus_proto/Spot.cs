using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantaePickerus_proto
{

    class Spot
    {
        public int spotID { get; set; }
        public string spotName { get; set; }
        public int spotSunlight { get; set; }
        public int spotHumidity { get; set; }
        public string spotDirection { get; set; }
        public bool spotDrafts { get; set; }

        public Spot()
        {

        }

        //SETters
        public void setSpotID(int _spotID)
        {
            this.spotID = _spotID;
        }

        public void setSpotName(string _spotName)
        {
            this.spotName = _spotName;
        }
        
        public void setSpotSunlight(int _spotSunlight)
        {
            this.spotSunlight = _spotSunlight;
        }

        public void setSpotHumidity(int _spotHumidity)
        {
            this.spotHumidity = _spotHumidity;
        }

        public void setSpotDirection(string _spotDirection)
        {
            this.spotDirection = _spotDirection;
        }

        public void setSpotDrafts(bool _spotDrafts)
        {
            this.spotDrafts = _spotDrafts;
        }


        //GETters
        public int getSpotID()
        {
            return this.spotID;
        }

        public string getSpotName()
        {
            return this.spotName;
        }

        public int getSpotSunlight()
        {
            return this.spotSunlight;
        }

        public int getSpotHumidity()
        {
            return this.spotHumidity;
        }

        public string getSpotDirection()
        {
            return this.spotDirection;
        }

        public bool getSpotDrafts()
        {
            return this.spotDrafts;
        }


    }
}
