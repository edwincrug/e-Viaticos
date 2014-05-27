using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace e_Viaticos
{
    public partial class ProxyPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Session["UserLogin"] = Request.QueryString["UserLogin"];      //cookies.strUserID
                Session["StepName"] = Request.QueryString["StepName"];       //tasks.GetTaskXMLElement("Keywords.StepLabel").ToString
                Session["UltimusNumber"] = Request.QueryString["UltimusNumber"];  //Convert.ToInt32(tasks.GetTaskXMLElement("Keywords.IncidentNumber
                Session["ProcessSummary"] = Request.QueryString["ProcessSummary"]; //tasks.GetTaskXMLElement("Keywords.IncidentSummary").ToString();

                LabelStatus.Text = "done";
            }
            catch(Exception ex)
            {
                LabelStatus.Text = ex.Message;
            }
        }
    }
}