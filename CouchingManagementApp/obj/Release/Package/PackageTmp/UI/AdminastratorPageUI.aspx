<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminastratorPageUI.aspx.cs" Inherits="CouchingManagementApp.UI.AdminastratorPageUI" %>


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
   <li><a href="SearchPageUI.aspx"><span>Search</span></a></li>
   <li><a href="FeesPageUI.aspx"><span>Fees</span></a></li>
    <li><a href="AddCoursePageUI.aspx"><span>Add Course</span></a></li>
    <li><a href="CoursePageUI.aspx"><span>Course</span></a></li>
    <li><a href="AddTeacherPageUI.aspx"><span>Add Teacher</span></a></li>
    <li><a href="TeacherPageUI.aspx"><span>Teacher</span></a></li>
    <li class='active'><a href="AdminastratorPageUI.aspx"><span>Admin</span></a></li>
    <li><a href="AboutPage.aspx"><span>Contact</span></a></li>
    <li style="float:right"><a href="LoginPageUI.aspx"><span>Log Out</span></a></li>
   <%--<li class='last'><a href='#'><span>Contact</span></a></li>--%>
</ul>
</div>
		<h1>Adminastrator Page</h1>
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
								Modifiy 
							</label>
							<div class="form-input">
								<asp:DropDownList ID="modifyDdList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="modifyDdList_SelectedIndexChanged">
                                    <asp:ListItem Selected="True">--Select--</asp:ListItem>
                                    <asp:ListItem>Course</asp:ListItem>
                                    <asp:ListItem>Teacher&#39;s</asp:ListItem>
                                    <asp:ListItem>Student</asp:ListItem>
                                </asp:DropDownList>
							</div>
						</li>
                        <li>
							<asp:Panel ID="panalGrid" runat="server" CssClass="panel">
                                <asp:GridView ID="allCourseListGrid" runat="server" HorizontalAlign="Center" AutoGenerateColumns="False" OnRowCancelingEdit="allCourseListGrid_RowCancelingEdit" OnRowDeleting="allCourseListGrid_RowDeleting1" OnRowEditing="allCourseListGrid_RowEditing" OnRowUpdating="allCourseListGrid_RowUpdating">
                                    <Columns>
                                        <asp:CommandField ShowEditButton="True" />
                                        <asp:CommandField ShowDeleteButton="True" />
                                        <asp:TemplateField HeaderText="Id">
                                            <ItemTemplate>
                                                <asp:Label ID="idLabel" runat="server" Text='<%#Bind("Id")%>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Course_Name">
                                            <ItemTemplate>
                                                <asp:Label ID="courseNameLabel" runat="server" Text='<%#Bind("Course_Name")%>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox id="courseNameTextBox" runat="server" Text='<%#Bind("Course_Name") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Course_Fee">
                                            <ItemTemplate>
                                                <asp:Label ID="courseFeeLabel" runat="server" Text='<%#Bind("Course_Fee")%>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox id="courseFeeTextBox" runat="server" Text='<%#Bind("Course_Fee") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Duration">
                                            <ItemTemplate>
                                                <asp:Label ID="durationLabel" runat="server" Text='<%#Bind("Duration")%>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox id="durationTextBox" runat="server" Text='<%#Bind("Duration") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                           </asp:Panel>
						</li>
                        <li>
							<asp:Panel ID="Panel1" runat="server" CssClass="panel">
                                <asp:GridView ID="allTeacherListGridView" runat="server" HorizontalAlign="Center" AutoGenerateColumns="False" OnRowCancelingEdit="allTeacherListGridView_RowCancelingEdit" OnRowDeleting="allTeacherListGridView_RowDeleting" OnRowEditing="allTeacherListGridView_RowEditing" OnRowUpdating="allTeacherListGridView_RowUpdating">
                                    <Columns>
                                        <asp:CommandField ShowEditButton="True" />
                                        <asp:CommandField ShowDeleteButton="True" />
                                        <asp:TemplateField HeaderText="Id">
                                            <ItemTemplate>
                                                <asp:Label ID="tIdLabel" runat="server" Text='<%#Bind("Id") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Teacher_Name">
                                            <ItemTemplate>
                                                <asp:Label ID="teacherNameLabel" runat="server" Text='<%#Bind("Teacher_Name") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="teacherNameTextBox" runat="server" Text='<%#Bind("Teacher_Name") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Subject">
                                            <ItemTemplate>
                                                <asp:Label ID="subjectLabel" runat="server" Text='<%#Bind("Subject") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="subjectTextBox" runat="server" Text='<%#Bind("Subject") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Qualification">
                                            <ItemTemplate>
                                                <asp:Label ID="qualificationLabel" runat="server" Text='<%#Bind("Qualification") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="qualificationTextBox" runat="server" Text='<%#Bind("Qualification") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                           </asp:Panel>
						</li>
                                              <li>
							<label class="form-label"> 
								<asp:Label ID="registrationNoLabel" runat="server" Text="Registration No"></asp:Label>
							</label>
							<div class="form-input">
								<asp:TextBox ID="registrationNoTextBox" runat="server" placeholder="Enter The Student Registration No" AutoPostBack="true" OnTextChanged="registrationNoTextBox_TextChanged"></asp:TextBox>
							</div>
						</li>
                        <li>
							<asp:Panel ID="Panel2" runat="server" CssClass="panel">
                                <asp:GridView ID="studentRecordsGridView" runat="server" HorizontalAlign="Center" AutoGenerateColumns="False" OnRowCancelingEdit="studentRecordsGridView_RowCancelingEdit" OnRowDeleting="studentRecordsGridView_RowDeleting" OnRowEditing="studentRecordsGridView_RowEditing" OnRowUpdating="studentRecordsGridView_RowUpdating" >
                                    <Columns>
                                        <asp:CommandField ShowEditButton="True" />
                                        <asp:CommandField ShowDeleteButton="True" />
                                        <asp:TemplateField HeaderText="Id">
                                            <ItemTemplate>
                                                <asp:Label ID="sIdLabel" runat="server" Text='<%#Bind("Id") %>'></asp:Label>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Student_Name">
                                            <ItemTemplate>
                                                <asp:Label ID="studentNameLabel" runat="server" Text='<%#Bind("Student_Name") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="studentNameTextBox" runat="server" Text='<%#Bind("Student_Name") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Address">
                                            <ItemTemplate>
                                                <asp:Label ID="addressLabel" runat="server" Text='<%#Bind("Address") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="addressTextBox" runat="server" Text='<%#Bind("Address") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Email">
                                            <ItemTemplate>
                                                <asp:Label ID="emailLabel" runat="server" Text='<%#Bind("Email") %>'></asp:Label>
                                            </ItemTemplate>
                                            <EditItemTemplate>
                                                <asp:TextBox ID="emailTextBox" runat="server" Text='<%#Bind("Email") %>'></asp:TextBox>
                                            </EditItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                           </asp:Panel>  
                        <%--<asp:Button ID="saveButton" runat="server" Text="Save" value="Book Appointment" Width="186px"/>                                           			--%>
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
