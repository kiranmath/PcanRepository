using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateStaticVinReports
{
    public class VinReportParam
    {

        int _VinID;
        int _ReportID;
        string _ReportPeriod;
        string _ProcessDate;
        string _WeekNumber;
        string _YearNumber;



        public int ReportID
        {
            get
            {
                return this._ReportID;
            }
            set
            {
                this._ReportID = value;
            }
        }

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


        public string ReportPeriod
        {
            get
            {
                return this._ReportPeriod;
            }
            set
            {
                string rp;
                if (value == "D")
                {

                    rp = "Daily";
                }
                else if (value == "N")
                {

                    rp = "NREL";
                }
                else if (value == "B")
                {

                    rp = "DailyBattery";
                }

                else if (value == "A")
                {

                    rp = "DailyBatteryAllCust";
                }
                else
                {
                    rp = "Weekly";
                }

                this._ReportPeriod = rp;
            }
        }


        public string ProcessDate
        {
            get
            {
                return this._ProcessDate;
            }
            set
            {

                DateTime dt;
                DateTime.TryParse(value, out dt);
                var dateOnly = dt.ToShortDateString();
                this._ProcessDate = dateOnly;
            }
        }

        public string WeekNumber
        {
            get
            {
                return this._WeekNumber;
            }
            set
            {
                this._WeekNumber = value;
            }
        }


        public string YearNumber
        {
            get
            {
                return this._YearNumber;
            }
            set
            {
                this._YearNumber = value;
            }
        }

    }
}
