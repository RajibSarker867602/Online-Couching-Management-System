<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrationPageUI.aspx.cs" Inherits="CouchingManagementApp.UI.RegistrationPageUI" %>


<!DOCTYPE html>
<html lang="en" >

<head runat="server">
  <meta charset="UTF-8">
  <title>Registration Form Page</title>
  <meta name="viewport" content="width=device-width, initial-scale=1"><link href='https://fonts.googleapis.com/css?family=Roboto:400,700' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">

      <link rel="stylesheet" href="../css/Registration Form/css/style.css" />
  
</head>

<body>
    <form id="registrationForm" runat="server">
        <p style="text-align:right"><asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" ForeColor="Blue" /></p>
  <div class="user">
    <header class="user__header">
        <h1>Registration Form</h1>
    </header>
        <div class="form__group">
            <asp:TextBox ID="userNameTextBox" runat="server" placeholder="Enter User Name" class="form__input"></asp:TextBox>
        </div>
        
        <div class="form__group">
            <asp:TextBox ID="passwordTextBox" runat="server" placeholder="Enter Password" class="form__input" TextMode="Password"></asp:TextBox>
        </div> 
        
        <div class="form__group">
            <asp:TextBox ID="confirmpassword" runat="server" placeholder="Enter Your Confirm Password" class="form__input" TextMode="Password"></asp:TextBox>
            <p style="text-align:right"><asp:CompareValidator ID="checkPassword" runat="server" BackColor="White" ControlToCompare="passwordTextBox" ControlToValidate="confirmpassword" ErrorMessage="Both Password Must Be Same" ForeColor="Red" ></asp:CompareValidator></p>
        </div>
        
        <asp:Button ID="createButton" runat="server" class="btn" Text="Create" OnClick="createButton_Click" />
</div>
    <script  src="../css/Registration Form/js2/index.js"></script>
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
