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

namespace StudentDatabaseProject
{
    public partial class Assessment : Form
    {
        public Assessment()
        {
            InitializeComponent();

        }

        private void EmailTB_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection connection = new SqlConnection("Data Source=hamXa;Initial Catalog=ProjectB;Integrated Security=True;");
        public int id;

        private void addButton_Click(object sender, EventArgs e)
        {
           
                if (id > 0 )
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM Assessment WHERE Id = @Id", connection);
                    cmd.Parameters.AddWithValue("@Id", id);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Assessment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GetAssessmentRecords();
                    FieldsReseter();
                }
                else if (id == 0)
                {
                    MessageBox.Show("Please select an assessment to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
        private void GetAssessmentRecords()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Assessment", connection);
            DataTable dt = new DataTable();

            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            connection.Close();

            dataGridView1.DataSource = dt;
        }
        private void FieldsReseter()
        {
            txtTitle.Clear();
            txtTotalMarks.Clear();
            txtTotalWeightage.Clear();

            id = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //
            SqlCommand cmd = new SqlCommand("INSERT INTO Assessment (Title, DateCreated, TotalMarks, TotalWeightage) VALUES (@Title, GETDATE(), @TotalMarks, @TotalWeightage)", connection);
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@TotalMarks", Convert.ToInt32(txtTotalMarks.Text));
            cmd.Parameters.AddWithValue("@TotalWeightage", Convert.ToInt32(txtTotalWeightage.Text));

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("New Assessment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GetAssessmentRecords();
            FieldsReseter();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE Assessment SET Title = @Title, TotalMarks = @TotalMarks, TotalWeightage = @TotalWeightage WHERE Id = @Id", connection);
                cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@TotalMarks", Convert.ToInt32(txtTotalMarks.Text));
                cmd.Parameters.AddWithValue("@TotalWeightage", Convert.ToInt32(txtTotalWeightage.Text));
                cmd.Parameters.AddWithValue("@Id", id);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Assessment updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GetAssessmentRecords();
                FieldsReseter();
            }
            else if (id == 0)
            {
                MessageBox.Show("Please select an assessment to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Assessment_Load(object sender, EventArgs e)
        {
            GetAssessmentRecords();
            txtTitle.Focus();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells["Id"].Value);
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtTotalMarks.Text = row.Cells["TotalMarks"].Value.ToString();
                txtTotalWeightage.Text = row.Cells["TotalWeightage"].Value.ToString();
            }
        }
    }
}
