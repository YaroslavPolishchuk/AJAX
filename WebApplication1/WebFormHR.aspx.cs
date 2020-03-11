using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Ddl;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class WebFormHR : System.Web.UI.Page
    {
        IEnumerable<EmpPromotion> list;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlMethods.DataSource = Storage.GetDdl();
                ddlMethods.DataTextField = "Value";
                ddlMethods.DataValueField = "Key";
                ddlMethods.DataBind();
                string stingID = Request.Params["EmployeeId"];
                int id = Convert.ToInt32(stingID);
                HR_Context context = new HR_Context();
                list = context.EmpPromotion.Where(i => i.EmployeeId == id).ToList();

            }
        }
    }
}