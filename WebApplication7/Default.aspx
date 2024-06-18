<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication7._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <link rel="stylesheet" href="Default.css">
    <main>
    
        <div class="container_login">
            <div class="login-box">
                <h2>Login</h2>
                <asp:TextBox ID="TextBoxID" runat="server" placeholder="Id de socio"></asp:TextBox>
                <asp:TextBox ID="TextBoxDNI" runat="server" style="margin-top: 10px;" placeholder="DNI de socio" ></asp:TextBox>
            </div>
            <div class="info-box">
                  <asp:Button 
                      ID="ButSelec1" 
                      runat="server" 
                      onclick="onLogin"  
                      class="btn" 
                      Text="Iniciar Sesión" 
                  /> 
                
                <a class="btn" style="width: 78%; margin-top: 1rem;" href="Actividades.aspx">Actividades ofrecidas</a>
            </div>
        </div>

        <section>
          

            <br />
            <asp:Label ID="LabelAp" runat="server"></asp:Label>
        </section>
    </main>

</asp:Content>
