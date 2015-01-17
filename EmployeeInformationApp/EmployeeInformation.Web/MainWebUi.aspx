<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainWebUi.aspx.cs" Inherits="EmployeeInformation.Web.MainWebUi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="designationButton" runat="server" OnClick="designationButton_Click" Text="Add Designation" />
        <asp:Button ID="employeeEntryButton" runat="server" Text="Employee Entry" OnClick="employeeEntryButton_Click" />
        <asp:Button ID="findAndEditButton" runat="server" Text="Find and Edit" OnClick="findAndEditButton_Click" />
    
    </div>
    </form>
</body>
</html>
