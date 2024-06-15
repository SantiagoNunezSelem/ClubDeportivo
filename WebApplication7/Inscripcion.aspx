<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inscripcion.aspx.cs" Inherits="WebApplication7.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title">Inscripción</h2>
        <section>
                Inscripción en una actividad deportiva
                <span>Seleccione una actividad de las disponibles</span>
                <div>
                    <asp:DropDownList ID="ddlDeportes" runat="server"></asp:DropDownList>
                    <asp:Button ID="btnSubmit" runat="server" Text="Registrar" OnClick="inscripcionDeActividad" />
                    <asp:Label ID="lblSelectedValue" runat="server"></asp:Label>
                </div>
                
                <asp:Label ID="success" runat="server"></asp:Label>
        </section>
    </main>
</asp:Content>
