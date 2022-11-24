using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4_Formulaire
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string chaine = @"Data Source=DESKTOP-ID5FAVQ\SQLEXPRESS;Initial Catalog=database;Integrated Security=True";
        
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);


        public void connection()
        {
            cnx.Open();
            cmd.Connection = cnx;
           

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            connection();
            cmd.CommandText = "insert into etudiant(nom,prenom,id) values('" + txtnom.Text + "','" + txtprenom.Text + "','" + txtid.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnafficher_Click(object sender, EventArgs e)
        {
            connection();
            cmd.CommandText = "select * from Dossier";
           
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgview.DataSource = dt;
            cnx.Close();
        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            connection();
            cmd.CommandText = "update etudiant set nom ='" + txtnom.Text + "' , set prenom = '" + txtprenom.Text + "' where id='" + txtid.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnsupprimer_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "delete from etudiant where id='" + txtid.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
    }
}
