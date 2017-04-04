<%@ Page Language="C#" MasterPageFile="~/Site.master" CodeFile="Gallery.aspx.cs" Inherits="Gallery" %>

<asp:Content ID="headContent" ContentPlaceHolderID="head" runat="Server">
    <link href="Content/bootstrap.css" type="text/css" rel="stylesheet" />
    <style type="text/css">
        table, th, td {
            border: 1px dotted black;
        }

        .table-wrapper {
            position: relative;
        }

        .table-scroll {
            height: 300px;
            overflow: auto;
            margin-top: 20px;
        }

        .table-wrapper table {
            width: 100%;
        }

            .table-wrapper table * {
                color: black;
            }

            .table-wrapper table thead th .text {
                position: absolute;
                top: -20px;
                z-index: 2;
                height: 20px;
                width: 35%;
                border: 1px solid red;
            }
    </style>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server" />

    <h2 class="DDSubHeader">Gallery Manager</h2>
    <div class="row">
        <div class="col-md-6">
            <asp:Button runat="server" ID="Button1" CssClass="btn btn-default"
                OnClick="btnCreateContainers_OnClick" Text="Create Movie Containers" />
        </div>
        <div class="col-md-6">
            <asp:Button runat="server" ID="btnSyncMoviePhotos" CssClass="btn btn-default"
                OnClick="btnSyncMoviePhotos_OnClick" Text="Sync Movie Photos" />

        </div>
    </div>

    <div class="row" style="">
        <div class="col-md-3" style="margin-left: 20px; border: 2px">
            <div class="table-wrapper">
                <div class="table-scroll">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server"
                        OnSelectedIndexChanged="MovieSelectionChanged" DataTextField="DisplayName"
                        DataValueField="MovieId" AutoPostBack="True" />
                </div>
            </div>

        </div>
        <div class="col-md-3" style="border: 1px dotted black; border-radius: 5px; margin-top: 30px">
            <asp:Label runat="server" ID="lblSelectedMovie"></asp:Label>
            <br/>
            <div class="table-wrapper">
                <div class="table-scroll">
                    <asp:CheckBoxList runat="server"  ID="CheckBoxList1"  />
                </div>
            </div>
            <br />
            <asp:Button Text="Delete Selected Files" runat="server" 
                CssClass="btn btn-default"
                ID="btnDeleteSelectedFiles" OnClick="btnDeleteSelectedFiles_OnClick"/>
        </div>
        <div class="col-md-3" style="margin-top: 30px">
            <asp:FileUpload runat="server" ID="FileUpload1" AllowMultiple="True" />
            <br />
            <asp:Button CssClass="btn btn-default" runat="server" ID="btnUpload" OnClick="UploadClick" Text="Upload" />
        </div>
    </div>


</asp:Content>


