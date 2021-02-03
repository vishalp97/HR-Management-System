<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HR_Management_System.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HR Management System</title>
	 <meta charset="UTF-8">

	<meta name="viewport" content="width=device-width, initial-scale=1">
<!--===============================================================================================-->	
	
    <link rel="icon" type="image/png" href="images/icons/favicon.ico"/>
<!--===============================================================================================-->
	
    <link href="Login/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
<!--===============================================================================================-->
	
    <link href="Login/fonts/font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet" />
<!--===============================================================================================-->
	
    <link href="Login/vendor/animate/animate.css" rel="stylesheet" />
<!--===============================================================================================-->	
	
    <link href="Login/vendor/css-hamburgers/hamburgers.min.css" rel="stylesheet" />
<!--===============================================================================================-->
	
    <link href="Login/vendor/select2/select2.min.css" rel="stylesheet" />
<!--===============================================================================================-->
	
    <link href="Login/css/main.css" rel="stylesheet" />
	
    <link href="Login/css/util.css" rel="stylesheet" />
<!--===============================================================================================-->

</head>
<body>
    <form id="form1" runat="server">

        <div class="limiter">
		<div class="container-login100">
			<div class="wrap-login100">
				

				<form class="login100-form validate-form">
					<span class="login100-form-title">
						Member Login
					</span>

					<div class="wrap-input100 validate-input" data-validate = "Valid email is required: ex@abc.xyz">
						<%--<input class="input100" type="text" name="email" placeholder="Email">--%>
                        <asp:TextBox ID="txt_unm" CssClass="input100" runat="server" placeholder="Email" required=""></asp:TextBox>

						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-envelope" aria-hidden="true"></i>
						</span>
					</div>

					<div class="wrap-input100 validate-input" data-validate = "Password is required">
						<%--<input class="input100" type="password" name="pass" placeholder="Password">--%>
						<asp:TextBox ID="txt_pas" CssClass="input100" runat="server" placeholder="Password" required="" TextMode="Password"></asp:TextBox>
						<span class="focus-input100"></span>
						<span class="symbol-input100">
							<i class="fa fa-lock" aria-hidden="true"></i>
						</span>
					</div>
					
					<div class="container-login100-form-btn">
						
                        <asp:Button ID="btn_login" runat="server" Text="Login" CssClass="login100-form-btn fa-hand-o-up" OnClick="btn_login_Click" />

					</div>

					<div class="text-center p-t-12">
						<span class="txt1">
							Forgot
						</span>
						<a class="txt2" href="#">
							Username / Password?
						</a>
					</div>

					<div class="text-center p-t-136">
						<a class="txt2" href="#">
							Create your Account
							<i class="fa fa-long-arrow-right m-l-5" aria-hidden="true"></i>
						</a>
					</div>
				</form>
			</div>
		</div>
	</div>
	
	

	
<!--===============================================================================================-->	
	
        <script src="Login/vendor/jquery/jquery-3.2.1.min.js"></script>
<!--===============================================================================================-->
	
        <script src="Login/vendor/bootstrap/js/popper.js"></script>
	
        <script src="Login/vendor/bootstrap/js/bootstrap.min.js"></script>
<!--===============================================================================================-->
	
        <script src="Login/vendor/select2/select2.min.js"></script>
<!--===============================================================================================-->
	
        <script src="Login/vendor/tilt/tilt.jquery.min.js"></script>

	<script >
		$('.js-tilt').tilt({
			scale: 1.1
		})
    </script>
<!--===============================================================================================-->
	<script src="js/main.js"></script>


    </form>

</body>
</html>
