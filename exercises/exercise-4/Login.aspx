<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" MasterPageFile="~/MasterPage.master" %>

<asp:Content ContentPlaceHolderID="head" runat="server">
    <title>Логин</title>
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div runat="server" id="ResponseLabel" style="height: 40px;"></div>
    <table class="table" runat="server" id="LoginForm"> 
        <tr>
            <td>Потребител</td>
            <td><input type="text" runat="server" id="UsernameInput" /></td>
        </tr>
        <tr>
            <td>Парола</td>
            <td><input type="password" runat="server" id="PasswordInput" /></td>
        </tr>
        <tr>
            <td colspan="2">
                <button id="LoginBtn" runat="server" class="btn">Влез</button>
            </td>
        </tr>
    </table>
</asp:Content>