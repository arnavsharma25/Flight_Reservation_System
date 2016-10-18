<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserCase1.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    &nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        Departure Airport Code:&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp; Arrival Airport Code:&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Search FLight" 
            onclick="Button1_Click" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox1" runat="server" 
            oncheckedchanged="CheckBox1_CheckedChanged" Text="1 Hop" />
&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox2" runat="server" Text="2 Hop" />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" >
        <Columns>
       
        
        <asp:BoundField HeaderText="Flight Number" DataField="FLIGHT_NUMBER" />
        <asp:BoundField HeaderText="Airline" DataField="Airline" />
        <asp:BoundField HeaderText="Working Days" DataField="Weekdays" />
        
        
        
        </Columns>
        </asp:GridView>
    
        <br />
        <br />
    
        <br/>

        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
            Width="217px">
       <Columns>
       
        
        <asp:BoundField HeaderText="Flight Number" DataField="Flight_Number" />
        <asp:BoundField HeaderText="Airline" DataField="Airline" />
        <asp:BoundField HeaderText="Working Days" DataField="Weekdays" />
        <asp:BoundField HeaderText="Departure Airport Code" DataField="DEPARTURE_AIRPORT_CODE" />
        <asp:BoundField HeaderText="Scheduled Departure Time" DataField="SCHEDULED_DEPARTURE_TIME" />
        <asp:BoundField HeaderText="Arrival Airport Code" DataField="ARRIVAL_AIRPORT_CODE" />
        <asp:BoundField HeaderText="Scheduled Arrival Time" DataField="SCHEDULED_ARRIVAL_TIME" />
        <asp:BoundField HeaderText="Flight Duration" DataField="FLIGHT_DURATION" />
        
        
        <asp:BoundField HeaderText="Connecting Flight Number" DataField="ConFlightNumber" FooterStyle-BorderStyle="NotSet" />
        <asp:BoundField HeaderText="Airline" DataField="ConAirline" />
        <asp:BoundField HeaderText="Working Days" DataField="ConWeekDay" />
        <asp:BoundField HeaderText="Departure Airport Code" DataField="ConDepartureAirportCode" />
        <asp:BoundField HeaderText="Scheduled Departure Time" DataField="ConDepartureTime" />
        <asp:BoundField HeaderText="Arrival Airport Code" DataField="ConArrivalAirportCode" />
        <asp:BoundField HeaderText="Scheduled Arrival Time" DataField="ConArrivalTime" />
        <asp:BoundField HeaderText="Flight Duration" DataField="ConFlightDuration" />


        
        </Columns>
        </asp:GridView>
    
        <br />
        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" 
            Width="217px">
       <Columns>
       
        
        <asp:BoundField HeaderText="Flight Number" DataField="Flight_Number" />
        <asp:BoundField HeaderText="Airline" DataField="Airline" />
        <asp:BoundField HeaderText="Working Days" DataField="Weekdays" />
        <asp:BoundField HeaderText="Departure Airport Code" DataField="DEPARTURE_AIRPORT_CODE" />
        <asp:BoundField HeaderText="Scheduled Departure Time" DataField="SCHEDULED_DEPARTURE_TIME" />
        <asp:BoundField HeaderText="Arrival Airport Code" DataField="ARRIVAL_AIRPORT_CODE" />
        <asp:BoundField HeaderText="Scheduled Arrival Time" DataField="SCHEDULED_ARRIVAL_TIME" />
        <asp:BoundField HeaderText="Flight Duration" DataField="FLIGHT_DURATION" />
        
        
         <asp:BoundField HeaderText="Connecting Flight Number" DataField="f2Flight_Number" />
        <asp:BoundField HeaderText="Airline" DataField="f2Airline" />
        <asp:BoundField HeaderText="Working Days" DataField="f2Weekdays" />
        <asp:BoundField HeaderText="Departure Airport Code" DataField="f2DEPARTURE_AIRPORT_CODE" />
        <asp:BoundField HeaderText="Scheduled Departure Time" DataField="f2SCHEDULED_DEPARTURE_TIME" />
        <asp:BoundField HeaderText="Arrival Airport Code" DataField="f2ARRIVAL_AIRPORT_CODE" />
        <asp:BoundField HeaderText="Scheduled Arrival Time" DataField="f2SCHEDULED_ARRIVAL_TIME" />
        <asp:BoundField HeaderText="Flight Duration" DataField="f2FLIGHT_DURATION" />

         <asp:BoundField HeaderText="Connecting Flight Number" DataField="f3Flight_Number" />
        <asp:BoundField HeaderText="Airline" DataField="f3Airline" />
        <asp:BoundField HeaderText="Working Days" DataField="f3Weekdays" />
        <asp:BoundField HeaderText="Departure Airport Code" DataField="f3DEPARTURE_AIRPORT_CODE" />
        <asp:BoundField HeaderText="Scheduled Departure Time" DataField="f3SCHEDULED_DEPARTURE_TIME" />
        <asp:BoundField HeaderText="Arrival Airport Code" DataField="f3ARRIVAL_AIRPORT_CODE" />
        <asp:BoundField HeaderText="Scheduled Arrival Time" DataField="f3SCHEDULED_ARRIVAL_TIME" />
        <asp:BoundField HeaderText="Flight Duration" DataField="f3FLIGHT_DURATION" />


        
        </Columns>
        </asp:GridView>
        <br />
    
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Back" />
    
    </div>
    </form>
</body>
</html>
