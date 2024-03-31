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

namespace StudentDatabaseProject
{
    public partial class Attendence : Form
    {
        bool check_date = false;
        bool check_update = false;
        int id;
        private const string ConnectionString = "Data Source=hamXa;Initial Catalog=ProjectB;Integrated Security=True;"; //connection string

        SqlConnection connection = new SqlConnection(ConnectionString);
        public Attendence()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Attendence_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("\r\nselect Student.Id , Concat(Student.FirstName,Student.LastName)   as StudentName,RegistrationNumber from Student ", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            PutColumnsInDataGridView();
            connection.Close();
        }
        private void PutColumnsInDataGridView()
        {


            DataGridViewComboBoxColumn Update = new DataGridViewComboBoxColumn();
            Update.HeaderText = "Status";
            Update.Items.Add("Present");
            Update.Items.Add("Absent");
            Update.Items.Add("Late");
            Update.Items.Add("Leave");

            dataGridView1.Columns.Add(Update);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AttendenceViewer newUserControl = new AttendenceViewer();
            MessageBox.Show("Select the date and click on result to generate Report");
            newUserControl.Dock = DockStyle.Fill;

            AttendenceViewer att = new AttendenceViewer();

            // Show the second form
            //cloform.Show();
            att.ShowDialog();

            // If you want to hide the current form when opening the second form
            this.Show();

            // Remove or comment out this line to keep the current form open
            // this.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void load1(string sqlDateTime)

        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Insert into ClassAttendance values (@date)", connection);
            cmd.Parameters.AddWithValue("@date", (sqlDateTime));
            cmd.ExecuteNonQuery();
            connection.Close();
            // MessageBox.Show("Successfully Saved");
        }
        private void load2(string sqlDateTime)

        {
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("select max(Id) from ClassAttendance where AttendanceDate=@date", connection);
            cmd2.Parameters.AddWithValue("@date", sqlDateTime);
            cmd2.ExecuteNonQuery();
            id = (Int32)cmd2.ExecuteScalar();
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime selectedDateTime = dateTimePicker1.Value;
                string sqlDateTime = selectedDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                load1(sqlDateTime);
                load2(sqlDateTime);


                MessageBox.Show(id.ToString());
                if (dataGridView1.Rows.Count != 0)
                {
                    connection.Open();



                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value != null)
                        {
                            string SI = dataGridView1.Rows[i].Cells[1].Value.ToString();
                            string S = dataGridView1.Rows[i].Cells[0].Value.ToString();
                            int x = 1;

                            if (S == "Present") { x = 1; }
                            else if (S == "Late") { x = 4; }
                            else if (S == "Absent") { x = 2; }
                            else if (S == "Leave") { x = 3; }
                            string cmd3 = $"INSERT INTO StudentAttendance  VALUES ({id},{SI},{x})";
                            SqlCommand command = new SqlCommand(cmd3, connection);
                            /// MessageBox.Show(x.ToString());

                            command.ExecuteNonQuery();
                            MessageBox.Show("Saved Successfully");
                            connection.Close();
                        }
                        else { MessageBox.Show("Mark the attendance first it!!!"); }
                    }


                };


            }
            catch (Exception exp) { MessageBox.Show(exp.Message.ToString()); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
