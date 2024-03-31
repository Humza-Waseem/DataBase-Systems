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
using System.Text.RegularExpressions;

namespace StudentDatabaseProject

{
    public partial class Form1 : Form
    {
        string first, last, registeration, email, contact;
        int id, status;
        bool update = false;
        //  bool check_f = false, check_l = false, check_r = false, check_e = false, check_c = false

        private const string ConnectionString = "Data Source=hamXa;Initial Catalog=ProjectB;Integrated Security=True;"; //connection string
        SqlConnection connection = new SqlConnection(ConnectionString);
        public Form1()
        {
            InitializeComponent();
            GifPictureBox.Image = Image.FromFile("H:\\4thSemester\\DB_midProject\\dbmidproject-2022-cs-54\\StudentDatabaseProject\\Assets\\school.gif ");

            // Start the animation if it's an animated GIF
            GifPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            /*dataGridView1.CellFormatting += DataGridView1_CellFormatting;
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.Blue;
            dataGridView1.ColumnHeadersDefaultCellStyle = headerStyle;*/
        }
        private int GetSelectedId()
        {
            // Implement your logic to get the selected Id
            // For example, if you have a DataGridView named dataGridView1 and the Id is in a column named "Id":
            if (dataGridView1.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
            }
            return -1; // Replace -1 with a default value or handle accordingly
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadStudentRecords();
            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.BackColor = Color.LightBlue;
            // Set the TableLayoutPanel to dock to all edges of the form


            // Add more controls as needed

            // Repeat the process for additional rows and columns
        }
        public Form1(int id, String first, String last, String registeration, String email, string contact, int status, bool update)
        {
            InitializeComponent();
            this.id = id;
            this.first = first;
            this.last = last;
            this.registeration = registeration;
            this.email = email;
            this.contact = contact;
            this.update = update;
            this.status = status;
            if (update == true)
            {
                FirstNameTextBox.Text = first;
                LastNameTB.Text = last;
                RegNoTB.Text = registeration;
                EmailTB.Text = email;
                ContactTB.Text = contact;
                if (status == 5)
                { StatusCB.Text = "Active"; }
                else if (status == 6)
                { StatusCB.Text = "InActive"; }
                ADD_Button.Text = "Update Student";
            }
        }

        //int id;   // id variable
        private void LoadStudentRecords()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Student WHERE Status = 5";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Ensure the clicked cell is not a header and that there is at least one row
            if (e.RowIndex >= 0 && dataGridView1.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                // Assuming your DataGridView columns correspond to the columns in the Student table
                FirstNameTextBox.Text = selectedRow.Cells["FirstName"].Value.ToString();
                LastNameTB.Text = selectedRow.Cells["LastName"].Value.ToString();
                ContactTB.Text = selectedRow.Cells["Contact"].Value.ToString();
                EmailTB.Text = selectedRow.Cells["Email"].Value.ToString();
                RegNoTB.Text = selectedRow.Cells["RegistrationNumber"].Value.ToString();


                // You can add more textbox assignments as needed
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private bool ValidateEmail(string email)
        {
            // Define a regular expression pattern for a simple email validation
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Check if the email matches the pattern
            if (Regex.IsMatch(email, emailPattern))
            {
                // Valid email format
                // You can add further actions or display a success message if needed

                return true;
            }
            else
            {
                // Invalid email format
                MessageBox.Show("Email nOt correct", "Errorrrrrrrrrrrrrrrrrrrrr", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Optionally, clear the TextBox or set focus back to it
                EmailTB.Clear();
                EmailTB.Focus();
                return false;
            }
        }
        private bool ValidateRegistrationNumber(string registrationNumber)
        {
            // Regex pattern for the desired format
            const string pattern = @"^\d{4}-[A-Za-z]+-\d+$";
            return Regex.IsMatch(registrationNumber, pattern);
        }
        private bool isValid()
        {

            // Call the email validation function when the TextBox loses focus
            bool flag = ValidateEmail(EmailTB.Text);
            bool check = ValidateRegistrationNumber(RegNoTB.Text);

            if(check == false)
            {
                MessageBox.Show("Registration Number not in Correct Format", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!flag  & !check)
            {
                return false;
            }



            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) &&
                string.IsNullOrWhiteSpace(LastNameTB.Text) &&
                string.IsNullOrWhiteSpace(EmailTB.Text) &&
                string.IsNullOrWhiteSpace(RegNoTB.Text) &&
                string.IsNullOrWhiteSpace(ContactTB.Text)
                )
            {
                MessageBox.Show("app ne kuch add nai kia", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                MessageBox.Show("Please provide Firrrssst Name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(LastNameTB.Text))
            {
                MessageBox.Show("Please provide Lassst Name", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(EmailTB.Text))
            {
                MessageBox.Show("Please provide Email", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrWhiteSpace(RegNoTB.Text))
            {
                MessageBox.Show("Please provide Registration No.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void FieldsReseter()
        {
            FirstNameTextBox.Text = "";
            LastNameTB.Text = "";
            ContactTB.Text = "";
            EmailTB.Text = "";
            RegNoTB.Text = "";

            id = 0;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            /*try
            {
                // Check if textboxes are not empty
                if (isValid())
                {
                    SqlCommand regNoChecker = new SqlCommand("SELECT COUNT(*) FROM Student WHERE RegistrationNumber = @RegistrationNumber", connection);
                    regNoChecker.Parameters.AddWithValue("@RegistrationNumber", RegNoTB.Text);

                    SqlCommand contactChecker = new SqlCommand("SELECT COUNT(*) FROM Student WHERE Contact = @Contact", connection);
                    contactChecker.Parameters.AddWithValue("@Contact", ContactTB.Text);

                    SqlCommand EmailChecker = new SqlCommand(" SELECT COUNT(*) FROM Student Where Email = @Email", connection);
                    EmailChecker.Parameters.AddWithValue("@Email", EmailTB.Text);

                    connection.Open();
                    int countEmail = (int)EmailChecker.ExecuteScalar();
                    int countReg = (int)regNoChecker.ExecuteScalar();
                    int countContact = (int)contactChecker.ExecuteScalar();
                    connection.Close();
                    if(countEmail > 0)
                    {
                        MessageBox.Show("Email pehlay b hai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (countContact > 0)
                    {
                        MessageBox.Show("Contact pehlay b haiiiiii", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      return;
                        }
                    if (countReg > 0)
                    {
                        MessageBox.Show("RegNo pehlay b haiii", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    

                    SqlCommand cmd = new SqlCommand("INSERT INTO Student (FirstName, LastName, Contact, Email, RegistrationNumber, Status) VALUES (@FirstName, @LastName, @Contact, @Email, @RegistrationNumber, 1)", connection);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@LastName", LastNameTB.Text);
                    cmd.Parameters.AddWithValue("@Contact", ContactTB.Text);
                    cmd.Parameters.AddWithValue("@Email", EmailTB.Text);
                    cmd.Parameters.AddWithValue("@RegistrationNumber", RegNoTB.Text);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("New Student's Data successfully saved in the database", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStudentRecords();
                    FieldsReseter();
                }
                else
                {
                    MessageBox.Show("Please fill in all the textboxes before inserting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            try
            {
                if (isValid())
                {
                    if (!update)
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO Student (FirstName, LastName, Contact, Email, RegistrationNumber, Status) VALUES (@FirstName, @LastName, @Contact, @Email, @RegisterationNo, @Status)", connection);

                        cmd.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@LastName", LastNameTB.Text);
                        cmd.Parameters.AddWithValue("@RegisterationNo", RegNoTB.Text);
                        cmd.Parameters.AddWithValue("@Email", EmailTB.Text);
                        cmd.Parameters.AddWithValue("@Contact", ContactTB.Text);

                        int statusValue = (StatusCB.Text == "Active") ? 5 : 6;
                        cmd.Parameters.AddWithValue("@Status", statusValue);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Added");
                        FieldsReseter();
                        LoadStudentRecords();
                    }
                    else
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE Student SET RegistrationNumber = @RegisterationNo, FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email, Status = @Status WHERE Id = @ID", connection);

                        cmd.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@LastName", LastNameTB.Text);
                        cmd.Parameters.AddWithValue("@RegisterationNo", RegNoTB.Text);
                        cmd.Parameters.AddWithValue("@Email", EmailTB.Text);
                        cmd.Parameters.AddWithValue("@Contact", ContactTB.Text);

                        int statusValue = (StatusCB.Text == "Active") ? 5 : 6;
                        cmd.Parameters.AddWithValue("@Status", statusValue);

                        cmd.Parameters.AddWithValue("@ID", id);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully updated");
                        FieldsReseter();
                        LoadStudentRecords();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the textboxes before inserting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed, even in case of an exception
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            FieldsReseter();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CLO_Form cloform = new CLO_Form();

            // Show the second form
            //cloform.Show();
            cloform.ShowDialog();

            // If you want to hide the current form when opening the second form
            this.Show();

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            FirstNameTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            LastNameTB.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            ContactTB.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            EmailTB.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            RegNoTB.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Check if textboxes are not empty and other basic validations
                if (isValid())
                {
                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        // Check if the record with the given Id exists
                        SqlCommand idChecker = new SqlCommand("SELECT COUNT(*) FROM Student WHERE Id = @Id", connection);
                        idChecker.Parameters.AddWithValue("@Id", GetSelectedId()); // Replace with your method to get the selected Id

                        connection.Open();
                        int countId = (int)idChecker.ExecuteScalar();

                        if (countId == 0)
                        {
                            MessageBox.Show("Record with the specified Id does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Perform the update with Status set to 1
                        SqlCommand cmd = new SqlCommand("UPDATE Student SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, Email = @Email, RegistrationNumber = @RegistrationNumber, Status = 1 WHERE Id = @Id", connection);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@LastName", LastNameTB.Text);
                        cmd.Parameters.AddWithValue("@Contact", ContactTB.Text);
                        cmd.Parameters.AddWithValue("@Email", EmailTB.Text);
                        cmd.Parameters.AddWithValue("@RegistrationNumber", RegNoTB.Text);
                        cmd.Parameters.AddWithValue("@Id", GetSelectedId());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Student's data successfully updated in the database", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FieldsReseter();
                        LoadStudentRecords();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in all the textboxes before updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            /*Student student = new Student(FirstNameTextBox.Text, LastNameTB.Text, ContactTB.Text, EmailTB.Text, RegNoTB.Text, 1);
            student.Update(FirstNameTextBox.Text, LastNameTB.Text, ContactTB.Text, EmailTB.Text, RegNoTB.Text, 1);
            RefreshForm();*/

            try
            {
                // Check if a row is selected in the DataGridView
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the Id of the selected row
                    int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                    using (SqlConnection connection = new SqlConnection(ConnectionString))
                    {
                        // Update the Status to 0 for the specified Id
                        SqlCommand cmd = new SqlCommand("UPDATE Student SET Status = 6 WHERE Id = @Id", connection);
                        cmd.Parameters.AddWithValue("@Id", selectedId);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Student's Data Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadStudentRecords();
                        FieldsReseter();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Attendence attendance = new Attendence();

            // Show the second form
            //cloform.Show();
            attendance.ShowDialog();

            // If you want to hide the current form when opening the second form
            this.Show();
        }
    }
}
