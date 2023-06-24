using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebClient.Service_s;

namespace WebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service_s.Var_2_spClient client = new Service_s.Var_2_spClient("BasicHttpBinding_IVar_2_sp");
            Label1.Text = client.GetMessage('\t'+TextBox1.Text);

        }
    }
}