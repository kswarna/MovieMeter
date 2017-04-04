<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Image_Edit.ascx.cs" Inherits="DynamicData_FieldTemplates_Image_Edit" %>

<asp:Image runat="server" ID="Image1" Width="200px" Height="200px"/>
<asp:FileUpload runat="server" ID="ImageFileUpload1" AllowMultiple="False"/>
<asp:Button runat="server" ID="btnUpload" Text="Upload" OnClick="btnUpload_OnClick"/>