<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="HR_Management_System.admin.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/5.0.0-alpha2/css/bootstrap.min.css">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover table-responsive" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource2" ForeColor="Black" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" DataKeyNames="Id" GridLines="Vertical">  
            <AlternatingRowStyle BackColor="#CCCCCC" />
    <Columns>  
        <asp:TemplateField HeaderText="SENT MAIL TO ">
            <ItemTemplate>
                <asp:CheckBox ID="chkSelect" runat="server" />
            </ItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" InsertVisible="False" ReadOnly="True" />  
            <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
        <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender" />
        <asp:BoundField DataField="Position" HeaderText="Position" SortExpression="Position" />
        <asp:BoundField DataField="Work_as" HeaderText="Work_as" SortExpression="Work_as"  />
        <asp:BoundField DataField="Start_Date" HeaderText="Start_Date" SortExpression="Start_Date" DataFormatString="{0:dd/MM/yyyy}" />
        <asp:BoundField DataField="End_Date" HeaderText="End_Date" SortExpression="End_Date" DataFormatString="{0:dd/MM/yyyy}" />
        <asp:BoundField DataField="Mobile" HeaderText="Mobile" SortExpression="Mobile" />
        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
        <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
        <asp:BoundField DataField="Resume" HeaderText="Resume" SortExpression="Resume" />
        </Columns>  
            <EmptyDataTemplate>
                <asp:LinkButton ID="LinkButton1" runat="server">Download</asp:LinkButton>
            </EmptyDataTemplate>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle CssClass="table table-striped table-bordered table-hover table-responsive" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
</asp:GridView>
        <asp:Button ID="btn_sent" runat="server" OnClick="btn_sent_Click" Text="Sent" CssClass="btn btn-primary btn-lg btn-block"/>
        <br />
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:constr %>" ProviderName="<%$ ConnectionStrings:constr.ProviderName %>" SelectCommand="SELECT [Id], [Name], [Gender], [Position], [Work_as], [Start_Date], [End_Date], [Mobile], [Email], [Address], [Resume] FROM [Register]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:constr %>" ProviderName="<%$ ConnectionStrings:constr.ProviderName %>" SelectCommand="SELECT [Name], [Gender], [Position], [Work_as], [Start_Date], [End_Date], [Mobile], [Email], [Address], [Resume] FROM [Register]"></asp:SqlDataSource>




        


    </form>
</body>
</html>
