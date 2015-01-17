<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddDesignationWebUi.aspx.cs" Inherits="EmployeeInformation.Web.AddDesignationWebUi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Code"></asp:Label>
        <asp:TextBox ID="codeTextBox" runat="server"></asp:TextBox>
    
    </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Designation"></asp:Label>
            <asp:TextBox ID="designationTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="saveDesignationButton" runat="server" Text="Save" OnClick="saveDesignationButton_Click" />
            <asp:Label ID="messageLabel" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
