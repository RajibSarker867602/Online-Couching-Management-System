<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSutdentPageUI.aspx.cs" Inherits="CouchingManagementApp.UI.AddSutdentPageUI" %>


<!--
	Author: W3layouts
	Author URL: http://w3layouts.com
	License: Creative Commons Attribution 3.0 Unported
	License URL: http://creativecommons.org/licenses/by/3.0/
-->
<!DOCTYPE html>
<html lang="en">
<head runat="server">
    

	<!-- Meta tags -->
	<title>Couching Management Application</title>
	<meta name="keywords" content="Appoint My Doctor Form Responsive widget, Flat Web Templates, Android Compatible web template, 
	Smartphone Compatible web template, free webdesigns for Nokia, Samsung, LG, SonyEricsson, Motorola web design" />
	<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge">
	<meta name="viewport" content="width=device-width, initial-scale=1">
	<!-- stylesheets -->
	<link rel="stylesheet" href="css/font-awesome.css">
	<link rel="stylesheet" href="../css/style.css" />
	<!-- google fonts  -->
	<link href="//fonts.googleapis.com/css?family=Roboto+Condensed:300,300i,400,400i,700,700i" rel="stylesheet">
	<link href="//fonts.googleapis.com/css?family=Josefin+Sans:300,400,400i,700" rel="stylesheet">
    <%----------------------Menu Bar---------------------%>
  
   <meta charset='utf-8'>
   <meta http-equiv="X-UA-Compatible" content="IE=edge">
   <meta name="viewport" content="width=device-width, initial-scale=1">
   <link rel="stylesheet" href="../styles.css" />
   <script src="http://code.jquery.com/jquery-latest.min.js" type="text/javascript"></script>
   <script src="script.js"></script>

        <%------------------------------jquery ui----------------------------------%>
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="http://code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <link rel="stylesheet" href="http://resources/demos/style.css">
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
  <script>
  $( function() {
      $("#startDateTextBox").datepicker();
  } );
  </script>


</head>
<body>
    <form id="dksdkj" runat="server">
	<div class="w3ls-banner">
	<div class="heading">
<div id='cssmenu'>
<ul>
    <li><a href="HomePage.aspx"><span>Home</span></a></li>
   <li class='active'><a href="AddSutdentPageUI.aspx"><span>Add Student</span></a></li>
    <li><a href="StudentPageUI.aspx"><span>Student</span></a></li>
   <li><a href="SearchPageUI.aspx"><span>Search</span></a></li>
   <li><a href="FeesPageUI.aspx"><span>Fees</span></a></li>
    <li><a href="AddCoursePageUI.aspx"><span>Add Course</span></a></li>
    <li><a href="CoursePageUI.aspx"><span>Course</span></a></li>
    <li><a href="AddTeacherPageUI.aspx"><span>Add Teacher</span></a></li>
    <li><a href="TeacherPageUI.aspx"><span>Teacher</span></a></li>
    <li><a href="TeacherPageUI.aspx"><span>Admin</span></a></li>
    <li><a href="AboutPage.aspx"><span>Contact</span></a></li>
    <li style="float:right"><a href="LoginPageUI.aspx"><span>Log Out</span></a></li>
   <%--<li class='last'><a href='#'><span>Contact</span></a></li>--%>
</ul>
</div>
		<h1>Add Student Here...</h1>
	</div>
        <div>
        </div>
		<div class="container">
			<div class="heading">
				<h2>Please Enter Details</h2>
				<p>Fill the form below.</p>
			</div>
			<div class="agile-form">
				
					<ul class="field-list">
						<li>
							<label class="form-label"> 
								Name* 
							</label>
							<div class="form-input">
								<asp:TextBox ID="studentNameTextBox" runat="server" placeholder="Enter The Student Name"></asp:TextBox>
                                <%--<asp:RequiredFieldValidator ID="nameReq" runat="server" ControlToValidate="studentNameTextBox" Font-Size="Smaller" ErrorMessage="Student Name Is Required!" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>--%>

							</div>
						</li>
                        <li>
							<label class="form-label"> 
								Address* 
							</label>
							<div class="form-input">
								<asp:TextBox ID="addressTextBox" runat="server" placeholder="Enter Address Here" TextMode="MultiLine"></asp:TextBox>
                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="addressTextBox" Font-Size="Smaller" ErrorMessage="Address Is Required!" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>--%>
							</div>
						</li>
                        <li>
							<label class="form-label"> 
								Email* 
							</label>
							<div class="form-input">
								<asp:TextBox ID="emailTextBox" runat="server" placeholder="Enter Email Here" TextMode="Email"></asp:TextBox>
                                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="emailTextBox" Font-Size="Smaller" ErrorMessage="Email Address Is Required!" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>--%>
							</div>
						</li>
                        <li>
							<label class="form-label"> 
								Course List 
							</label>
							<div class="form-input">
								<asp:DropDownList ID="courseListDdList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="courseListDdList_SelectedIndexChanged"></asp:DropDownList>
							</div>
						</li>
                        <li>
							<label class="form-label"> 
								Course Fee 
							</label>
							<div class="form-input">
								<asp:Label ID="courseFeeLabel" runat="server" Text="Course Fee Will Be Display Here"></asp:Label>
							</div>
						</li>
                        <li>
							<label class="form-label"> 
								Teacher's List 
							</label>
							<div class="form-input">
								<asp:DropDownList ID="teachersDdList" runat="server"></asp:DropDownList>
							</div>
						</li>
                         <li>
							<label class="form-label"> 
								Start Date
							</label>
							<div class="form-input">
								<asp:TextBox ID="startDateTextBox" runat="server" placeholder="Enter The Start Date" AutoPostBack="true" OnTextChanged="startDateTextBox_TextChanged"></asp:TextBox>
							</div>
						</li>
                        <li>
							<label class="form-label"> 
								Registration No 
							</label>
							<div class="form-input">
								<asp:Label ID="registrationNumberLabel" runat="server" Text="Registration Number Will Be Display Here"></asp:Label>
							</div>
						</li>	
                        <asp:Button ID="saveButton" runat="server" Text="Save" value="Book Appointment" Width="186px" OnClick="saveButton_Click"/>                                           			
					</ul>	
			</div>
		</div>
	</div>
        </form>
</body>
</html>



<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>--%>
