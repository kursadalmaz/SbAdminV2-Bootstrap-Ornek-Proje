using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormOdev
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        sirketEntities ort = new sirketEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int gelenid = Convert.ToInt32(Request.QueryString["Urunid"]);
            Urunler silinen = ort.Urunlers.FirstOrDefault(x => x.UrunID == gelenid);

            ort.Urunlers.Remove(silinen);
            ort.SaveChanges();

            Response.Redirect("Urunlistele.aspx");

        }
    }
}