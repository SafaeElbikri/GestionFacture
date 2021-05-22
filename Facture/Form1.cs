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
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace Facture
{
    public partial class Form1 : MetroForm
    {

        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\source\repos\insert_delete_Update_Database\insert_delete_Update_Database\facture.mdf;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }
        static DataSet dscompt = new DataSet("FactureCompt");
        DataTable dtcompt = new DataTable("FactureCompt");


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'database1DataSet.Devis'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.devisTableAdapter.Fill(this.database1DataSet.Devis);

        }




        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Double Q = double.Parse(maskedTextBox6.Text);
            Double P = double.Parse(maskedTextBox7.Text);
            Double MHT = P * Q;
            

            ListViewItem it = new ListViewItem();
            it.Text = maskedTextBox5.Text;
            it.SubItems.Add(maskedTextBox7.Text);
            it.SubItems.Add(maskedTextBox6.Text);
            it.SubItems.Add(MHT.ToString());

            if (metroRadioButton1.Checked == true)
            { P = 0.2; }
            else if (metroRadioButton2.Checked == true)
            {
                P = 0.07;
            }
         else if ( metroRadioButton1.Checked == false && metroRadioButton2.Checked == false)
            {
                MessageBox.Show("choisissze le taux TVA ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            it.SubItems.Add(( P * MHT).ToString());
            it.SubItems.Add((MHT + P * MHT).ToString());
            it.SubItems.Add(maskedTextBox8.Text);
            listView1.Items.Add(it);

            // calcil de TVA par methode 




        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }







        private void CalculerTVA()
        {
            double THTC = 0, TTVA = 0;
            // calcul Total 
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                THTC += Convert.ToDouble(listView1.Items[i].SubItems[3].Text);
                TTVA += Convert.ToDouble(listView1.Items[i].SubItems[4].Text);


            }
            //Affichage Calcul
            MHT.Text = THTC.ToString();
            TTVABox.Text = TTVA.ToString();
            THTCBox.Text = (THTC + TTVA).ToString();


        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            // cmd.CommandText = "insert into [InfClient],[Devis] (NomResp,RS,Nom,Prenom,Tel,Portable,Fax,Email,Adresse,Ville,Pays,IF,TypeS,RC,ICE,Patente) values ('" + maskedTextBox4.Text + "','" + maskedTextBox4.Text + "','" + maskedTextBox4.Text + "','" + maskedTextBox4.Text + "','" + maskedTextBox4.Text + ",'" + maskedTextBox4.Text + "','" + maskedTextBox4.Text + "','" + maskedTextBox4.Text + "','" + maskedTextBox4.Text + "','" + ComboBox1.Text + "','" + maskedTextBox4.Text + "','" + maskedTextBox4.Text + "','" + maskedTextBox4.Text + "','" + maskedTextBox4.Text + "','" + maskedTextBox4.Text + "','" + maskedTextBox4.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            display_data();


        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        public DataSet returndata()
        {
            return dscompt;

        }


        private void createdscompt()
        {
            if (dtcompt.Rows.Count <= 0)
            {
                // Il faut mettre les mêmes noms des champs dans la Table FactureCompt

                DataColumn dc1 = new DataColumn("FactureNbr", typeof(string));

                DataColumn dc2 = new DataColumn("Designation", typeof(string));
                DataColumn dc3 = new DataColumn("Reference", typeof(string));
                DataColumn dc4 = new DataColumn("Quantite", typeof(int));
                DataColumn dc5 = new DataColumn("Prix", typeof(decimal));
                DataColumn dc6 = new DataColumn("Total", typeof(decimal));
                DataColumn dc7 = new DataColumn("IFClient", typeof(int));
                DataColumn dc8 = new DataColumn("ICE", typeof(Int64));
                DataColumn dc9 = new DataColumn("Date", typeof(string));

                DataColumn dc10 = new DataColumn("RS", typeof(string));


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

                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {

                    dtcompt.Rows.Add(dgr.Cells["FactureNbr"].Value, dgr.Cells["Designation"].Value, dgr.Cells["Reference"].Value, dgr.Cells["Quantite"].Value, dgr.Cells["Prix"].Value, dgr.Cells["Total"].Value, Convert.ToInt32(maskedTextBox4.Text.Trim()), Convert.ToInt64(maskedTextBox3.Text.Trim()), ((DateTime)dateTimePicker1.Value).ToString("dd/MM/yyyy"), comboBox1.Text);

                }

                // Remplissage de dataset dscompt
                dscompt.Tables.Add(dtcompt);

            }
            else
            {

                foreach (DataGridViewRow dgr in dataGridView1.Rows)
                {

                    dtcompt.Rows.Add(dgr.Cells["FactureNbr"].Value, dgr.Cells["Designation"].Value, dgr.Cells["Reference"].Value, dgr.Cells["Quantite"].Value, dgr.Cells["Prix"].Value, dgr.Cells["Total"].Value, Convert.ToInt32(maskedTextBox4.Text.Trim()), Convert.ToInt64(maskedTextBox3.Text.Trim()), ((DateTime)dateTimePicker1.Value).ToString("dd/MM/yyyy"), comboBox1.Text);
                }
                dscompt.Tables.Add(dtcompt);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Pour remplir dscompt
            if (dataGridView1.DataSource != null)
            {
                dtcompt.Clear();
                dtcompt.Columns.Clear();

                //Appel methode création Dscompt Dataset (voir sa définition)
                createdscompt();
		  
		  // Appel de l’objet Print_Facture() qui représente crystalReportViewer
                Print_Facture obj = new Print_Facture();

                obj.Show();

     // Ceci permet de vider dscompt des données remplies par la méthode createdscompt()
     // et pour pouvoir la réutiliser afin d'imprimer une nouvelle table ["FactureCompt"] 
     // apres selection 

                dscompt.Tables.Remove(dscompt.Tables["FactureCompt"]);

            }
            else
            {
                MessageBox.Show("Aucune Facture à Imprimer");
            }


        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Devis] where Designation = '" + maskedTextBox5.Text +"and Prix"+ maskedTextBox7.Text +  "and Quantite" + maskedTextBox6.Text + "and Referene" + maskedTextBox8.Text + "'";
            cmd.ExecuteNonQuery();

            connection.Close();

            display_data();

          

        }


        private void display_data()
        {


            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
        cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Devis]";
            
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
        SqlDataAdapter dataadp = new SqlDataAdapter(cmd.CommandText, connection); ;
            dataadp.Fill(dta);
            //listView1.DataSource = dta;

            connection.Close();

        }
        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
