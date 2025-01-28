<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/GuestMaster.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Guest_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
           

            
        }

        .login-container {
            max-width: 400px;
            min-width:400px;
            background-color: #fff;
            border: 1px solid #ddd;
            padding: 20px;
            border-radius: 5px;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
            padding:30px;
           
        }

        .login-container h2 {
            margin-bottom: 20px;
            text-align: center;
        }

        .form-group {
            margin-bottom: 20px;
        }

        .form-group label {
            font-weight: bold;
            display: block;
            margin-bottom: 5px;
        }

        .form-group input[type="text"],
        .form-group input[type="password"] {
            width: 100%;
            padding: 10px;
            border: 1px solid #ccc;
            border-radius: 3px;
            box-sizing: border-box;
        }

        .form-group .error-message {
            color: #00CC00;
            margin-top: 5px;
        }

        .form-group .forgot-password {
            margin-top: 10px;
            text-align: right;
        }

        .form-group .forgot-password a {
            color: #007bff;
            text-decoration: none;
        }

        .form-group .forgot-password a:hover {
            text-decoration: underline;
        }

        .form-group .btn-login {
            background-color: #007bff;
            color: #fff;
            border: none;
            padding: 10px 20px;
            border-radius: 3px;
            cursor: pointer;
        }

        .form-group .btn-login:hover {
            background-color: #0056b3;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" >
    <div style="padding:30px;display:flex;justify-content:center;">

 
    <div class="login-container">
        <h2>Login</h2>
        <div class="form-group">
            <label for="txtemail">Email/Username<span class="auto-style10">*</span></label>
            <asp:TextBox ID="txtemail" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="Enter username" CssClass="error-message"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <label for="txtpassword">Password<span class="auto-style10">*</span></label>
            <asp:TextBox ID="txtpassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpassword" ErrorMessage="Enter password" CssClass="error-message"></asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" CssClass="btn-login" />
        </div>
        <div class="form-group">
            <asp:Label ID="lblmsg" runat="server" CssClass="error-message"></asp:Label>
        </div>
        <div class="form-group forgot-password">
            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" OnClick="LinkButton1_Click1">Forgot password</asp:LinkButton>
        </div>
    </div>
           </div>
</asp:Content>
