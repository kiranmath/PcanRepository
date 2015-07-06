using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateStaticVinReports
{
   public class Vehicles
    {
        int _VinID;
        string _Vin;
        int _CustomerID;
        string _CustomerName;


        public int VinID
        {
            get
            {
                return this._VinID;
            }
            set
            {
                this._VinID = value;
            }
        }


        public string Vin
        {
            get
            {
                return this._Vin;
            }
            set
            {
                this._Vin = value;
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
