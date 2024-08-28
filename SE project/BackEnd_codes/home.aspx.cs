using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginForm
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAddPlan_Click(object sender, EventArgs e)
        {
            Response.Redirect("MasterPlanAdd.aspx");
        }

        protected void btnAddPlan_ClickBacholer(object sender, EventArgs e)
        {
            Response.Redirect("BachelorPlanAdd.aspx");
        }
        protected void btnAddPlan_ClickDiploma(object sender, EventArgs e)
        {
            Response.Redirect("DiplomaPlanAdd.aspx");
        }
        protected void btndelete(object sender, EventArgs e)
        {
            Response.Redirect("DeleteForAll.aspx");
        }
        protected void btnmodify(object sender, EventArgs e)
        {
            Response.Redirect("ModifyForAll.aspx");
        }

    }
}