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


         //   my_init();
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
            DataTable dt = new DataTable();
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            DataRowCollection dataRowC = dt.Rows;

            int j= dataRowC.Count;

            for (int i = 0; i < j; i++)
            {
                ListBox1.Items.Add("Zeit: " + dataRowC[i].ItemArray[11] + " ||| ID: " + dataRowC[i].ItemArray[0] + "   |||    Header: " + dataRowC[i].ItemArray[1] + "    |||   Miete: " + dataRowC[i].ItemArray[3] + "   |||    Zimmer: " + dataRowC[i].ItemArray[4] + "   |||    Flaeche: " + dataRowC[i].ItemArray[5] + "  |||     Lage: " + dataRowC[i].ItemArray[10]);
                

            }


            
        }
    }
}