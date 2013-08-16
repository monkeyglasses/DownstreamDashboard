using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DownstreamDashboard2
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            (Page.Master.FindControl("linkMainMenuDetails") as HyperLink).CssClass = "nav-text btn active";
            (Page.Master.FindControl("linkMainMenuOverview") as HyperLink).CssClass = "nav-text btn";
            (Page.Master.FindControl("linkMainMenuReports") as HyperLink).CssClass = "nav-text btn";
        }
    }
}