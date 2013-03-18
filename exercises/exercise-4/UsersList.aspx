<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UsersList.aspx.cs" Inherits="UsersList" MasterPageFile="~/MasterPage.master" %>

<asp:Content runat="server" ContentPlaceHolderID="head">
    <title>Списък на потребителите</title>
</asp:Content>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder">
    <asp:DataGrid runat="server" ID="UsersListGrid" CssClass="table table-striped" AutoGenerateColumns="false">
        <ItemStyle BorderWidth="0" />
        <Columns>
            <asp:TemplateColumn HeaderText="#">
                <ItemTemplate>
                    <asp:Label ID="label1" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="Потребителско име">
                <ItemTemplate>
                    <asp:Label ID="label1" runat="server" Text='<%# Bind("username") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="Парола (MD5 hash)">
                <ItemTemplate>
                    <asp:Label ID="label1" runat="server" Text='<%# Bind("password") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateColumn>
            <asp:TemplateColumn HeaderText="E-mail">
                <ItemTemplate>
                    <asp:Label ID="label1" runat="server" Text='<%# Bind("email") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateColumn>
        </Columns>
    </asp:DataGrid>
</asp:Content>