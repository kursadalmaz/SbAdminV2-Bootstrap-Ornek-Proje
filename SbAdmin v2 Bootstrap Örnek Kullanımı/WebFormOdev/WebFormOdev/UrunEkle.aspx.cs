using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace WebFormOdev
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEkle_Click(object sender, EventArgs e)
        {
            string baglanti = "Data Source=DESKTOP-KPY0B0A;Initial Catalog=sirket;Integrated Security=True";
            SqlConnection bag = new SqlConnection(baglanti);
            bag.Open();

            SqlCommand ekle = new SqlCommand();
            ekle.Connection=bag;
            ekle.CommandType = System.Data.CommandType.StoredProcedure;
            ekle.CommandText = "spurunekle";

            ekle.Parameters.AddWithValue("@vurunad", TxtUrunAdi.Text);
            ekle.Parameters.AddWithValue("@vtedid",DdTedarik.SelectedValue);
            ekle.Parameters.AddWithValue("@vkatid", DdKategori.SelectedValue);
           
            ekle.ExecuteNonQuery();
            bag.Close();
           
        }

        protected void BtnEntitie_Click(object sender, EventArgs e)
        {
            sirketEntities ort = new sirketEntities();
            Urunler yeniurun = new Urunler();
            yeniurun.UrunAdi = TxtUrunAdi.Text;
            yeniurun.TedarikciID = Convert.ToInt32(DdTedarik.SelectedValue);
            yeniurun.KategoriID = Convert.ToInt32(DdKategori.SelectedValue);
            

            ort.Urunlers.Add(yeniurun);
            ort.SaveChanges();



        }
    }
}