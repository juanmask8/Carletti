<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loggin.aspx.cs" Inherits="loggin" %>
<!DOCTYPE html>
<html lang="en">
  <head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">   
    <title>Signin Template for Bootstrap</title>
    <!-- Bootstrap core CSS -->
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <!-- Custom styles for this template -->
    <link href="css/signin.css" rel="stylesheet">
    <!-- Just for debugging purposes. Don't actually copy these 2 lines! -->
    <!--[if lt IE 9]><script src="../../assets/js/ie8-responsive-file-warning.js"></script><![endif]-->
    <script src="js/ie-emulation-modes-warning.js"></script>

    <!-- HTML5 shim and Respond.js for IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
      <script src="https://oss.maxcdn.com/html5shiv/3.7.2/html5shiv.min.js"></script>
      <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
    <![endif]-->
  </head>

  <body>
    <form id="form1" runat="server">
    <div class="container">
      <form class="form-signin" role="form">
        <h2 class="form-signin-heading">Please sign in</h2>
        <label for="user" class="sr-only">Email address</label>
        <asp:TextBox ID="user" PlaceHolder="Usuario" runat="server" type="text" class="form-control" required autofocus></asp:TextBox>
        <label for="pass" class="sr-only">Password</label>
        <asp:TextBox ID="pass" PlaceHolder="Contraseña" runat="server" type="password" class="form-control" required ></asp:TextBox>
        <div class="checkbox">
          <label>
            <input type="checkbox" value="remember-me"> Remember me
          </label>
        </div>
        <asp:Button ID="btnAceptar" runat="server" Text="Sign in" 
            class="btn btn-lg btn-primary btn-block" type="submit" 
            onclick="btnAceptar_Click"/>       
      </form>
    </div> <!-- /container -->
    </form>
    <!-- IE10 viewport hack for Surface/desktop Windows 8 bug -->
    <script src="js/ie10-viewport-bug-workaround.js"></script>
  </body>
</html>
