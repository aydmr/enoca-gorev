<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Güncelle.aspx.cs" Inherits="EnocaDemo.Güncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="container-fluid px-4">
            <h1 class="mt-4">Film Bilgisi Güncelle</h1>

            <div class="row">

                <div class="container-fluid">
                    <div class="row">
                        <div class="col">
                            <div class="card">
                                <h6 style="padding-left: 1em" class="mt-4">Film Bilgisi Güncellemek İçin Ara</h6>
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

                <div style="padding-top: 1em;" id="güncellediv" runat="server">
                    <div class="row">
                        <div class="col">
                            <div class="card">
                                <div class="card-body">
                                    <div class='form-group row'>
                                        <label class='col-sm-2 col-form-label'>Film Adı</label>
                                        <div class='col-auto'>
                                            <div class='col-sm-10'>
                                                <asp:TextBox ID="TextBox2" runat="server" class="form-control mb-2" placeholder="Babam ve Oğlum" ValidationGroup="filmkayit" ValidateRequestMode="Enabled" ControlToValidate="TextBox1" TextMode="SingleLine"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Boş bırakılamaz!" ControlToValidate="TextBox2" ForeColor="#990033" ValidationGroup="filmkayit"></asp:RequiredFieldValidator>

                                            </div>
                                        </div>
                                        <div class='form-group row'>
                                            <label class='col-sm-2 col-form-label'>Film Yılı</label>
                                            <div class='col-auto'>
                                                <div class='col-sm-10'>
                                                    <asp:DropDownList ID="DropDownList1" runat="server" class='btn btn-sm btn-outline-secondary' ValidationGroup="filmkayit"></asp:DropDownList>
                                                    <br />
                                                    <br />
                                                    <div style="padding-left: 2em">
                                                        <asp:Button Style="padding-left: 2em; padding-right: 2em;" ID="Button2" runat="server" class="btn mb-2 btn-secondary" Text="GÜNCELLE" ValidationGroup="filmkayit" OnClick="Button2_Click" />
                                                    </div>
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
