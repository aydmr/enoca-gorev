<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Ara.aspx.cs" Inherits="EnocaDemo.Ara" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="card-body">
            <h4 class="card-title">Listele</h4>
            <!-- Nav tabs -->
            <div class="default-tab">
                <ul class="nav nav-tabs mb-3" role="tablist">
                    <li class="nav-item"><a class="nav-link active show" data-toggle="tab" href="#tarih">Tarih Aralığı İle</a>
                    </li>
                    <li class="nav-item"><a class="nav-link" data-toggle="tab" href="#film">Film Adı İle</a>
                    </li>
                    <li class="nav-item"><a class="nav-link" data-toggle="tab" href="#salon">Gösterim Salonu İle</a>
                    </li>
                </ul>
                <div class="tab-content">
                    <div class="tab-pane fade active show" id="tarih" role="tabpanel">
                        <div class="p-t-15">
                            <div style="padding-left: 1em;">
                                <asp:DropDownList ID="DropDownList1" runat="server" class='btn btn-sm btn-outline-secondary'></asp:DropDownList>
                                <b style="padding-right: 0.15em; padding-left: 0.15em;">-</b>
                                <asp:DropDownList ID="DropDownList2" runat="server" class='btn btn-sm btn-outline-secondary'></asp:DropDownList>

                                <asp:Button ID="Button1" class="btn mb-1 btn-secondary" runat="server" Text="Ara" OnClick="Button1_Click" />

                            </div>
                        </div>
                    </div>
                    <div class="tab-pane fade" id="film">
                        <div class="p-t-15">
                            <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="filmara"></asp:TextBox><b></b>
                            <asp:Button ID="Button2" class="btn mb-1 btn-secondary" runat="server" Text="Ara" OnClick="Button2_Click" ValidationGroup="filmara" />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Boş Bırakılamaz!" ControlToValidate="TextBox1" ValidationGroup="filmara" ForeColor="#990033"></asp:RequiredFieldValidator>
                            

                        </div>
                    </div>
                    <div class="tab-pane fade" id="salon">
                        <div class="p-t-15">
                            <asp:DropDownList ID="DropDownList3" runat="server" class='btn btn-sm btn-outline-secondary'></asp:DropDownList>

                            <asp:Button ID="Button3" class="btn mb-1 btn-secondary" runat="server" Text="Ara" OnClick="Button3_Click" />
                        </div>
                    </div>
                    <br/>
                    <asp:GridView ID="GridView1" class="dataTable-table" runat="server"></asp:GridView>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                </div>
            </div>
            <!--**********************************
    Scripts
    ***********************************-->
            <script src="plugins/common/common.min.js"></script>
            <script src="js/custom.min.js"></script>
            <script src="js/settings.js"></script>
            <script src="js/gleek.js"></script>
            <script src="js/styleSwitcher.js"></script>
    </form>
</asp:Content>
