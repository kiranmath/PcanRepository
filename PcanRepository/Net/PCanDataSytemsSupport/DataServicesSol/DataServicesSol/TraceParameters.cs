using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataServicesSol
{
    class TraceParameters
    {

        Int16 _CustomerID;
     
       public Int16 CustomerID
        {

            get { return this._CustomerID; }
            set { this._CustomerID = value; }
        }

       String _CustomerName;
       public String CustomerName
       {

           get { return this._CustomerName; }
           set { this._CustomerName = value; }
       }

       Int16 _DataType;
       public Int16 DataType
       {

           get { return this._DataType; }
           set { this._DataType = value; }
       }


       Int16 _ChargingStationID;
       public Int16 ChargingStationID
       {

           get { return this._ChargingStationID; }
           set { this._ChargingStationID = value; }
       }


       String _ChargingStationLocation;
       public String ChargingStationLocation
       {

           get { return this._ChargingStationLocation; }
           set { this._ChargingStationLocation = value; }
       }
        
       Int16 _ISOWeek;
       public Int16 ISOWeek
       {

           get { return this._ISOWeek; }
           set { this._ISOWeek = value; }
       }

       Int16 _Year;
       public Int16 Year
       {

           get { return this._Year; }
           set { this._Year = value; }
       }



       Int32 _VinID;
       public Int32 VinID
       {

           get { return this._VinID; }
           set { this._VinID = value; }
       }


       String _Vin;
       public String Vin
       {

           get { return this._Vin; }
           set { this._Vin = value; }
       }


       DateTime _EventDate;
       public DateTime EventDate
       {

           get { return this._EventDate; }
           set { this._EventDate = value; }
       }

       string _StartTime;
       public string StartTime
       {

           get { return this._StartTime; }
           set { this._StartTime = value; }
       }

       string _EndTime;
       public string EndTime
       {

           get { return this._EndTime; }
           set { this._EndTime = value; }
       }


       string _OutputFilePath;
       public string OutputFilePath
       {

           get { return this._OutputFilePath; }
           set { this._OutputFilePath = value; }
       }


       string _OutputFolderPath;
       public string OutputFolderPath
       {

           get { return this._OutputFolderPath; }
           set { this._OutputFolderPath = value; }
       }



       string _OutputNetworkFolderPath;
       public string OutputNetworkFolderPath
       {

           get { return this._OutputNetworkFolderPath; }
           set { this._OutputNetworkFolderPath = value; }
       }



       string _OutputNetworkFilePath;
       public string OutputNetworkFilePath
       {

           get { return this._OutputNetworkFilePath; }
           set { this._OutputNetworkFilePath = value; }
       }

       Int16 _AllSymbols;
       public Int16 AllSymbols
       {

           get { return this._AllSymbols; }
           set { this._AllSymbols = value; }
       }


       string _ListSymbols;
       public string ListSymbols
       {

           get { return this._ListSymbols; }
           set { this._ListSymbols = value; }
       }

       string _ListVariables;
       public string ListVariables
       {

           get { return this._ListVariables; }
           set { this._ListVariables = value; }
       }

       string _ListVariablesSql;
       public string ListVariablesSql
       {

           get { return this._ListVariablesSql; }
           set { this._ListVariablesSql = value; }
       }

       string _UserName;
       public string UserName
       {

           get { return this._UserName; }
           set { this._UserName = value; }
       }
    }
}
