<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Posledna.aspx.cs" Inherits="FAKS.Posledna" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-4">
                <div class="m-4">
                    Име: <asp:Label ID="lblIme" runat="server" Text="Label"></asp:Label><br /> 
                    Презиме: <asp:Label ID="lblPrezime" runat="server" Text="Label"></asp:Label><br />
                    E-mail: <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label><br />
                    Телефонски број:<asp:Label ID="lblBroj" runat="server" Text="Label"></asp:Label> <br />

                    Листа од сите положени предмети:<asp:Label ID="lblPredmeti" runat="server" Text="Label"></asp:Label><br /> 
                    
                    Вкупен број на кредити:<asp:Label ID="lblKrediti" runat="server" Text="Label"></asp:Label><br />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
