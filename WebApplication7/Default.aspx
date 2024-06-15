<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication7._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <link rel="stylesheet" href="Default.css">
    <main>
    
        <div class="container_login">
            <div class="login-box">
                <h2>Login</h2>
                <asp:TextBox ID="TextBoxID" runat="server" placeholder="Id de socio"></asp:TextBox>
                <asp:TextBox ID="TextBoxDNI" runat="server" placeholder="DNI de socio" ></asp:TextBox>
            </div>
            <div class="info-box">
                <h2>Actividades ofrecidas</h2>
                <ul>
                    <li>Natación</li>
                    <li>Voley</li>
                    <li>Fútbol</li>
                </ul>
            </div>
        </div>



        <section>
            <asp:Button 
                ID="ButSelec1" 
                runat="server" 
                onclick="onLogin"  
                class="btn" 
                Text="Iniciar Sesión" 
            />

            <asp:Label ID="LabelAp" runat="server"></asp:Label>
        </section>
    </main>

</asp:Content>
