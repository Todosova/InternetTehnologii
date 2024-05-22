<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="WebApplication.Najava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="m-4">
        <h1>Лабораториска вежба 1</h1>
        <div class="row">
            <div class="m-4">
                Име&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="name" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="RequiredName" runat="server" Text="Внесете име" Visible="false" ForeColor="Red"></asp:Label>
            </div>
            <div class="m-4">
                Лозинка&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="password" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="RequiredPassword" runat="server" Text="Внесете лозинка" Visible="false" ForeColor="Red"></asp:Label>

            </div>
            <div class="m-4">
                е-адреса&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="email" runat="server"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 <asp:Label ID="RequiredEmail" runat="server" Text="Невалиден формат" Visible="false" ForeColor="Red "></asp:Label>
            </div>
            <div class="m-4">
                <asp:Button ID="najavi" runat="server" Text="Најавете се" OnClick="najavi_Click" />
            </div
        </div>
     </div>   

    </div>
</asp:Content>
