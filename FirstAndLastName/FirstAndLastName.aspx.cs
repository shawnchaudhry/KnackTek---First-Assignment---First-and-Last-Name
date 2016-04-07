using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstAndLastName
{
    public partial class FirstAndLastName : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void btnFinish_Click(object sender, EventArgs e)
        {
            /*
            Label changeMe = new Label();
            changeMe.Text = tbFirst.Text + " " + tbLast.Text;
            Page.Controls.Add(changeMe);
            */
            lblChangeMe.Text = tbFirst.Text + " " + tbLast.Text;
        }

    }
}