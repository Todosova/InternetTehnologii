<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Godina.aspx.cs" Inherits="FAKS.Godina" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-12">
                <div class="m-4">
                    <asp:LinkButton ID="prva" runat="server" OnClick="prva_Click">Прва година</asp:LinkButton>
                </div>
                <div class="m-4">
                    <asp:LinkButton ID="vtora" runat="server" OnClick="vtora_Click">Втора година</asp:LinkButton>
                </div>
                <div class="m-4">
                    <asp:LinkButton ID="treta" runat="server" OnClick="treta_Click">Трета година</asp:LinkButton>
                </div>
                <div class="m-4">
                    <asp:LinkButton ID="chetvrta" runat="server" OnClick="chetvrta_Click">Четврта година</asp:LinkButton>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
