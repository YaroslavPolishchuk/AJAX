using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Models;

namespace WebApplication1
{
    public partial class WebPromo : System.Web.UI.Page
    {
        IEnumerable<EmpPromoBizType> proms;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string requestId = Request.Params["EmployeeId"];
                int id = requestId != null ? Convert.ToInt32(requestId) : 0;
                HR_Context context = new HR_Context();
                proms = context.EmpPromotion.
                    Where(emp => emp.EmployeeId == id).
                    Select(p =>
                    new EmpPromoBizType()
                    {
                        EmployeeId = p.EmployeeId,
                        FirstName = p.Employee.FirstName,
                        LastName=p.Employee.LastName,
                        HireDate=p.HireDate,
                        Salary=p.Salary,
                        NameJobTitle = p.JobTitle.NameJobTitle
                    }
                ).ToList();
                gv1.DataSource = proms;
                gv1.DataBind();
            }
        }
    }
}