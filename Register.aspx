<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HR_Management_System.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>New account </title>
	<meta charset="UTF-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->	
	<link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
    <a href="Register/images/icons/favicon.ico"></a>
<!--===============================================================================================-->
	
    <link href="Register/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
<!--===============================================================================================-->
	
    <link href="Register/fonts/font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet" />
<!--===============================================================================================-->
	
    <link href="Register/fonts/Linearicons-Free-v1.0.0/icon-font.min.css" rel="stylesheet" />
<!--===============================================================================================-->
	
    <link href="Register/fonts/iconic/css/material-design-iconic-font.min.css" rel="stylesheet" />
<!--===============================================================================================-->
	
    <link href="Register/vendor/animate/animate.css" rel="stylesheet" />
<!--===============================================================================================-->	

    <link href="Register/vendor/css-hamburgers/hamburgers.min.css" rel="stylesheet" />
<!--===============================================================================================-->
	
    <link href="Register/vendor/animsition/css/animsition.min.css" rel="stylesheet" />
<!--===============================================================================================-->
	
    <link href="Register/vendor/select2/select2.min.css" rel="stylesheet" />
<!--===============================================================================================-->	

    <link href="Register/vendor/daterangepicker/daterangepicker.css" rel="stylesheet" />
<!--===============================================================================================-->
	
    <link href="Register/css/util.css" rel="stylesheet" />
	
    <link href="Register/css/main.css" rel="stylesheet" />
<!--===============================================================================================-->
</head>
<body style="background-color: #999999;">
    <form id="form1" runat="server">
        <div class="limiter">
		<div class="container-login100">
			<div class="login100-more" style="background-image: url('Register/images/bg-01.jpg');"></div>

			<div class="wrap-login100 p-l-50 p-r-50 p-t-72 p-b-50">
				<form class="login100-form validate-form">
					<span class="login100-form-title p-b-59">
						Sign Up
					</span>
					
					<div class="wrap-input100 validate-input" data-validate="Name is required">
						<span class="label-input100">Full Name</span>
						
                        <asp:TextBox ID="txt_nm" CssClass="input100" runat="server" placeholder="Name"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>
					

					<div class="wrap-input100 validate-input" data-validate="Name is required">
						<span class="label-input100">Gender</span>
						<table>
							<tr>
								<td><asp:RadioButton ID="RadioButton1" runat="server" CssClass="input100" RepeatDirection="Horizontal" GroupName="ML" Text="Male" Font-Size="Small" /></td>
								<td><asp:RadioButton ID="RadioButton2" runat="server" CssClass="input100" RepeatDirection="Horizontal" GroupName="ML" Text="Female" Font-Size="Small" /></td>
							</tr>
						</table>
                        
						
						<span class="focus-input100"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate = "Valid email is required: ex@abc.xyz">
						<span class="label-input100">Position of</span>
						 <asp:TextBox ID="txt_position" CssClass="input100" runat="server" placeholder="Position of"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate = "Valid email is required: ex@abc.xyz">
						<span class="label-input100">Work as</span>
                        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="input100" Font-Size="Smaller">
							
							<asp:ListItem>Intern</asp:ListItem>
							<asp:ListItem>Fulltime Employee</asp:ListItem>
                        </asp:DropDownList>
						
						<span class="focus-input100"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate="Username is required">
						<span class="label-input100">Start Date</span>
						 <asp:TextBox ID="txt_strdate" CssClass="input100" runat="server" placeholder="StartDate" TextMode="Date"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>
					<div class="wrap-input100 validate-input" data-validate="Username is required">
						<span class="label-input100">End Date</span>
						 <asp:TextBox ID="txt_enddate" CssClass="input100" runat="server" placeholder="End date" TextMode="Date"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>
					<div class="wrap-input100 validate-input" data-validate="Username is required">
						<span class="label-input100">Mobile</span>
						 <asp:TextBox ID="txt_mob" CssClass="input100" runat="server" placeholder="Mobile"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate = "Password is required">
						<span class="label-input100">Email</span>
						 <asp:TextBox ID="txt_email" CssClass="input100" runat="server" placeholder="Email"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate = "Repeat Password is required">
						<span class="label-input100">Address</span>
					 <asp:TextBox ID="txt_add" CssClass="input100" runat="server" placeholder="Address"></asp:TextBox>
						<span class="focus-input100"></span>
					</div>

					<div class="wrap-input100 validate-input" data-validate = "Repeat Password is required">
						<span class="label-input100">Upload Resume</span>
					 
                        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="input100" Font-Size="Small" />
						<span class="focus-input100"></span>
					</div>
					<%--<div class="wrap-input100 validate-input" data-validate = "Repeat Password is required">
						<span class="label-input100">Upload 10th</span>
					 
                        <asp:FileUpload ID="FileUpload2" runat="server" CssClass="input100" Font-Size="Small" />
						<span class="focus-input100"></span>
					</div>
					<div class="wrap-input100 validate-input" data-validate = "Repeat Password is required">
						<span class="label-input100">Upload 12th</span>
					 
                        <asp:FileUpload ID="FileUpload3" runat="server" CssClass="input100" Font-Size="Small" />
						<span class="focus-input100"></span>
					</div>
					<div class="wrap-input100 validate-input" data-validate = "Repeat Password is required">
						<span class="label-input100">Upload Graduation</span>
					 
                        <asp:FileUpload ID="FileUpload4" runat="server" CssClass="input100" Font-Size="Small" />
						<span class="focus-input100"></span>
					</div>
					<div class="wrap-input100 validate-input" data-validate = "Repeat Password is required">
						<span class="label-input100">Upload Aadharcard</span>
					 
                        <asp:FileUpload ID="FileUpload5" runat="server" CssClass="input100" Font-Size="Small" />
						<span class="focus-input100"></span>
					</div>
					<div class="wrap-input100 validate-input" data-validate = "Repeat Password is required">
						<span class="label-input100">Upload Photo</span>
					 
                        <asp:FileUpload ID="FileUpload6" runat="server" CssClass="input100" Font-Size="Small" />
						<span class="focus-input100"></span>
					</div>--%>

					<div class="flex-m w-full p-b-33">
						<div class="contact100-form-checkbox">
							<input class="input-checkbox100" id="ckb1" type="checkbox" name="remember-me">
							<label class="label-checkbox100" for="ckb1">
								<span class="txt1">
									I agree to the
									<a href="#" class="txt2 hov1">
										Terms of User
									</a>
								</span>
							</label>
						</div>

						
					</div>

					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							
                            <asp:Button ID="Button1" runat="server" Text="Sign Up" CssClass="login100-form-btn btn btn-success" OnClick="Button1_Click"/>
						</div>

						<a href="#" class="dis-block txt3 hov1 p-r-30 p-t-10 p-b-10 p-l-30">
							Sign in
							<i class="fa fa-long-arrow-right m-l-5"></i>
						</a>
					</div>
				</form>
			</div>
		</div>
	</div>
	
<!--===============================================================================================-->
	
        <script src="Register/vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	
        <script src="Register/vendor/animsition/js/animsition.min.js"></script>
<!--===============================================================================================-->
	
        <script src="Register/vendor/bootstrap/js/popper.js"></script>
	
        <script src="Register/vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	
        <script src="Register/vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	
        <script src="Register/vendor/daterangepicker/moment.min.js"></script>
	
        <script src="Register/vendor/daterangepicker/daterangepicker.js"></script>
<!--===============================================================================================-->
	
        <script src="Register/vendor/countdowntime/countdowntime.js"></script>
<!--===============================================================================================-->
	
        <script src="Register/js/main.js"></script>


    </form>
</body>
</html>
