<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FinalProjectFuerte.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fuerte Final Project</title>
    <style>
        .container 
        {
            align-content: center;
            text-align:center;
        }
        .display-2 
        {
        font-family:"Montserrat" 
        }
   </style>

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"/>
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1 class="display-2">Team Fuerte</h1>
            <p class="h5"><u>Team members: Amadou Toure, Flip Gill, Manny Rosa, Noah Owens</u></p>
            <asp:Button ID="ClearButton" class="btn btn-danger" runat="server" Text="Clear" OnClick="ClearButton_Click" />
            <asp:Button ID="LeetCodeButton01" class="btn btn-primary" runat="server" Text="Solution01" OnClick="LeetCodeButton01_Click" />
            <asp:Button ID="LeetCodeButton02" class="btn btn-primary" runat="server" Text="Solution02" />
            <asp:Button ID="LeetCodeButton03" class="btn btn-primary" runat="server" Text="Soultion03" />
            <asp:Button ID="LeetCodeButton04" class="btn btn-primary" runat="server" Text="Solution04" />
            <br /><br />
            <asp:Label ID="ProblemLabel" runat="server" Text="" EnableViewState="false"></asp:Label>
            <br /><br />
            <asp:Label ID="ResultLabel" runat="server" Text="" EnableViewState="false"></asp:Label>
        </div>
    </form>
</body>
</html>
