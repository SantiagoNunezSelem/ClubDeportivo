<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Panel.aspx.cs" Inherits="WebApplication7.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title">Usted se encuentra inscripto es las siguientes actividades</h2>
        <center>
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
        </center>
        <hr />
        <p>¿Quiere inscribirse en una nueva actividad?</p> <a href="Inscripcion.aspx">Cliquee aquí</a>
    </main>
</asp:Content>