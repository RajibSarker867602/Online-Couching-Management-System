using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CouchingManagementApp.UI
{
    public partial class ReportView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CrystalReportViewer1.ReportSource = DAO.ReportClass.rc;
        }

        protected void CrystalReportViewer1_Init(object sender, EventArgs e)
        {
            CrystalReportViewer1.ReportSource = DAO.ReportClass.rc;
        }
    }
}