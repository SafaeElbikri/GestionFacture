using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace Facture
{
    public partial class Client : MetroForm
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\insert_delete_Update_Database\insert_delete_Update_Database\fature.mdf;Integrated Security=True");

        public Client()
        {
            InitializeComponent();
        }
        static DataSet dscompt = new DataSet("ListClt");
        DataTable dtcompt = new DataTable("ListClt");


        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox15_Click(object sender, EventArgs e)
        {

        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.clients'. Vous pouvez la déplacer ou la supprimer selon les besoins.
         /*   this.facturesTableAdapter.Fill(this.dataSet1.clients);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void display_data()
        {

            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [ClientInfo]";

            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;

            connection.Close();
        }

        private void createdscompt()
        {
            if (dtcompt.Rows.Count <= 0)
            {
                // Il faut mettre les mêmes noms des champs dans la Table FactureCompt

                DataColumn dc1 = new DataColumn("ClientId", typeof(string));

                DataColumn dc2 = new DataColumn("RS", typeof(string));
                DataColumn dc3 = new DataColumn("NomResp", typeof(string));
                DataColumn dc4 = new DataColumn("TypeClient", typeof(int));
                DataColumn dc5 = new DataColumn("Nom", typeof(decimal));
                DataColumn dc6 = new DataColumn("Tel", typeof(decimal));
                DataColumn dc7 = new DataColumn("IF", typeof(int));
                DataColumn dc11 = new DataColumn("Fax", typeof(int));
                DataColumn dc12 = new DataColumn("Portable", typeof(int));
                DataColumn dc13 = new DataColumn("Email", typeof(int));

                DataColumn dc8 = new DataColumn("ICE", typeof(Int64));
                DataColumn dc9 = new DataColumn("Aresse", typeof(string));

                DataColumn dc10 = new DataColumn("RC", typeof(string));


                dtcompt.Columns.Add(dc1);
                dtcompt.Columns.Add(dc2);
                dtcompt.Columns.Add(dc3);
                dtcompt.Columns.Add(dc4);
                dtcompt.Columns.Add(dc5);
                dtcompt.Columns.Add(dc6);
                dtcompt.Columns.Add(dc7);
                dtcompt.Columns.Add(dc8);
                dtcompt.Columns.Add(dc9);
                dtcompt.Columns.Add(dc10);
                 dtcompt.Columns.Add(dc1);
                dtcompt.Columns.Add(dc11); dtcompt.Columns.Add(dc12); dtcompt.Columns.Add(dc13);


                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {

                    dtcompt.Rows.Add(dgr.Cells["NomResp"].Value, dgr.Cells["Typelient"].Value, dgr.Cells["Nom"].Value, dgr.Cells["Prenom"].Value, dgr.Cells["Tel"].Value, dgr.Cells["Portable"].Value, dgr.Cells["Fax"].Value, dgr.Cells["Email"].Value, dgr.Cells["Adresse"].Value);

                }

                // Remplissage de dataset dscompt
                dscompt.Tables.Add(dtcompt);

            }
            else
            {

                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {

                    dtcompt.Rows.Add(dgr.Cells["NomResp"].Value, dgr.Cells["Typelient"].Value, dgr.Cells["Nom"].Value, dgr.Cells["Prenom"].Value, dgr.Cells["Tel"].Value, dgr.Cells["Portable"].Value, dgr.Cells["Fax"].Value, dgr.Cells["Email"].Value, dgr.Cells["Adresse"].Value);
                }
                dscompt.Tables.Add(dtcompt);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [ClientInfo]";

            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;

            connection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into [ClientInfo] (NomResp,RS,Nom,Prenom,Tel,Portable,Fax,Email,Adresse,Ville,Pays,IF,TypeS,RC,ICE,Patente) values ('" + metroTextBox7.Text + "','" + metroTextBox2.Text + "','" + metroTextBox9.Text + "','" + metroTextBox10.Text + "','" + metroTextBox12.Text + ",'" + metroTextBox14.Text + "','" + metroTextBox13.Text + "','" + metroTextBox11.Text + "','" + metroTextBox12.Text + "','" + metroComboBox1.Text + "','" + metroTextBox15.Text + "','" + metroTextBox3.Text + "','" + metroTextBox4.Text + "','" + metroTextBox6.Text + "','" + metroTextBox5.Text + "','" + metroTextBox8.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            display_data();


        }
    }
}
