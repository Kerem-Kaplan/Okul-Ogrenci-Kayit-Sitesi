using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OkulOgrenciKayitSitesi
{
    public partial class KayıtOl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.tbl_OgrenciTableAdapter tbl_OgrenciTableAdapter = new DataSet1TableAdapters.tbl_OgrenciTableAdapter();
            tbl_OgrenciTableAdapter.OgrenciEkle(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text);
        }
    }
}