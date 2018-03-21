using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace MyFirstWebApplication
{
    public partial class Index : System.Web.UI.Page
    {
        Dictionary<string, string> imageList = new Dictionary<string, string>();
        protected void Page_Load(object sender, EventArgs e)
        {
            imageList.Add("Iron Man", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTeg-Y9kbN5VOd_1QQ95tZm3BI4uWk6JfKJ6RM3A8efhOeig0VzHw");
            imageList.Add("Super", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSy1b47-0x8rYMdN-e7J1dm27zqXe5Jxoigg26T_tHrBgYFKwnC7w");
        }

        protected void btnShowSalutation_Click_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            if(ddlFavMovieList.SelectedIndex > 0)
            {
                bool Favmoviehome = chkWatchMovieInHome.Checked;
                bool Favmovietheater = chkWatchMovieInTheater.Checked;
               

                lblMessage.ForeColor = Color.Blue;
                string favMovieName = ddlFavMovieList.SelectedValue;
                string str = "";
                foreach(ListItem item in ListBox1.Items)
                {
                    if (item.Selected)
                        str += item.Value + ",";
                }

                Image1.ImageUrl = imageList[favMovieName];

                lblMessage.Text = $"Hello, {name}, your choose {favMovieName} as your choose"+
                    $"<br/> {str}";
            }
            else
            {
                lblMessage.Text = "please slect a movie name";
                lblMessage.ForeColor = Color.Red;
            }
           
        }

      
    }
}