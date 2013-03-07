using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;


namespace myWebSite
{
    public partial class Wohnungslogs : System.Web.UI.Page
    {

          const string CONSTRING = "Server=instance29437.db.xeround.com;Port=19153;Database=users;Uid=appharbor;Pwd=NNDKjRzh";

        protected void Page_Load(object sender, EventArgs e)
        {
            // Create sample data for the DataList control.
            DataTable dt = new DataTable();
            DataRow dr;

            // Define the columns of the table.
            //      dt.Columns.Add(new DataColumn("IntegerValue", typeof(Int32)));
            //    dt.Columns.Add(new DataColumn("StringValue", typeof(String)));
            //  dt.Columns.Add(new DataColumn("CurrencyValue", typeof(double)));
            dt.Columns.Add(new DataColumn("Header", typeof(String)));
            dt.Columns.Add(new DataColumn("Bild", typeof(String)));
            dt.Columns.Add(new DataColumn("Kaltmiete", typeof(String)));
            dt.Columns.Add(new DataColumn("Wohnflaeche", typeof(String)));
            dt.Columns.Add(new DataColumn("Zimmer", typeof(String)));
            dt.Columns.Add(new DataColumn("Ausstattung1", typeof(String)));
            dt.Columns.Add(new DataColumn("Ausstattung2", typeof(String)));
            dt.Columns.Add(new DataColumn("Ausstattung3", typeof(String)));
            dt.Columns.Add(new DataColumn("Ausstattung4", typeof(String)));
            dt.Columns.Add(new DataColumn("Lage", typeof(String)));
            dt.Columns.Add(new DataColumn("Zeit", typeof(String)));
            //my_init();
            HashSet<int> currentIDs = new HashSet<int>();

            //connect
            MySqlConnection con = new MySqlConnection(CONSTRING);
            con.Open();


            //adapter
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            //SQL Abfrage erstellen
            string cmdText = "SELECT * FROM Web_Whg_table ORDER BY ZEIT DESC";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);

            //Datatable abrufen
            DataTable dt2 = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt2);
            DataRowCollection dataRowC = dt2.Rows;


            int j= dataRowC.Count;

            for (int i = 0; i < j; i++)
            {
               // ListBox1.Items.Add("Zeit: " + dataRowC[i].ItemArray[11] + " ||| ID: " + dataRowC[i].ItemArray[0] + "   |||    Header: " + dataRowC[i].ItemArray[1] + "    |||   Miete: " + dataRowC[i].ItemArray[3] + "   |||    Zimmer: " + dataRowC[i].ItemArray[4] + "   |||    Flaeche: " + dataRowC[i].ItemArray[5] + "  |||     Lage: " + dataRowC[i].ItemArray[10]);
                dr = dt.NewRow();

                dr[0] = dataRowC[i].ItemArray[1];   // Header
                dr[1] = dataRowC[i].ItemArray[2];   // Picture
                dr[2] = dataRowC[i].ItemArray[3];   //Kaltmiete
                dr[3] = dataRowC[i].ItemArray[5];   //Wohnfläche
                dr[4] = dataRowC[i].ItemArray[4];   //Zimmer
                dr[5] = dataRowC[i].ItemArray[6];   //Ausstattung1
                dr[6] = dataRowC[i].ItemArray[7];   //Ausstattung2
                dr[7] = dataRowC[i].ItemArray[8];   //Ausstattung3
                dr[8] = dataRowC[i].ItemArray[9];   //Ausstattung4
                dr[9] = dataRowC[i].ItemArray[10];   //Lage
                dr[10] = dataRowC[i].ItemArray[11];   //Zeit


                dt.Rows.Add(dr);

            }

            DataView dv = new DataView(dt);

            myDatalst.DataSource = dv;
            //    = new[] {
            //       new { Bild = "http://picture.immobilienscout24.de/files/odw002/N/176/943/76/176943076-3.jpg?1174550284"},
            //      new { Bild = "http://picture.immobilienscout24.de/files/odw002/N/176/943/76/176943076-3.jpg?1174550284"}

            //};
            

            myDatalst.DataBind();

            con.Close();
            
        }

        DataView CreateDataSource()
        {

            // Create sample data for the DataList control.
            DataTable dt = new DataTable();
            DataRow dr;

            // Define the columns of the table.
      //      dt.Columns.Add(new DataColumn("IntegerValue", typeof(Int32)));
        //    dt.Columns.Add(new DataColumn("StringValue", typeof(String)));
          //  dt.Columns.Add(new DataColumn("CurrencyValue", typeof(double)));
            dt.Columns.Add(new DataColumn("Header", typeof(String)));
            dt.Columns.Add(new DataColumn("Bild", typeof(String)));
            dt.Columns.Add(new DataColumn("Kaltmiete", typeof(String)));
            dt.Columns.Add(new DataColumn("Wohnflaeche", typeof(String)));
            dt.Columns.Add(new DataColumn("Zimmer", typeof(String)));
            // Populate the table with sample values.
            for (int i = 0; i < 3; i++)
            {
                dr = dt.NewRow();

                dr[0] = "http://picture.immobilienscout24.de/files/odw002/N/176/943/76/176943076-3.jpg?1174550284";
              //  dr[1] = "Description for item " + i.ToString();
              //  dr[2] = 1.23 * (i + 1);
               // dr[3] = "Image" + i.ToString() + ".jpg";

                dt.Rows.Add(dr);
            }

            DataView dv = new DataView(dt);
            return dv;
        }

    }
}