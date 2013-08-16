using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using gov.va.medora.downstream;
using gov.va.medora.downstream.net;
using gov.va.medora.downstream.domain;

namespace DownstreamDashboard2
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            (Page.Master.FindControl("linkMainMenuOverview") as HyperLink).CssClass = "nav-text btn active";
            (Page.Master.FindControl("linkMainMenuDetails") as HyperLink).CssClass = "nav-text btn";
            (Page.Master.FindControl("linkMainMenuReports") as HyperLink).CssClass = "nav-text btn";

            Client dsClient = new Client("orchestratorhostname", 21);
            MessageTO response = dsClient.submitRequest(new MessageTO() { MessageType = MessageTypeTO.TimeToNextRunRequest });
            labelNextRunTime.Text = response.Message;
            DateTime.Parse(response.Message);

            Dictionary<String, IList<ExtractorConfiguration>> worklists = new Client("orchestratorhostname", 21).sendGetWorkListsRequest();
            labelActiveExtractionsCount.Text = Convert.ToString(worklists["Active"].Count);

        }
    }
}
