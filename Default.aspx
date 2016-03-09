<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register src="RxUserControl.ascx" tagname="RxUserControl" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rx</title>
    <link rel="stylesheet" href="StyleSheet1.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
      Eyeglass Perscription App 
        <br />
        <br />
    </div>
        <uc1:RxUserControl ID="RxUserControl1" runat="server" />  
         
      
     
         <br />
         <br />




    </form>
 
</body>
</html>
