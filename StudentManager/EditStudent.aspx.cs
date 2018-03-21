using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManager
{
    public partial class EditStudent : System.Web.UI.Page
    {
        int studentId = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request["Id"] != null)
            {
                studentId = int.Parse(Request["Id"]);
            }
        }
                
        protected void Button1_Click(object sender, EventArgs e)
        {
            throw new Exception();
        }

        protected void Button1_Click_Click(object sender, EventArgs e)
        {
            throw new Exception();
        }
    }
}