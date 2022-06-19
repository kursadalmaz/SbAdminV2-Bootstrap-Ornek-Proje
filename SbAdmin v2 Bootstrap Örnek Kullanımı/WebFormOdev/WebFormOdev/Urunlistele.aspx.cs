using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormOdev
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            sirketEntities ort = new sirketEntities();
            Repeater1.DataSource = ort.Urunlers.ToList();
            Repeater1.DataBind();
        }
    }
}