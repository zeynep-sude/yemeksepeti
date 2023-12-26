using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YemekSepeti
{
    public partial class FrmApply : Form
    {
        public FrmApply()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YemekKapinda;Integrated Security=True");
        private void FrmApply_Load(object sender, EventArgs e)
        {
           


        }

        private void BtnApplyFinish_Click(object sender, EventArgs e)
        {
            connect.Open();
            SqlCommand restaurantadd = new SqlCommand("insert into TBL_Restaurant (RestaurantName,Il,Ilce,SemtMah,PaketServis) values (@b1,@b2,@b3,@b4,@b5)",connect);
            restaurantadd.Parameters.AddWithValue("@b1", TxtRestaurantName.Text);
            restaurantadd.Parameters.AddWithValue("@b2", CbIl.Text);
            restaurantadd.Parameters.AddWithValue("@b3", CbIlce.Text);
            restaurantadd.Parameters.AddWithValue("@b4", CbMahSemt.Text);
            restaurantadd.Parameters.AddWithValue("@b5", CbPaketServ.Text);
            restaurantadd.ExecuteNonQuery();

            SqlCommand companyadd = new SqlCommand("insert into TBL_CompanyOfficial (FirtLastName,IdentityNumber,TelephoneNumber,Email) values(@a1,@a2,@a3,@a4)", connect);
            companyadd.Parameters.AddWithValue("@a1", TxtCompName.Text);
            companyadd.Parameters.AddWithValue("@a2", TxtCombIden.Text);
            companyadd.Parameters.AddWithValue("@a3", TxtCompTelephone.Text);
            companyadd.Parameters.AddWithValue("@a4", TxtCompEmail.Text);
            companyadd.ExecuteNonQuery();

            SqlCommand manageradd = new SqlCommand("insert into TBL_RestaurantManager (FirstLastName,IdentityNumber,TelephoneNumber,Email) values(@c1,@c2,@c3,@c4)", connect);
            manageradd.Parameters.AddWithValue("@c1", TxtManName.Text);
            manageradd.Parameters.AddWithValue("@c2", TxtManIdentity.Text);
            manageradd.Parameters.AddWithValue("@c3", TxtManTelephone.Text);
            manageradd.Parameters.AddWithValue("@c4", TxtManEmail.Text);
            manageradd.ExecuteNonQuery();
            connect.Close();
       
            

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
