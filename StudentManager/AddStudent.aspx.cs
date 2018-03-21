using StudentManager.App;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManager
{
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddStudent_Click_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Name = txtStudentName.Text;
            student.RegisterNumber = txtStudentRegister.Text;
            student.StudentCategory = DropDownList1.Text;
            student.Save();


                
        }
    }
}