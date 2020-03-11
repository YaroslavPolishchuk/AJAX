<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormHR.aspx.cs" Inherits="WebApplication1.WebFormHR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous" />
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js" integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>


</head>
<body>
    <div class="container">
        <form id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <div class="row">
                <div class="col-2">
                    <asp:DropDownList ID="ddlHR" runat="server" DataSourceID="dbHR" DataTextField="FirstName" DataValueField="EmployeeId"></asp:DropDownList>
                </div>
                <div class="col-2">
                    <asp:DropDownList ID="ddlMethods" runat="server"></asp:DropDownList>
                </div>
                <input type="button" id="start" value="Start" />
            </div>
            <asp:SqlDataSource ID="dbHR" runat="server" ConnectionString="<%$ ConnectionStrings:HR_Context %>" SelectCommand="SELECT [EmployeeId], [FirstName], [LastName] FROM [Employee]"></asp:SqlDataSource>
            <div id="result"></div>
        </form>
    </div>
    <script type="text/javascript" src="<%=ResolveUrl("JS_Methods/MethodsSource.js")%>"></script>
    <script type="text/javascript">
        $(function () {
            $("#start").click(() => {
                let id = $('[id$=ddlHR]')[0].value;
                let methodID = $('[id$=ddlMethods]')[0].value;                                
                let element = $("#result");
                upload(id, methodID,element);
            })
        })

    </script>


</body>
</html>
