<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPageUI.aspx.cs" Inherits="CouchingManagementApp.UI.LoginPageUI" %>


<!DOCTYPE html>
<html lang="en" >

<head runat="server">
  <meta charset="UTF-8">
  <title>User Login Page</title>
  
  
  
      <link rel="stylesheet" href="../css/css/style.css" />

  
</head>

<body>
    <form id="loginForm" runat="server">
  <div class="background-wrap">
  <div class="background"></div>
</div>

  <h1 id="litheader">User Access</h1>
        
  <div class="inset">
    <p>
        <%--<asp:RequiredFieldValidator ID="userNameReq" runat="server" ControlToValidate="userNameTextBox" ErrorMessage="User Name Is Required!" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>--%>
      <asp:TextBox ID="userNameTextBox" runat="server" placeholder="Enter User Name"></asp:TextBox>
      <strong style="text-align:right"></strong>
    </p>
    <p>
        <%--<strong style="text-align:right"><asp:RequiredFieldValidator ID="passwordReq" runat="server" ControlToValidate="passwordTextBox" ErrorMessage="Password Is Required!" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator></strong>--%>
      <asp:TextBox ID="passwordTextBox" runat="server" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
    </p>
  </div>
  <p class="p-container">
      <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" />
      <asp:LinkButton ID="createNewAccountButton" runat="server" Text="Create New Account" OnClick="createNewAccountButton_Click"></asp:LinkButton>
  </p>
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

  

    <script  src="../css/js/index.js"></script>



        </form>
</body>

</html>













<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>--%>
