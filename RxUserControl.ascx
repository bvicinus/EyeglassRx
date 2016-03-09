<%@ Control Language="C#" AutoEventWireup="true" CodeFile="RxUserControl.ascx.cs" Inherits="RxUserControl" %>

<link rel="stylesheet" href="StyleSheet1.css" />

<table >

    <tr>
        <th>Eye </th>
        <th>Sphere</th>
        <th>Cyl</th>
        <th>Axis</th>
        <th>Prism</th>
        <th>Base</th>
        <th>Add</th>
        <th>Seg</th>
        <th>PD</th>
        <th>NPD</th>
    </tr>

    <tr>
        <td>OD</td>
        <td>
            <asp:Label ID="lbl11" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbl12" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbl13" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbl14" runat="server" Text="Label"></asp:Label>
        </td>
        <td >
            <asp:Label ID="lbl15" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbl16" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbl17" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbl18" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbl19" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>

    <tr >
        <td >OS</td>
        <td>
            <asp:Label ID="lbl21" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbl22" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbl23" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbl24" runat="server" Text="Label"></asp:Label>
        </td>
        <td >
            <asp:Label ID="lbl25" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbl26" runat="server" Text="Label"></asp:Label>
        </td>
         <td>
             <asp:Label ID="lbl27" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbl28" runat="server" Text="Label"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lbl29" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>

</table>
<p>
    Rx ID
    <asp:Label ID="lblRx" runat="server"></asp:Label>
</p>
<asp:DropDownList ID="ddlRx" runat="server" AutoPostBack="True" Height="24px" OnSelectedIndexChanged="ddlRx_SelectedIndexChanged" Width="170px">
</asp:DropDownList>
