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
    public partial class FrmLogIn : Form
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=YemekKapinda;Integrated Security=True");
        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            GrpBxLogIn.Visible = false;
            GrpBxSignUp.Visible = false;
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            GrpBxLogIn.Visible=true;
            
        }

        private void GrpBxSignUp_Enter(object sender, EventArgs e)
        {

        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            GrpBxSignUp.Visible = true;
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            frmHome.Show();
        }


        private void BtnSignUpFinish_Click(object sender, EventArgs e)
        {
            
            connect.Open();
            SqlCommand signup = new SqlCommand("insert into TBL_Customers (Email,Password,FirstName,LastName,BirthDate) values(@a1,@a2,@a3,@a4,@a5)", connect);
            signup.Parameters.AddWithValue("@a1", TxtSgnEmail.Text);
            signup.Parameters.AddWithValue("@a2", TxtSgnPassword.Text);
            signup.Parameters.AddWithValue("@a3", TxtSgnFirst.Text);
            signup.Parameters.AddWithValue("@a4", TxtSgnLast.Text);
            signup.Parameters.AddWithValue("@a5",TxtSgnBirth.Text);
            signup.ExecuteNonQuery();
            connect.Close();
        }

        private void BtnLgInFinish_Click(object sender, EventArgs e)
        {
            connect.Open();
            string mail = TxtLgEmail.Text;
            string password = TxtLgPasword.Text;
            SqlCommand login = new SqlCommand("Select * from TBL_Customers where Email= '" + mail + "' and Password = '" + password + "'",connect);
            SqlDataReader reader = login.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Hoşgeldiniz");
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
            connect.Close();
        }
    }
}
