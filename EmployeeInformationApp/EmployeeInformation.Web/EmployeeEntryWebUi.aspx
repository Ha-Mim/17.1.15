<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeEntryWebUi.aspx.cs" Inherits="EmployeeInformation.Web.EmployeeEntryWebUi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Employee Name"></asp:Label>
        <asp:TextBox ID="nameEntryTextBox" runat="server"></asp:TextBox>
    
    </div>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Employee Email"></asp:Label>
            <asp:TextBox ID="emailEntryTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Employee Address"></asp:Label>
            <asp:TextBox ID="adressEntryTextBox" runat="server" style="margin-bottom: 0px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Employee Designation"></asp:Label>
            <asp:DropDownList ID="employeeEntryDropDownList" runat="server">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="saveEmployeeEnteryButton" runat="server" Text="Save" OnClick="saveEmployeeEnteryButton_Click" />
            <asp:Label ID="messegeLabel" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
