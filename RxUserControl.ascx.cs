using System;
//using System.Collections;
using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Data.SqlClient;

public partial class RxUserControl : System.Web.UI.UserControl
{
    //variables
    List<Rx> rx_list = new List<Rx>();


    protected void Page_Load(object sender, EventArgs e)
    {
        lbl11.Text = "";
        lbl12.Text = "";
        lbl13.Text = "";
        lbl14.Text = "";
        lbl15.Text = "";
        lbl16.Text = "";
        lbl17.Text = "";
        lbl18.Text = "";
        lbl19.Text = "";
        lbl21.Text = "";
        lbl22.Text = "";
        lbl23.Text = "";
        lbl24.Text = "";
        lbl25.Text = "";
        lbl26.Text = "";
        lbl27.Text = "";
        lbl28.Text = "";
        lbl29.Text = "";
        lblRx.Text = "";

        
        if (Application["RxTable"] == null) //if list of scripts isnt populated yet
        {

            //populate the table 

            string errMsg = "failed Application State Variable list Population";
            int i = 1; //rxID =1 will be checked first, up to 100
            do
            {
                Rx tempRx = QueryRx.Get_Rx(i, out errMsg); //perscription with rxid = i

                if (tempRx != null)
                {
                    rx_list.Add(tempRx); //add to list 
                }
                ++i;
                

            } while (i < 100); //assuming RxID can not be more than 2 digits 

            Application["RxTable"] = rx_list; //set application variable to the list 
            
        }
        else
        {
            rx_list = (List<Rx>)Application["RxTable"];
        }

        //at this point, the RxTable application list is populated 

        //if it is the first time being loaded, populate the drop down list  
        if (!IsPostBack )
        { 
            ListItem li = new ListItem("Select Rx ID", ""); //create an empty ddl item
            ddlRx.Items.Add(li);                //add empty ddl item to ddl

            foreach(Rx rx in rx_list )
            {
                //add each RxID to the ddl 
                li = new ListItem(rx.Rxid.ToString(), rx.Rxid.ToString());
                ddlRx.Items.Add(li);

            }//end foreach loop

        }//end if not postback


    }


    //the ddl is autopostback
    protected void ddlRx_SelectedIndexChanged(object sender, EventArgs e)
    {
        //dont do anything if they just select the first generic option
        if(ddlRx.SelectedIndex == 0)
        {
            return; //a fresh page load will set all labels to empty strings
        }

        string errMsg = "Failed Lookup";
        int j;
        Int32.TryParse(ddlRx.SelectedValue, out j);

        Rx rx1 = QueryRx.Get_Rx(j, out errMsg);

        lbl11.Text = rx1.Rsphere.ToString();
        lbl12.Text = rx1.Rcylinder.ToString();
        lbl13.Text = rx1.Raxis.ToString();
        lbl14.Text = rx1.Rprism.ToString();
        lbl15.Text = rx1.Rbase.ToString();
        lbl16.Text = rx1.Radd.ToString();
        lbl17.Text = rx1.Rseg.ToString();
        lbl18.Text = rx1.Rpd.ToString();
        lbl19.Text = rx1.Rnpd.ToString();
        lbl21.Text = rx1.Lsphere.ToString();
        lbl22.Text = rx1.Lcylinder.ToString();
        lbl23.Text = rx1.Laxis.ToString();
        lbl24.Text = rx1.Lprism.ToString();
        lbl25.Text = rx1.Lbase.ToString();
        lbl26.Text = rx1.Ladd.ToString();
        lbl27.Text = rx1.Lseg.ToString();
        lbl28.Text = rx1.Lpd.ToString();
        lbl29.Text = rx1.Lnpd.ToString();
        lblRx.Text = rx1.Rxid.ToString();

    }
}