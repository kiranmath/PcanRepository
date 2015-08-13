using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using DataServicesSol;
using Microsoft.VisualBasic;


namespace GenerateTraceData
{
    class Program
    {
        static void Main(string[] args)
        {
           // string x = StringExtensions.FixedWidth("0.000865", 12, 0, "L");
            
            WriteTraceFileFromDB();
        }

        public static void WriteTraceFileFromDB()
        {
            string ConnStr = Properties.Settings.Default.PcanRepositoryConnStr.ToString();

            SqlCommand comm = new SqlCommand();
            comm.Connection = new SqlConnection(ConnStr);
            comm.CommandText = "dbo.[Gen-DataServices-CreateTraceFile]";
            comm.CommandType = CommandType.StoredProcedure;
            comm.Parameters.AddWithValue("@ReportID", 4);

           // int rowAffected = comm.ExecuteNonQuery();
            comm.CommandTimeout = 2000;
            comm.Connection.Open();

            SqlDataReader sqlReader = comm.ExecuteReader();

            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            string dbFile = filePath + @"\sqlFile2.txt";

            Console.WriteLine("Getting Data");
using (StreamWriter file = new StreamWriter(dbFile,true))
{


    while (sqlReader.Read())
    {

        string sTraceDt = StringExtensions.FixedWidth(sqlReader["TraceDt"].ToString().Trim(), 13, 1, "R");
        string sBus = StringExtensions.FixedWidth(sqlReader["Bus"].ToString(), 3, 0, "R");
        string sSymbolIDHex = StringExtensions.FixedWidth(sqlReader["SymbolIDHex"].ToString(), 16, 0, "R");
        string sDataType = StringExtensions.FixedWidth(sqlReader["DataType"].ToString(), 5, 0, "R");
        string sReserved = StringExtensions.FixedWidth(sqlReader["Reserved"].ToString(), 2, 0, "R");
        string sDLC = StringExtensions.FixedWidth(sqlReader["DLC"].ToString(), 2, 0, "R");
        string sData = sqlReader["Data"].ToString();
       // string  sTraceDt = "Test";
        file.WriteLine(sTraceDt + sBus + sSymbolIDHex + sDataType + sReserved + sDLC + sData);

    }

}
sqlReader.Close();
comm.Connection.Close();


        }


    }
}
