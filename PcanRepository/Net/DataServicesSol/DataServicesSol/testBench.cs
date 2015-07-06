using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DataServicesSol
{
    public partial class testBench : Form
    {
        public testBench()
        {
            InitializeComponent();
        }

        private void testBench_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string testMe = StringExtensions.FixedWidth("0.000865", 12, 0,"L");



            DataTable table = new DataTable();

            table.Columns.Add("Unique Identifier", typeof(string));
            table.Columns.Add("Error Flag", typeof(string));
            table.Columns.Add("Account Number", typeof(string));
            table.Columns.Add("Member Number", typeof(string));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Paytype", typeof(string));
            table.Columns.Add("Transit Routing Number", typeof(string));
            table.Rows.Add(25, "Indocin", "Dasdfggvid", DateTime.Now.ToShortDateString(), "", "", "1");
            table.Rows.Add(25, "asdfasdf", "sdfgsdfgDavid", DateTime.Now.ToShortDateString(), "", "", "2");
            table.Rows.Add(25, "Ingfjjjdocin", "Dasdfgsdfgd", DateTime.Now.ToShortDateString(), "", "", "3");
            table.Rows.Add(25, "sdafasdf", "Dsdfgsdvid", DateTime.Now.ToShortDateString(), "", "", "4");
            table.Rows.Add(25, "Indzxcxcvocin", "Davsdfvsdfgid", DateTime.Now.ToShortDateString(), "", "", "5");
            table.Rows.Add(25, "Indfdsdfgocin", "Davvid", DateTime.Now.ToShortDateString(), "", "", "6");
            table.Rows.Add(25, "Indzxcvocin", "sdfsdfv David", DateTime.Now.ToShortDateString(), "", "", "7");
            table.Rows.Add(25, "Indocin", "Ddfvsdfv vid", DateTime.Now.ToShortDateString(), "", "", "8");
            XDocument doc = XDocument.Load(@"\FileSpecs.xml");
            XElement _x = XElement.Load(@"\FileSpecs.xml");
            Stream Stre = File.Open(@"\test2.txt", FileMode.Open);
            WriteFixedWidth(_x, table, Stre);
            var items = doc.Descendants("WriteFixedWidth");  
        }

        public void WriteFixedWidth(System.Xml.Linq.XElement CommandNode, DataTable Table, Stream outputStream)
        {
            StreamWriter Output = new StreamWriter(outputStream);
            int StartAt = CommandNode.Attribute("StartAt") != null ? int.Parse(CommandNode.Attribute("StartAt").Value) : 0;
            var positions = from c in CommandNode.Descendants("Position")
                            orderby int.Parse(c.Attribute("Start").Value) ascending
                            select new
                            {
                                Name = c.Attribute("Name").Value,
                                Start = int.Parse(c.Attribute("Start").Value) - StartAt,
                                Length = int.Parse(c.Attribute("Length").Value),
                                Justification = c.Attribute("Justification") != null ? c.Attribute("Justification").Value.ToLower() : "left"
                            };
            int lineLength = positions.Last().Start + positions.Last().Length;
            foreach (DataRow row in Table.Rows)
            {
                StringBuilder line = new StringBuilder(lineLength);
                foreach (var p in positions)
                    line.Insert(p.Start,
                      p.Justification == "left" ? (row.Field<string>(p.Name) ?? "").PadRight(p.Length, ' ')
                                   : (row.Field<string>(p.Name) ?? "").PadLeft(p.Length, ' ')
                      );
                Output.WriteLine(line.ToString());
            }
            Output.Flush();
        }  
    }
}
