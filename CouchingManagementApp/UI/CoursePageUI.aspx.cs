using System;
using CouchingManagementApp.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;

namespace CouchingManagementApp.UI
{
    public partial class CoursePageUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadInGrid();
        }

        private void LoadInGrid()
        {
            AllCourseDetailsShowInGridView allcourseShow = new AllCourseDetailsShowInGridView();
            DataTable dt = allcourseShow.GetAllCourseDetails();
            if (dt.Rows.Count > 0)
            {
                allCourseGridView.DataSource = dt;
                allCourseGridView.DataBind();
            }
        }

        protected void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                AllCourseDetailsShowInGridView allcourseShow = new AllCourseDetailsShowInGridView();
                DataTable cPrint = allcourseShow.GetAllCourseDetails();
                if (cPrint.Rows.Count > 0)
                {
                    ReportDocument rd = new ReportDocument();
                    rd.Load(Server.MapPath("~/CrystalReport1.rpt"));
                    rd.SetDataSource(cPrint);

                    DAO.ReportClass.rc = rd;
                    Response.Redirect("ReportView.aspx");

                }
            }
            catch(Exception r)
            {
                Response.Write(r.Message);
            }
            
        }
    }
}