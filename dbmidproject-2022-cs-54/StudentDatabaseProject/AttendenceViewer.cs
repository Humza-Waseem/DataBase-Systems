using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf.draw;
using System.ComponentModel.Design.Serialization;
using System.Globalization;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentDatabaseProject
{

    public partial class AttendenceViewer : Form
    {
        public string x;
        private const string ConnectionString = "Data Source=hamXa;Initial Catalog=ProjectB;Integrated Security=True;"; //connection string

        SqlConnection connection = new SqlConnection(ConnectionString);
        public AttendenceViewer()
        {
            InitializeComponent();
        }

        private void GenerateReportBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null && comboBox1.Text != String.Empty)
            {
                string dateString = comboBox1.Text;
                DateTime dateonly;
                DateTime.TryParse(dateString, out dateonly);

                string datestring2 = dateonly.ToString("yyyy-MM-dd");
                string namx = " Student Attendance Report (" + datestring2 + ")";
                string linex = "Attendance Report of Students on" + comboBox1.Text;
                string date2 = "Attendance Date " + datestring2;

                ExportToPDF(dataGridView1, namx, linex, date2);
                MessageBox.Show("Report Generated");
            }
            else { MessageBox.Show("Select the record first to generate report"); }
        }

        private void AttendenceViewer_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd2 = new SqlCommand($"  select CONCAT(FirstName,LastName)as NAME,RegistrationNumber,Lookup.Name as STATUS,AttendanceDate\r\nfrom ClassAttendance\r\njoin StudentAttendance\r\non StudentAttendance.AttendanceId=ClassAttendance.Id\r\njoin Student \r\non StudentAttendance.StudentId=Student.Id\r\njoin Lookup\r\non LookupId=StudentAttendance.AttendanceStatus\r\nwhere ClassAttendance.AttendanceDate='{x}'", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            dataGridView1.DefaultCellStyle.ForeColor = Color.DarkBlue;
            connection.Close();

            connection.Open();

            SqlCommand cmd = new SqlCommand("\r\nselect Distinct(AttendanceDate) from ClassAttendance join StudentAttendance on StudentAttendance.AttendanceId=ClassAttendance.Id\r\n", connection);
            SqlDataReader reader2 = cmd.ExecuteReader();
            while (reader2.Read())
            {
                comboBox1.Items.Add((reader2.GetSqlDateTime(0)).ToString());
            }
            reader2.Close();

            cmd2.ExecuteNonQuery();
            connection.Close();
        }


        private void ExportToPDF(DataGridView dgv, string name, string l, string marks)
        {
            try
            {
                Document document = new Document(PageSize.A4, 20, 20, 20, 20);
                PdfWriter.GetInstance(document, new FileStream(name + ".pdf", FileMode.CreateNew));
                document.Open();
                iTextSharp.text.Font headingFont = FontFactory.GetFont("Times New Roman", 18, iTextSharp.text.Font.BOLD);
                Paragraph heading = new Paragraph(name, headingFont);
                heading.Alignment = Element.ALIGN_CENTER;
                heading.SpacingBefore = 10f;
                heading.SpacingAfter = 10f;

                document.Add(heading);

                LineSeparator line = new LineSeparator();
                document.Add(line);

                iTextSharp.text.Font headingFont2 = FontFactory.GetFont("Times New Roman", 14, iTextSharp.text.Font.BOLD);
                Paragraph heading2 = new Paragraph(marks, headingFont2);
                heading2.Alignment = Element.ALIGN_LEFT;
                heading2.SpacingBefore = 10f;
                heading2.SpacingAfter = 10f;

                document.Add(heading2);



                iTextSharp.text.Font courseFont = FontFactory.GetFont("Times New Roman", 12);
                Paragraph course = new Paragraph(l, courseFont);

                course.Alignment = Element.ALIGN_CENTER;
                course.IndentationLeft = 55f;
                course.SpacingAfter = 20f;
                document.Add(course);

                LineSeparator line2 = new LineSeparator();
                document.Add(line2);



                PdfPTable table = new PdfPTable(dgv.Columns.Count);
                table.WidthPercentage = 100;
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    table.AddCell(cell);
                }

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.Index == dataGridView1.Rows.Count)
                    {
                        continue;

                    }
                    else
                    {
                        try
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {

                                if (cell.Value == null)
                                {
                                    continue;
                                    MessageBox.Show("Fill all the columns of table (status) it can not be null");
                                }
                                else
                                {
                                    PdfPCell pdfCell = new PdfPCell(new Phrase(cell.Value.ToString()));
                                    table.AddCell(pdfCell);
                                }
                            }
                        }
                        catch (Exception exp) { MessageBox.Show("Fill all the columns of table (status) it can not be null"); }

                    }


                }
                document.Add(table);
                document.Close();
            }
            catch (Exception exp) { }//MessageBox.Show("Fill all the columns of table (status) it can not be null"); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd2 = new SqlCommand($"  select CONCAT(FirstName,LastName)as NAME,RegistrationNumber,Lookup.Name as STATUS,AttendanceDate\r\nfrom ClassAttendance\r\njoin StudentAttendance\r\non StudentAttendance.AttendanceId=ClassAttendance.Id\r\njoin Student \r\non StudentAttendance.StudentId=Student.Id\r\njoin Lookup\r\non LookupId=StudentAttendance.AttendanceStatus\r\nwhere ClassAttendance.AttendanceDate='{x}'", connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            connection.Close();
            

        }
       
    }
}
