<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="FAKS.Najava" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-12">
                <div class="m-4">
                    Име <asp:TextBox ID="name" runat="server" ></asp:TextBox>
                    <asp:RequiredFieldValidator 
                        class="text-danger"
                        ID="nameVal" 
                        runat="server" 
                        ErrorMessage="Внеси име"
                        ControlToValidate="name">
                    </asp:RequiredFieldValidator>
                </div>
                <div class="m-4">
                    Презиме <asp:TextBox ID="lastname" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator 
                     class="text-danger"
                     ID="lastnameVal" 
                     runat="server" 
                     ErrorMessage="Внеси презиме"
                     ControlToValidate="lastname">
                 </asp:RequiredFieldValidator>
                </div>
                <div class="m-4">
                    Корисничко име <asp:TextBox ID="username" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator 
                     class="text-danger"
                     ID="userVal" 
                     runat="server" 
                     ErrorMessage="Внеси корисничко име"
                     ControlToValidate="username">
                 </asp:RequiredFieldValidator>
                </div>
                <div class="m-4">
                    Лозинка  <asp:TextBox ID="password" runat="server"></asp:TextBox>
                 <asp:RequiredFieldValidator 
                     class="text-danger"
                     ID="passVal" 
                     runat="server" 
                     ErrorMessage="Внеси лозинка"
                     ControlToValidate="password">
                 </asp:RequiredFieldValidator>
                 <asp:RegularExpressionValidator 
                        class="text-danger"
                        ID="passCVal" 
                        runat="server" 
                        ErrorMessage="Невалидна должина за лозинка"
                        ControlToValidate="password"
                        ValidationExpression="\w{5,}">
                 </asp:RegularExpressionValidator>
                </div>
                <div class="m-4">
                    Телефонски број <asp:TextBox ID="phone" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator 
                        class="text-danger"
                        ID="phoneVal" 
                        runat="server" 
                        ErrorMessage="Внесете телефонски број"
                        ControlToValidate ="phone"
                        ></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator 
                        class="text-danger"
                        ID="phoneCVal" 
                        runat="server" 
                        ErrorMessage="Не валидна форма за телефонски број" 
                        ValidationExpression="\+389 7[0125678] \d{3} \d{3}" 
                        ControlToValidate="phone">

                    </asp:RegularExpressionValidator>
                </div>
                <div class="m-4">
                    E-mail <asp:TextBox ID="email" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator 
                        class="text-danger"
                        ID="emailVal" 
                        runat="server" 
                        ErrorMessage="Внесете е-mail"
                        ControlToValidate ="email"
                        ></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator 
                        class="text-danger"
                        ID="emailCVal" 
                        runat="server" 
                        ErrorMessage="Не валидна форма за email" 
                        ValidationExpression="\S+@\S+\.\S+"
                        ControlToValidate="email">
                    </asp:RegularExpressionValidator>
                </div>
                <div class="m-4">
                    <asp:Button ID="Najavise" runat="server" Text="Најави се!" OnClick="Najavise_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
