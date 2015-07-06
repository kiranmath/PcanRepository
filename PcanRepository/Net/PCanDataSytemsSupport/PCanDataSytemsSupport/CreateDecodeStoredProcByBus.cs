using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;



namespace PCanDataSytemsSupport
{
    public partial class CreateDecodeStoredProcByBus : Form
    {

        Customer cust = new Customer();
        public CreateDecodeStoredProcByBus()
        {
            InitializeComponent();
        }

        private void GenSprocBut_Click(object sender, EventArgs e)
        {
            //GenerateSprocs();
            try
            {

                string destPath = txtOutPutFilePath.Text.Trim();
                cust.ComboFileNameTable = destPath + "/Combo_Table_" + cust.CustomerName + ".txt";
                cust.ComboFileNameSproc = destPath + "/Combo_Sproc_" + cust.CustomerName + ".txt";

                LoopThruDbObj();
                MessageBox.Show("Files Generated");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           

        }


        private void LoopThruDbObj()
        {

            string OutputFilePath = txtOutPutFilePath.Text.Trim();


            StringBuilder sbsql = new StringBuilder();
            int i = 0;
            
            
            foreach (string dbObjName in chkListItems.CheckedItems)
            {



              
                GenTable(dbObjName);

                GenSproc(dbObjName);

               

                i += 1;

            }
        }

        private void GenSproc(string dbObjName)
        {
        string destPath =txtOutPutFilePath.Text.Trim();
        string FileGrp = txtFileGrp.Text.Trim();
      
        string DestinationComboFile = destPath + "/Combo_Bus_" + cust.CustomerName + ".txt";
        string DestinationFile = destPath + "/" + dbObjName + "_Sproc.txt";

            FileInfo fiDest = new FileInfo(destPath);


            DirectoryInfo diDF = new DirectoryInfo("../../Sprocs");

            var files = from FileInfo f in diDF.GetFiles("*.txt")
                where f.Name != fiDest.Name
                select f;


            foreach(FileInfo fiRead in files) 
            {

            // create reader & open file
                string filePath = "../../Sprocs/" + fiRead.Name.ToString();
                string line;
     
               
                TextReader tr = fiRead.OpenText();
                TextWriter tw = new StreamWriter(@DestinationFile);

                //// read a line of text
                while ((line = tr.ReadLine()) != null) 
                {

                  
                           if (line.Contains("{0}"))
                               {
                                  line = line.Replace("{0}",FileGrp);
                               }

                           if (line.Contains("{1}"))
                               {
                                 line =  line.Replace("{1}", dbObjName);
                               }
                           
                          tw.WriteLine(line);
                          line = "";
                                       

                }

                // close the stream
                tr.Close();
                tw.Close();
                CopyStream(DestinationFile, cust.ComboFileNameSproc);
            }
        }

        private void GenTable(string dbObjName)
        {
            string destPath = txtOutPutFilePath.Text.Trim();
            string FileGrp = txtFileGrp.Text.Trim();
            string TabConstraint = "";
    

            string dbObjType = "";
            string x = dbObjName.Substring(0, 1);

            // Bus or Charger VIN starts with 1
            if (dbObjName.Substring(0,1) == "1")
            {
                dbObjType = "VinTables";
                TabConstraint = this.get_DataServices_BusByCustTableAdapter.GetVinID(dbObjName).ToString();
            }
            else
            {
                dbObjType = "ChrgTables";
                TabConstraint = this.get_DataServices_ChargingStationsByCustTableAdapter.GetChargingStationID(dbObjName).ToString();
            }


            string DestinationComboFile = destPath + "/Combo_Charger_" + cust.CustomerName + ".txt";
            string DestinationFile = destPath + "/" + dbObjName + "_" + dbObjType + ".txt";


            FileInfo fiDest = new FileInfo(destPath);


            DirectoryInfo diDF = new DirectoryInfo("../../" + dbObjType  );

            var files = from FileInfo f in diDF.GetFiles("*.txt")
                        where f.Name != fiDest.Name
                        select f;


            foreach (FileInfo fiRead in files)
            {

                // create reader & open file
                string filePath = "../../" + dbObjType + "/" + fiRead.Name.ToString();
                string line;
                // 
                TextReader tr = fiRead.OpenText();
                TextWriter tw = new StreamWriter(@DestinationFile);

                //// read a line of text
                while ((line = tr.ReadLine()) != null)
                {


                    if (line.Contains("{0}"))
                    {
                        line = line.Replace("{0}", FileGrp);
                    }

                    if (line.Contains("{1}"))
                    {
                        line = line.Replace("{1}", dbObjName);
                    }


                    if (line.Contains("{2}"))
                    {
                        line = line.Replace("{2}", TabConstraint);
                    }


                    tw.WriteLine(line);
                    line = "";


                }

                // close the stream
                tr.Close();
                tw.Close();

                CopyStream(DestinationFile, cust.ComboFileNameTable);
            }
        }



	

       void CopyStream2(Stream destination, Stream source) {
   int count;
   int BUFFER_SIZE = 4096;
   byte[] buffer = new byte[BUFFER_SIZE];
   while( (count = source.Read(buffer, 0, buffer.Length)) > 0)
       destination.Write(buffer, 0, count);
}


       void CopyStream(string srcFileName, string destFileName)
{
    //FileStream fileStream = new FileStream(destFileName, FileMode.Append);
    using (StreamWriter destStream = new StreamWriter(destFileName, true))
    {


        string contents = File.ReadAllText(srcFileName);
        destStream.Write(contents);

    }


    //using (Stream destStream = File.OpenWrite(destFileName))
    //{
        
    //        using (Stream srcStream = File.OpenRead(srcFileName))
    //        {
    //            srcStream.CopyTo(destStream);
    //        }
       
    //}
}


       void CopyStream3(string[] srcFileNames,string destFileName)
{

        // = { "file1.txt", "file2.txt", "file3.txt" };
        //string destFileName = "destFile.txt";

        using (Stream destStream = File.OpenWrite(destFileName))
        {
            foreach (string srcFileName in srcFileNames)
            {
                using (Stream srcStream = File.OpenRead(srcFileName))
                {
                    srcStream.CopyTo(destStream);
                }
            }
        }
}

        private void btnOutPutFilePath_Click(object sender, EventArgs e)
        {


          
        }

        private void CreateDecodeStoredProcByBus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getCustomer._Get_DataServices_Customer' table. You can move, or remove it, as needed.

            
            

            this.get_DataServices_CustomerTableAdapter.Fill(this.getCustomer._Get_DataServices_Customer);

        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            short CustomerID = Convert.ToInt16(cbCustomer.SelectedValue.ToString());
            string CustomerName = cbCustomer.Text;
            

            cust.CustomerID = CustomerID;
            cust.CustomerName = CustomerName;

   

          

            this.get_DataServices_ChargingStationsByCustTableAdapter.Fill(this.getCharger._Get_DataServices_ChargingStationsByCust, CustomerID);
            this.get_DataServices_BusByCustTableAdapter.Fill(this.getBus._Get_DataServices_BusByCust, CustomerID);
            txtFileGrp.Text = this.get_DataServices_CustomerTableAdapter.GetFileGrp(CustomerID).ToString();

            
            populateCheckgrid(CustomerID);
        }


        private void populateCheckgrid(short CustomerID)
        {
            chkListItems.Items.Clear();

            this.get_DataServices_ChargingStationsByCustTableAdapter.Fill(this.getCharger._Get_DataServices_ChargingStationsByCust, CustomerID);
            this.get_DataServices_BusByCustTableAdapter.Fill(this.getBus._Get_DataServices_BusByCust, CustomerID);

           // List<ArrayList> newval = new List<ArrayList>();
            foreach (DataRow dRow in getCharger.Tables[0].Rows)
            {
               // ArrayList values = new ArrayList();
                if (dRow.ItemArray[1].ToString() != "-1" )
                { 
                this.chkListItems.Items.Add(dRow.ItemArray[2].ToString());
                }
                
            }

            foreach (DataRow dRow in getBus.Tables[0].Rows)
            {
               // ArrayList values = new ArrayList();
                if (dRow.ItemArray[1].ToString() != "-1")
                {
                    this.chkListItems.Items.Add(dRow.ItemArray[2].ToString());
                }

            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gbStatus_Enter(object sender, EventArgs e)
        {

        }

        private void btnOutPutFilePath_Click_1(object sender, EventArgs e)
        {
      


            DialogResult result = sfdOutputFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                //
                // The user selected a folder and pressed the OK button.
                // We print the number of files found.
                //

                txtOutPutFilePath.Text = sfdOutputFolder.SelectedPath;
               // string[] files = Directory.GetFiles(sfdOutputFolder.SelectedPath);
               // MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }
        }

        private void gbDataFilter_Enter(object sender, EventArgs e)
        {

        }

    }
}