<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bootstrapTest.aspx.cs" Inherits="niaps_ver_1._0.bootstrapTest" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <meta name = "viewport" content = "width=device-width, initial-scale=1.0"/>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <div class = "navbar navbar-inverse navbar-static-top">
		<div class="container">
		
		<a class = "navbar-brand">Monitoring + Evaluation</a>
		
		<button type = "button" class = "navbar-toggle" data-toggle = "collapse" data-target = ".navbar-collapse">
				<span class="sr-only">Toggle navigation</span>
				<span class = "icon-bar"></span>
				<span class = "icon-bar"></span>
				<span class = "icon-bar"></span>
		</button>
		<div class = "navbar-collapse collapse">
			<ul class = "nav navbar-nav navbar-right">
			
			<li class = "active"><a href = "#">Home</a></li>
			<li><a href = "#">indicator</a></li>
			<li class = "dropdown">
			<a href = "#" class = "dropdown-toggle" data-toggle = "dropdown">User<b class = "caret"></b></a> 
			<ul class = "dropdown-menu">
				<li><a href = "#">Add User</a></li>
				<li><a href = "#">Add user Role</a></li>
				<li><a href = "#">Remove Role</a></li>
				<li><a href = "#">Activate User</a></li>
			<li class="divider"></li>
			</ul>
			</li>
			<li><a href = "#">About</a></li>
			<li><a href = "#">Contact</a></li>
			</ul>
		</div>
		</div>
	</div>
    <script src="Content/js/jquery-2.0.3.min.js"></script>
    <script src="Content/js/bootstrap.js"></script>
</body>
</html>
