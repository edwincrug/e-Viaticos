using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace e_Viaticos
{
    public partial class DisplaySession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LabelUserLogin.Text = Session["UserLogin"].ToString();
            LabelStepName.Text = Session["StepName"].ToString();
            LabelUltimusNumber.Text = Session["UltimusNumber"].ToString();
            LabelProcessSummary.Text = Session["ProcessSummary"].ToString();
        }
    }
}