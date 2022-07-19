<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Ekle.aspx.cs" Inherits="EnocaDemo.Ekle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div class="container-fluid px-4">
        <h1 class="mt-4">Film Ekle</h1>

        <div class="row">

            <div class="container-fluid">
                <div class="row">
                    <div class="col">
                        <div class="card">
                            <div class="card-body">
                                    <div class='form-group row'>
                                        <label class='col-sm-2 col-form-label'>Film Adı</label>
                                        <div class='col-auto'>
                                            <div class='col-sm-10'>
                                                <asp:TextBox ID="TextBox1" runat="server" class="form-control mb-2" placeholder="Babam ve Oğlum" ValidationGroup="filmkayit" ValidateRequestMode="Enabled" ControlToValidate="TextBox1" TextMode="SingleLine"></asp:TextBox>
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Boş bırakılamaz!" ControlToValidate="TextBox1" ForeColor="#990033" ValidationGroup="filmkayit"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                    </div>
                                    <div class='form-group row'>
                                        <label class='col-sm-2 col-form-label'>Film Yılı</label>
                                        <div class='col-auto'>
                                            <div class='col-sm-10'>
                                                <asp:DropDownList ID="DropDownList1" runat="server" class='btn btn-sm btn-outline-secondary' ValidationGroup="filmkayit"></asp:DropDownList>
                                            </div>
                                        </div>
                                    </div>
                                    <div class='form-group row'>
                                        <div class='col-auto'>
                                            <br />
                                            <asp:Button ID="Button1" runat="server" class="btn mb-2 btn-secondary" Text="EKLE" ValidationGroup="filmkayit" OnClick="Button1_Click" />
                                        </div>
                                    </div>
                            </div>
                            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</form>

</asp:Content>
