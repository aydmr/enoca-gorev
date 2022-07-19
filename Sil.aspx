<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Sil.aspx.cs" Inherits="EnocaDemo.Sil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <form id="form1" runat="server">
        <div class="container-fluid px-4">
            <h1 class="mt-4">Film Sil</h1>

            <div class="row">

                <div class="container-fluid">
                    <div class="row">
                        <div class="col">
                            <div class="card">
                                <h6 style="padding-left: 1em" class="mt-4">Filmi Listeden Silmek İçin Ara</h6>
                                <div class="card-body">
                                    <div class='form-group row'>
                                        <label class='col-sm-2 col-form-label'>Film Adı</label>
                                        <div class='col-auto'>
                                            <div class='col-sm-10'>
                                                <asp:TextBox ID="TextBox1" runat="server" class="form-control mb-2" placeholder="Babam ve Oğlum" ValidationGroup="filmarama" ValidateRequestMode="Enabled" ControlToValidate="TextBox1" TextMode="SingleLine"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Boş bırakılamaz!" ControlToValidate="TextBox1" ForeColor="#990033" ValidationGroup="filmarama"></asp:RequiredFieldValidator>
                                                <div style="padding-left: 2em">
                                                    <asp:Button Style="padding-left: 2em; padding-right: 2em;" ID="Button1" runat="server" class="btn mb-2 btn-secondary" Text="ARA" ValidationGroup="filmarama" OnClick="Button1_Click" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class='form-group row'>
                                        <div class='col-auto'>
                                        </div>
                                    </div>
                                </div>
                                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                            </div>
                        </div>
                    </div>
                </div>

                <div style="padding-top: 1em;" id="sildiv" runat="server">
                    <div class="row">
                        <div class="col">
                            <div class="card">
                                <div class="card-body">
                                    <div class='form-group row'>
                                        <label class='col-sm-2 col-form-label'>Film Adı</label>
                                        <div class='col-auto'>
                                            <asp:Label ID="filmAd" runat="server" Text="" class="form-control mb-2"></asp:Label>
                                        </div>
                                        <div class='form-group row'>
                                            <label class='col-sm-2 col-form-label'>Film ID</label>
                                            <div class='col-auto'>
                                                <asp:Label ID="filmID" runat="server" Text="" class="form-control mb-2"></asp:Label>
                                            </div>
                                        <div class='form-group row'>
                                            <label class='col-sm-2 col-form-label'>Film Yılı</label>
                                            <div class='col-auto'>
                                                    <asp:Label ID="filmYapimYil" runat="server" Text="" class="form-control mb-2"></asp:Label>
                                                    <br />
                                                    <br />
                                                    <div style="padding-left: 2em">
                                                        <asp:Button Style="padding-left: 2em; padding-right: 2em;" ID="Button2" runat="server" class="btn btn-warning btn sweet-confirm" Text="SİL" ValidationGroup="filmkayit" OnClick="Button2_Click" />
                                                    </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class='form-group row'>
                                        <div class='col-auto'>
                                        </div>
                                    </div>
                                </div>
                                <asp:Literal ID="Literal2" runat="server"></asp:Literal>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </form>

</asp:Content>
