using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormOdev
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnAra_Click(object sender, EventArgs e)
        {
            sirketEntities ort = new sirketEntities();
            var sonuc = ort.Urunlers.Where(x => x.UrunAdi.Contains(TxtAra.Text)).ToList();
            GrdSonuc.DataSource = sonuc;
            GrdSonuc.DataBind();
        }
    }
}