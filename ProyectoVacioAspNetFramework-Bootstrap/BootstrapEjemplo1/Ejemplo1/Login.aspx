<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Ejemplo1.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-2"></div>
        <div class="col">
            <div class="mb-3">
                <label for="exampleInputEmail1" class="form-label">Email address</label>
                <asp:TextBox runat="server" ID="txtEmail" type="email" CssClass="form-control"/>
            </div>
            <div class="mb-3">
                <label for="exampleInputPassword1" class="form-label">Password</label>
                <asp:TextBox runat="server" ID="txtPassword" type="password" CssClass="form-control"/>
            </div>
            <asp:Button Text="Ingresar" CssClass="btn btn-primary" ID="btnAceptar" OnClick="btnAceptar_Click" runat="server" />
        </div>
        <div class="col-2"></div>
    </div>
</asp:Content>
