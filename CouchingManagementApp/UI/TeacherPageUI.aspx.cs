using System;
using CouchingManagementApp.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CouchingManagementApp.UI
{
    public partial class TeacherPageUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadInGrid();
        }

        private void LoadInGrid()
        {
            AllTeacherDetailsShowInGrid allTeacherShowInGrid = new AllTeacherDetailsShowInGrid();
            DataTable dt = allTeacherShowInGrid.ShowAllTeacherDetailsInGrid();
            if (dt.Rows.Count > 0)
            {
                allTeacherGridView.DataSource = dt;
                allTeacherGridView.DataBind();
            }
            else
            {
                Response.Write("There are no teacher's available!");
            }
        }
    }
}