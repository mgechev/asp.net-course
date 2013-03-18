<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" MasterPageFile="~/MasterPage.master" %>

<asp:Content runat="server" ContentPlaceHolderID="head">
    <title>Регистрация</title>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder">
    <div runat="server" id="ResponseLabel" style="height: 50px;"></div>
    <table class="table" runat="server" id="RegisterForm">
        <tr>
            <td>Потребителско име</td>
            <td><input type="text" id="UsernameInput" runat="server" /></td>
        </tr>
        <tr>
            <td>Парола</td>
            <td><input type="password" id="PasswordInput" runat="server" /></td>
        </tr>
        <tr>
            <td>Повторете паролата</td>
            <td><input type="password" id="Password2Input" runat="server" /></td>
        </tr>
        <tr>
            <td>E-mail</td>
            <td><input type="text" id="EmailInput" runat="server" /></td>
        </tr>
        <tr>
            <td colspan="2"><button class="btn" runat="server" id="RegisterButton">Регистрирай ме</button></td>
        </tr>
    </table>
</asp:Content>