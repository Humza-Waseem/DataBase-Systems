using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentDatabaseProject
{
    public partial class CLO_Form : Form
    {
        private const string ConnectionString = "Data Source=hamXa;Initial Catalog=ProjectB;Integrated Security=True;"; //connection string
        SqlConnection con = new SqlConnection(ConnectionString);
        public string id;


        public int Id;
        public CLO_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            NameTxt.Text = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 mainPage = new Form1();

            // Show the second form
            //cloform.Show();
            mainPage.Show();

            // If you want to hide the current form when opening the second form
            this.Close();
        }

        private void CLO_Form_Load(object sender, EventArgs e)
        {
//
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ADD_Button_Click(object sender, EventArgs e)
        {
            try
            {

            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    // Update the Status to 0 for the specified Id
                    SqlCommand cmd = new SqlCommand("UPDATE Clo SET Name = @Name, DateUpdated = @DateUpdated WHERE Id = @Id", connection);
                        //cmd.Parameters.AddWithValue("@Id", selectedId);
                     cmd.Parameters.AddWithValue("@Id", selectedId);
                     cmd.Parameters.AddWithValue("@Name", NameTxt.Text);
                     cmd.Parameters.AddWithValue("@DateUpdated", DateTime.Now);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("UPDATED Successfully", "UPDATED!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EntitiesGetter();
                    FieldReseter();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void FieldReseter()
        {
            Id = 0;
            NameTxt.Clear();
            NameTxt.Focus();
        }
        private void EntitiesGetter()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Clo", con);
            DataTable dt = new DataTable();

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO Clo (Name, DateCreated, DateUpdated) VALUES (@Name, GETDATE(), GETDATE())", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Name", NameTxt.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("New CLO Added ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EntitiesGetter();
            FieldReseter();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        // Update the Status to 0 for the specified Id
                        SqlCommand cmd = new SqlCommand("DELETE FROM Clo WHERE Id = @Id", connection);
                        //cmd.Parameters.AddWithValue("@Id", selectedId);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FieldReseter();
                        LoadRecords();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void LoadRecords()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Clo ";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dataGridView1.AutoGenerateColumns = true; // Adjust based on your needs
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.ResetBindings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void button3_Click(object sender, EventArgs e)
        {
            LoadRecords();
        }
    }
}
