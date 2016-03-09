using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

//DONE 


public class Rx
{
    private int         rxid;
    private decimal     rsphere;
    private decimal     rcylinder;
    private int         raxis;
    private decimal     rprism;
    private int         rbase;
    private decimal     radd;
    private int         rseg;
    private decimal     rpd;
    private decimal     rnpd;
    private decimal     lsphere;
    private decimal     lcylinder;
    private int         laxis;
    private decimal     lprism;
    private int         lbase;
    private decimal     ladd;
    private int         lseg;
    private decimal     lpd;
    private decimal     lnpd;

    public int Rxid
    {
        get
        {
            return rxid;
        }
    }

    public decimal Rsphere
    {
        get
        {
            return rsphere;
        }

        set
        {
            rsphere = value;
        }
    }

    public decimal Rcylinder
    {
        get
        {
            return rcylinder;
        }

        set
        {
            rcylinder = value;
        }
    }

    public int Raxis
    {
        get
        {
            return raxis;
        }

        set
        {
            raxis = value;
        }
    }

    public decimal Rprism
    {
        get
        {
            return rprism;
        }

        set
        {
            rprism = value;
        }
    }

    public int Rbase
    {
        get
        {
            return rbase;
        }

        set
        {
            rbase = value;
        }
    }

    public decimal Radd
    {
        get
        {
            return radd;
        }

        set
        {
            radd = value;
        }
    }

    public int Rseg
    {
        get
        {
            return rseg;
        }

        set
        {
            rseg = value;
        }
    }

    public decimal Rpd
    {
        get
        {
            return rpd;
        }

        set
        {
            rpd = value;
        }
    }

    public decimal Rnpd
    {
        get
        {
            return rnpd;
        }

        set
        {
            rnpd = value;
        }
    }

    public decimal Lsphere
    {
        get
        {
            return lsphere;
        }

        set
        {
            lsphere = value;
        }
    }

    public decimal Lcylinder
    {
        get
        {
            return lcylinder;
        }

        set
        {
            lcylinder = value;
        }
    }

    public int Laxis
    {
        get
        {
            return laxis;
        }

        set
        {
            laxis = value;
        }
    }

    public decimal Lprism
    {
        get
        {
            return lprism;
        }

        set
        {
            lprism = value;
        }
    }

    public int Lbase
    {
        get
        {
            return lbase;
        }

        set
        {
            lbase = value;
        }
    }

    public decimal Ladd
    {
        get
        {
            return ladd;
        }

        set
        {
            ladd = value;
        }
    }

    public int Lseg
    {
        get
        {
            return lseg;
        }

        set
        {
            lseg = value;
        }
    }

    public decimal Lpd
    {
        get
        {
            return lpd;
        }

        set
        {
            lpd = value;
        }
    }

    public decimal Lnpd
    {
        get
        {
            return lnpd;
        }

        set
        {
            lnpd = value;
        }
    }

    public Rx(SqlDataReader rdr)
    {
        rxid = (int)rdr["RxID"];
        rsphere = (decimal)rdr["RSphere"];
        rcylinder = (decimal)rdr["RCylinder"];
        raxis = (int)rdr["Raxis"];
        rprism = (decimal)rdr["RPrism"];
        rbase = (int)rdr["RBase"];
        radd = (decimal)rdr["RAdd"];
        rseg = (int)rdr["RSeg"];
        rpd = (decimal)rdr["RPD"];
        rnpd = (decimal)rdr["RNPD"];
        lsphere = (decimal)rdr["LSphere"];
        lcylinder = (decimal)rdr["LCylinder"];
        laxis = (int)rdr["Laxis"];
        lprism = (decimal)rdr["LPrism"];
        lbase = (int)rdr["LBase"];
        ladd = (decimal)rdr["RAdd"];
        lseg = (int)rdr["LSeg"];
        lpd = (decimal)rdr["LPD"];
        lnpd = (decimal)rdr["LNPD"];
    }
}