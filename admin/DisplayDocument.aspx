<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayDocument.aspx.cs" Inherits="HR_Management_System.admin.DisplayDocument" %>

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
       
        <div class="alert alert-dismissible alert-warning auto-style1" >
               
                    <h4 class="alert-heading">Employee Documents Details</h4>
                    
        </div>
        <div >
            <div style="overflow-x:auto;width:1365px" class="auto-style1" >
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-bordered table-hover table-responsive" DataKeyNames="Id" DataSourceID="SqlDataSource1" AllowPaging="True" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" >
                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:BoundField DataField="fname" HeaderText="First Name" SortExpression="fname" >
                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:BoundField DataField="lastname" HeaderText="Last Name" SortExpression="lastname" >
                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>

                    <asp:BoundField DataField="dob" HeaderText="Date of Birth" SortExpression="dob" >
                    
                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    
                    <asp:BoundField DataField="PhotoName" HeaderText="PhotoName" >
                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:BoundField DataField="PhotoType" HeaderText="PhotoType" >
                    
                   <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    
                    <asp:TemplateField HeaderText="Photo">
                        <ItemTemplate>
                            <asp:LinkButton ID="btn_photo" runat="server" OnClick="LinkButton1_Click" CommandArgument='<%# Eval("Id") %>'>Download</asp:LinkButton>
                        </ItemTemplate>
                       <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:TemplateField>
                    
                    <asp:BoundField DataField="gender" HeaderText="Gender" SortExpression="gender" >
                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:BoundField DataField="email" HeaderText="Email" SortExpression="email" >
                   <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:BoundField DataField="x10Name" HeaderText="10thName" SortExpression="x10Name" >
                   <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:BoundField DataField="X10Type" HeaderText="10thType" SortExpression="X10Type" >
                   <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="10th">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" CommandArgument='<%# Eval("Id") %>' >Download</asp:LinkButton>
                        </ItemTemplate>
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:TemplateField>
                    
                    <asp:BoundField DataField="x12Name" HeaderText="x12Name" SortExpression="x12Name" >
                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>

                    <asp:BoundField DataField="X12Type" HeaderText="X12Type" SortExpression="X12Type" >
                     <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>

                    <asp:TemplateField HeaderText="12th">
                        <ItemTemplate>
                            <asp:LinkButton ID="link_12th" runat="server" OnClick="link_12th_Click" CommandArgument='<%# Eval("Id") %>' >Download</asp:LinkButton>
                        </ItemTemplate>
                         <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    
                    </asp:TemplateField>
                    
                    <asp:BoundField DataField="GraName" HeaderText="GraName" SortExpression="GraName" >
                     <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>

                    <asp:BoundField DataField="GraType" HeaderText="GraType" SortExpression="GraType" >
                     <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="Graduation">
                        <ItemTemplate>
                            <asp:LinkButton ID="Link_Graduation" runat="server" OnClick="Link_Graduation_Click" CommandArgument='<%# Eval("Id") %>' >Download</asp:LinkButton>
                        </ItemTemplate>
                         <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    
                    </asp:TemplateField>
                    
                    <asp:BoundField DataField="DeeName" HeaderText="DeeName" SortExpression="DeeName" >
                     <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>

                    <asp:BoundField DataField="DeeType" HeaderText="DeeType" SortExpression="DeeType" >
                     <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>

                    <asp:TemplateField HeaderText="Degree">
                        <ItemTemplate>
                            <asp:LinkButton ID="link_degree" runat="server" OnClick="link_degree_Click" CommandArgument='<%# Eval("Id") %>' >Download</asp:LinkButton>
                        </ItemTemplate>
                         <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                   
                    </asp:TemplateField>
                    
                    <asp:BoundField DataField="PostName" HeaderText="PostName" SortExpression="PostName" >
                     <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>

                    <asp:BoundField DataField="PostType" HeaderText="PostType" SortExpression="PostType" >
                     <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>

                    <asp:TemplateField HeaderText="Post Graduation">
                        <ItemTemplate>
                            <asp:LinkButton ID="link_postgraduation" runat="server" OnClick="link_postgraduation_Click" CommandArgument='<%# Eval("Id") %>' >Download</asp:LinkButton>
                        </ItemTemplate>
                         <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    
                    </asp:TemplateField>
                   
                    <asp:BoundField DataField="AadharName" HeaderText="AadharName" SortExpression="AadharName" >
                     <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:BoundField DataField="AadharType" HeaderText="AadharType" SortExpression="AadharType" >
                     <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    
                    <asp:TemplateField HeaderText="Aadhar card">
                        <ItemTemplate>
                            <asp:LinkButton ID="link_aadharcard" runat="server" OnClick="link_aadharcard_Click" CommandArgument='<%# Eval("Id") %>' >Download</asp:LinkButton>
                        </ItemTemplate>
                         <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    
                    </asp:TemplateField>
                   
                    <asp:BoundField DataField="PanName" HeaderText="PanName" SortExpression="PanName" >
                     <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:BoundField DataField="PanType" HeaderText="PanType" SortExpression="PanType" >
                     <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="pancard">
                        <ItemTemplate>
                            <asp:LinkButton ID="link_pancard" runat="server" OnClick="link_pancard_Click" CommandArgument='<%# Eval("Id") %>' >Download</asp:LinkButton>
                        </ItemTemplate>
                         <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                   
                    </asp:TemplateField>
                   
                    <asp:BoundField DataField="BankName" HeaderText="BankName" SortExpression="BankName" >
                     <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:BoundField DataField="BankType" HeaderText="BankType" SortExpression="BankType" >
                     <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:TemplateField HeaderText="bankpass">
                        <ItemTemplate>
                            <asp:LinkButton ID="link_bankpass" runat="server" OnClick="link_bankpass_Click" CommandArgument='<%# Eval("Id") %>' >Download</asp:LinkButton>
                        </ItemTemplate>
                     <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                   
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
          </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:constr %>" ProviderName="<%$ ConnectionStrings:constr.ProviderName %>" SelectCommand="SELECT [Id], [fname], [lastname], [dob], [PhotoName], [PhotoType], [gender], [email], [x10Name], [X10Type], [x12Name], [X12Type], [GraName], [GraType], [DeeName], [DeeType], [PostName], [PostType], [AadharName], [AadharType], [PanName], [PanType], [BankName], [BankType] FROM [DocumentUpload]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
