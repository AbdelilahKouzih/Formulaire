using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
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

        static int Verif = 0;
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
            btnannuler.Enabled = false;
            btnmodifier.Enabled = true;
            btnvalider.Enabled = false;
            btnsupprimer.Enabled = true;
            btnafficher.Enabled = true;
            cbx.Enabled = true;

        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            Verif = 1;

            if(txtnom.Text ==""||txtprenom.Text==""||txtid.Text=="")
            {
                MessageBox.Show("vous devez remplir les champs !!");
                    return;
            }
            else
            {
                connection();
              
            }
            btnannuler.Enabled = true;
            btnmodifier.Enabled = false;
            btnvalider.Enabled = true;
            btnsupprimer.Enabled = false;
            btnafficher.Enabled = false;
            txtid.Enabled = false;
            txtnom.Enabled = false;
            txtprenom.Enabled = false;
            cbx.Enabled = false;
            
            cnx.Close();
        }

        private void btnafficher_Click(object sender, EventArgs e)
        {



            connection();
            btnannuler.Enabled = true;
            btnmodifier.Enabled = true;
            btnvalider.Enabled = true;
            btnsupprimer.Enabled = true;
            btnafficher.Enabled = false;
            cbx.Enabled = true;
            txtnom.Enabled = false;
            txtprenom.Enabled = false;
            txtid.Enabled = false;
            cmd.CommandText = "select * from etudiant";
           
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cbx.DataSource = dt;
            cbx.ValueMember= "id";
            cbx.DisplayMember= "prenom";
            cnx.Close();
            txtnom.DataBindings.Clear();
            txtprenom.DataBindings.Clear();
            txtnom.DataBindings.Add("text", cbx.DataSource, "nom");
            txtprenom.DataBindings.Add("text",cbx.DataSource, "prenom");
            txtid.DataBindings.Add("text", cbx.DataSource, "id");

        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            Verif = 2;
            if (txtid.Text == "")
            {
                MessageBox.Show("vous devez remplir le champ d'identifiant !!");
                return;
            }
            connection();
            btnsupprimer.Enabled = false;
            btnafficher.Enabled = false;
            btnajouter.Enabled = false;
            btnvalider.Enabled = true;
            btnannuler.Enabled = true;
            cmd.CommandText = "update etudiant set nom ='" + txtnom.Text + "' ,prenom = '" + txtprenom.Text + "' where id='" + txtid.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void btnsupprimer_Click(object sender, EventArgs e)

        {
            Verif = 3;
            connection();
            cmd.CommandText = "delete from etudiant where id='" + txtid.Text + "' ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        private void lblId_Click(object sender, EventArgs e)
        {

        }

        private void cbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnvalider_Click(object sender, EventArgs e)
        {

            if(Verif==1)
            { 
            connection();
            txtid.Enabled = true;
            txtnom.Enabled = true;
            txtprenom.Enabled = true;
            cmd.CommandText = "insert into etudiant(nom,prenom,id) values('" + txtnom.Text + "','" + txtprenom.Text + "','" + txtid.Text + "') ";
            cmd.ExecuteNonQuery();
            cnx.Close();
            }
            else if(Verif==2)
            {


            }
        }

        private void btnannuler_Click(object sender, EventArgs e)
        {
             if(Verif==1) 
            { 
            txtid.Clear();
            txtnom.Clear();
            txtprenom.Clear();
            btnmodifier.Enabled = true;
           
            btnsupprimer.Enabled = true;
            btnafficher.Enabled = true;
            }
        }
    }
}
