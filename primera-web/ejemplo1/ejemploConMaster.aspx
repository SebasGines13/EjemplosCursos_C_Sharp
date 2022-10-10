<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ejemploConMaster.aspx.cs" Inherits="ejemplo1.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Ejemplo con Master</h1>
    <asp:TextBox ID="txtNombre" runat="server"/>
    <asp:Button ID="btnAceptar" runat="server" Text="Buscar" OnClick="btnAceptar_Click"/>
    <asp:Label ID="lblSaludo" Text="" runat="server" />
    <a href="About">About</a>
 </asp:Content>
