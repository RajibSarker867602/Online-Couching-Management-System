<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchPageUI.aspx.cs" Inherits="CouchingManagementApp.UI.SearchPageUI" %>


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
</head>
<body>
    <form id="dksdkj" runat="server">
	<div class="w3ls-banner">
	<div class="heading">
<div id='cssmenu'>
<ul>
    <li><a href="HomePage.aspx"><span>Home</span></a></li>
   <li><a href="AddSutdentPageUI.aspx"><span>Add Student</span></a></li>
    <li><a href="StudentPageUI.aspx"><span>Student</span></a></li>
   <li class='active'><a href="SearchPageUI.aspx"><span>Search</span></a></li>
   <li><a href="FeesPageUI.aspx"><span>Fees</span></a></li>
    <li><a href="AddCoursePageUI.aspx"><span>Add Course</span></a></li>
    <li><a href="CoursePageUI.aspx"><span>Course</span></a></li>
    <li><a href="AddTeacherPageUI.aspx"><span>Add Teacher</span></a></li>
    <li><a href="TeacherPageUI.aspx"><span>Teacher</span></a></li>
    <li><a href="AdminastratorPageUI.aspx"><span>Admin</span></a></li>
    <li><a href="AboutPage.aspx"><span>Contact</span></a></li>
    <li style="float:right"><a href="LoginPageUI.aspx"><span>Log Out</span></a></li>
   <%--<li class='last'><a href='#'><span>Contact</span></a></li>--%>
</ul>
</div>
		<h1>Student Search By Registration Number</h1>
	</div>
        <div>
        </div>
		<div class="container">
			<div class="agile-form">
				<ul class="field-list">
                    <li>
						<label class="form-label"> 
								Registration No 
							</label>
							<div class="form-input">
								<asp:TextBox ID="registrationNoTextBox" runat="server" placeholder="Enter Student Registration No"></asp:TextBox>
                                <asp:Button ID="searchButton" runat="server" Text="Search" value="Book Appointment" OnClick="searchButton_Click" />
							</div>
						</li>
                                <%--<asp:Button ID="searchButton" runat="server" Text="Search" value="Book Appointment" Width="186px"/>--%>
						<li>
							<asp:Panel ID="panalGrid" runat="server" CssClass="panel">
        <asp:GridView ID="studentRecordsGrid" runat="server" HorizontalAlign="Center" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AutoGenerateColumns="False">
            <Columns>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <asp:Label ID="nameLabel" runat="server" Text='<%#Bind("Student_Name")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Address">
                    <ItemTemplate>
                        <asp:Label ID="addressLabel" runat="server" Text='<%#Bind("Address")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Email">
                    <ItemTemplate>
                        <asp:Label ID="emailLabel" runat="server" Text='<%#Bind("Email")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Date">
                    <ItemTemplate>
                        <asp:Label ID="dateLabel" runat="server" Text='<%#Bind("Date")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Course">
                    <ItemTemplate>
                        <asp:Label ID="courseLabel" runat="server" Text='<%#Bind("Selected_Course")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Teacher">
                    <ItemTemplate>
                        <asp:Label ID="teacherLabel" runat="server" Text='<%#Bind("Selected_Teacher")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Registratoin">
                    <ItemTemplate>
                        <asp:Label ID="registrationNoLabel" runat="server" Text='<%#Bind("Registration_No")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
    </asp:Panel>
						</li>
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
