<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserCase4.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" 
            Text="Passenger Information"></asp:Label>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Flight Number:
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp; Date of Journey:
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Search" />
        <br />
        <br />
        <br />
        <asp:Calendar ID="Calendar2" runat="server" onselectionchanged="Calendar2_SelectionChanged"></asp:Calendar>
        <br />
    <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False">
    <Columns>
       
        
        <asp:BoundField HeaderText="Name" DataField="CUSTOMER_NAME" />
        <asp:BoundField HeaderText="Seat Number" DataField="SEAT_NUMBER" />
        <asp:BoundField HeaderText="Departure Airport Code" DataField="DEPARTURE_AIRPORT_CODE" />
        <asp:BoundField HeaderText="Arrival Airport Code" DataField="ARRIVAL_AIRPORT_CODE" />
       
        
        </Columns>
    </asp:GridView>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        Passenger Name:&nbsp;
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Search" />
        <br />
        <br />
    <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns="False">
    <Columns>
       
        
        <asp:BoundField HeaderText="Flight Number" DataField="FLIGHT_NUMBER" />
        <asp:BoundField HeaderText="Seat Number" DataField="SEAT_NUMBER" />
        <asp:BoundField HeaderText="Date" DataField="DATE" />
        <asp:BoundField HeaderText="Departure Airport Code" DataField="DEPARTURE_AIRPORT_CODE" />
        <asp:BoundField HeaderText="Arrival Airport Code" DataField="ARRIVAL_AIRPORT_CODE" />
       
        
        </Columns>
    </asp:GridView>
    
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" Text="Back" />
    
    </div>
    </form>
</body>
</html>
