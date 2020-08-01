<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="UploadMultiplos.Upload" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title>Upload de múltiplos arquivos com jQuery em Asp.Net</title>

        <!--Jquery-->
        <script src="Scripts/jquery-1.3.2.js" type="text/javascript"></script>
        <script src="Scripts/jquery.MultiFile.js" type="text/javascript"></script>
        <!--Jquery-->

        <!--CSS-->
        <link rel="Stylesheet" type="text/css" href="Scripts/UploadMultiplos.css" />
        <!--CSS-->

    </head>
    <body>
        <form name="FUpload" runat="server">
            <asp:fileupload ID="fuArquivos" CssClass="multi" runat="server"></asp:fileupload>
            <br />
            <asp:Button ID="btnUpload" runat="server" Text="Upload" onclick="btnUpload_Click" />
        </form>
    </body>
</html>
