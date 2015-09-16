using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChartGenerator
{
    public class Chargers
    {


        int _ChargingStationID;
        string _Location;
        int _CustomerID;
        string _CustomerName;


        public int ChargingStationID
        {
            get
            {
                return this._ChargingStationID;
            }
            set
            {
                this._ChargingStationID = value;
            }
        }


        public string Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                this._Location = value;
            }
        }


        public int CustomerID
        {
            get
            {
                return this._CustomerID;
            }
            set
            {
                this._CustomerID = value;
            }
        }





        public string CustomerName
        {
            get
            {
                return this._CustomerName;
            }
            set
            {
                this._CustomerName = value;
            }
        }

    }
    
}