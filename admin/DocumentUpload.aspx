<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DocumentUpload.aspx.cs" Inherits="HR_Management_System.DocumentUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
     <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Sign Up Form by Colorlib</title>

    <!-- Font Icon -->
    
    <link href="../DocumentUpload/fonts/material-icon/css/material-design-iconic-font.min.css" rel="stylesheet" />

    <!-- Main css -->
   
    <link href="../DocumentUpload/css/style.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
       <div class="main">
        <div class="container">
            <div class="signup-content">
                <div class="signup-img">
                    <%--<img src="~/DocumentUpload/images/signup-img.jpg" alt="">--%>
                    <img src="../DocumentUpload/images/signup-img.jpg" />
                </div>
                <div class="signup-form">
                    <form method="POST" class="register-form" id="register-form">
                        <h2>student registration form</h2>
                        <div class="form-row">
                            <div class="form-group">
                                <label for="name">First Name :</label>
                                <asp:TextBox ID="txt_nm" runat="server"></asp:TextBox>
                              

                            </div>
                            <div class="form-group">
                                <label for="father_name">Last Name :</label>
                                <asp:TextBox ID="txt_lnm" runat="server"></asp:TextBox>
                                 
                            </div>
                        </div>
                          <div class="form-row">
                            <div class="form-group">
                                <label for="name">Date of Birth :</label>
                                <asp:TextBox ID="txt_dob" runat="server"></asp:TextBox>
                              

                            </div>
                            <div class="form-group">
                                <label for="father_name">Photo :</label>
                                <asp:FileUpload ID="filephoto" runat="server" Font-Size="Smaller" />
                                 
                            </div>
                        </div>
                         <div class="form-row">
                            <div class="form-group">
                                <label for="name">Gender :</label>
                                
                                <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem Value="0">-Select-</asp:ListItem>
                                    <asp:ListItem>Male</asp:ListItem>
                                    <asp:ListItem>Female</asp:ListItem>
                                         </asp:DropDownList>
                               

                            </div>
                            <div class="form-group">
                                <label for="father_name">Email :</label>
                             <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
                                 
                            </div>
                        </div>
                         <div class="form-row">
                            <div class="form-group">
                                <label for="name">10th Marksheet :</label>
                              <asp:FileUpload ID="file10th" runat="server" Font-Size="Smaller" />
                              

                            </div>
                            <div class="form-group">
                                <label for="father_name">12th Marksheet:</label>
                                <asp:FileUpload ID="file12th" runat="server" Font-Size="Smaller" />
                                 
                            </div>
                        </div>
                         <div class="form-row">
                            <div class="form-group">
                                <label for="name">Graduation Marksheet(Last Year):</label>
                            <asp:FileUpload ID="fileGraduation" runat="server" Font-Size="Smaller" />
                              

                            </div>
                            <div class="form-group">
                                <label for="father_name">Degree Certificate :</label>
                                <asp:FileUpload ID="fileDegree" runat="server" Font-Size="Smaller" />
                                 
                            </div>
                        </div>
                         <div class="form-row">
                            <div class="form-group">
                                <label for="name">Post Graduation Marksheet(if any) :</label>
                                <asp:FileUpload ID="FilePostGraduation" runat="server" Font-Size="Smaller" />
                              

                            </div>
                            <div class="form-group">
                                <label for="father_name">Aadhar card :</label>
                                <asp:FileUpload ID="Fileaadhar" runat="server" Font-Size="Smaller" />
                                 
                            </div>
                        </div>
                         <div class="form-row">
                            <div class="form-group">
                                <label for="name">Pan card:</label>
                                <asp:FileUpload ID="filePancard" runat="server" Font-Size="Smaller" />
                              

                            </div>
                            <div class="form-group">
                                <label for="father_name">Bank Passbook :</label>
                                <asp:FileUpload ID="fileBankpass" runat="server" Font-Size="Smaller" />
                                 
                            </div>
                        </div>
                        <div class="form-submit">
                           <%-- <input type="submit" value="Reset All" class="submit" name="reset" id="reset" />
                            <input type="submit" value="Submit Form" class="submit" name="submit" id="submit" />--%>

                            <asp:Button ID="btn_sub" runat="server" Text="Submit" CssClass="submit" OnClick="btn_sub_Click"/>
                        </div>
                    </form>
                </div>
            </div>
        </div>

    </div>

    <!-- JS -->
    
        <script src="../DocumentUpload/vendor/jquery/jquery.min.js"></script>
   
        <script src="../DocumentUpload/js/main.js"></script>
    
    </form>
</body>
</html>
