<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Predmeti.aspx.cs" Inherits="FAKS.Predmeti" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-12">
                <div class="m-4">
                    <asp:Label ID="naslov" runat="server" Text="(none)"></asp:Label>
                </div>
                <div class="m-4">
                    <asp:ListBox ID="Predmeti1" runat="server" OnSelectedIndexChanged="Predmeti_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ListBox ID="Krediti" runat="server"></asp:ListBox>
                </div>
                <div class="m-4">
                    <asp:Label ID="totalID" runat="server" Text="0"></asp:Label>
                </div>
                <div class="m-4">
                    <asp:Button ID="polozen" runat="server" Text="Положен" OnClick="polozen_Click" />
                </div>
                
                <div class="m-4">
                   Предмет: <asp:TextBox ID="dodadiPredmet" runat="server"></asp:TextBox>
                </div>
                <div class="m-4">
                   Кредит: <asp:TextBox ID="dodadiKredit" runat="server"></asp:TextBox>
                </div>
                <div class="m-4">
                    <asp:Button ID="Dodadi" runat="server" Text="Додади" OnClick="Dodadi_Click" />
                </div>
                <div class="m-4">
                    <asp:Button ID="Izbrishi" runat="server" Text="Избриши" OnClick="Izbrishi_Click" />
                </div>

                 <div class="m-4">
                    Положени: <asp:ListBox ID="polozeni" runat="server" AutoPostBack="True"></asp:ListBox>
                 </div>

                   <div class="m-4">
                    <asp:Button ID="Done" runat="server" Text="Завршено!" OnClick="Done_Click" />
                </div>
            </div>
                 
            </div>
        </div>

</asp:Content>
