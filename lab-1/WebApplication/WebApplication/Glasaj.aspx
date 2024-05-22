<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="WebApplication.Glasaj" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="m-4">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/finki_52_1_2_1_62_0.png" />
        </div>
        <div class="m-4">
            <asp:Label ID="lblProfesor" runat="server" Text=" "></asp:Label>
        </div>
        <div class="m-4">
            <asp:ListBox ID="lbPredmeti" runat="server"  OnSelectedIndexChanged="lbPredmeti_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox> 
        &nbsp;&nbsp;&nbsp; <asp:ListBox ID="lbKrediti" runat="server" ></asp:ListBox>
        </div>
        <div class="m-4">
            <asp:Button ID="GlasajBtn" runat="server" Text="Гласај" OnClick="GlasajBtn_Click" />
        </div>

        <br />
        <hr />
        <div class="m-4">
            Предмет:
            <br />
            <asp:TextBox ID="Predmet" runat="server"></asp:TextBox>
        </div>
         <br />

         <div class="m-4">
             Кредити:
              <br />
            <asp:TextBox ID="Krediti" runat="server"></asp:TextBox>
        </div>
       <div class="m-2">
        <asp:Button ID="Dodadi" runat="server" Text="Додади" OnClick="Dodadi_Click" />
        </div>
    <div class="m-2">
        <asp:Button ID="Izbrishi" runat="server" Text="Избриши" OnClick="Izbrishi_Click" />
    </div>
    </div>
</asp:Content>
