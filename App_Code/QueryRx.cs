using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
using System.Data.SqlClient;
using System.Web.Configuration;


public static class QueryRx
{
    
    public static Rx Get_Rx(int rx_id, out string error_msg)
    {
        SqlDataReader rdr = null;
        SqlConnection cn = null;
        Rx rx1 = null;
        error_msg = ""; 
        try
        {
            cn = Setup_Connection();
            rdr = Get_Reader(rx_id, cn); //perform the query 

            //process query result
            if (rdr.Read())
            {
                rx1 = new Rx(rdr);
            }
            else
            {
                error_msg = "Lookup failed";
            }

        }
        catch (Exception ex)
        {
            error_msg = "ERROR: " + ex.Message; 
        }
        finally
        {
            if(rdr != null)
            {
                rdr.Close();
            }
            if (cn != null)
            {
                cn.Close();
            }
        }//end finally clause 

        return rx1;

    }//end get_rx functino

    public static SqlConnection Setup_Connection()
    {
        string connection_string = WebConfigurationManager.ConnectionStrings["RxTable"].ConnectionString;
        SqlConnection cn = new SqlConnection(connection_string);
        cn.Open();
        return cn; 
    }

    
    public static SqlDataReader Get_Reader(int rx_id, SqlConnection cn)
    { 
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "SELECT * FROM Rx WHERE RxID=@rx_id";  //this paramater name is arbitrary
        cmd.Parameters.AddWithValue("@rx_id", rx_id);  //could have named it @xxx as long as its consistent 
        cmd.Connection = cn;
        return cmd.ExecuteReader();
    }


}