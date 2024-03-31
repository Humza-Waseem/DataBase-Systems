namespace StudentDatabaseProject
{
    partial class AttendenceViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            GenerateReportBTN = new Button();
            comboBox1 = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 252);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1422, 343);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(854, 125);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 29);
            label1.TabIndex = 1;
            label1.Text = "Select Date";
            // 
            // GenerateReportBTN
            // 
            GenerateReportBTN.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenerateReportBTN.Location = new Point(1013, 212);
            GenerateReportBTN.Name = "GenerateReportBTN";
            GenerateReportBTN.Size = new Size(195, 34);
            GenerateReportBTN.TabIndex = 3;
            GenerateReportBTN.Text = "GenerateReport";
            GenerateReportBTN.UseVisualStyleBackColor = true;
            GenerateReportBTN.Click += GenerateReportBTN_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1013, 117);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 37);
            comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(1013, 160);
            button1.Name = "button1";
            button1.Size = new Size(195, 34);
            button1.TabIndex = 5;
            button1.Text = "Load Attendance";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AttendenceViewer
            // 
            AutoScaleDimensions = new SizeF(12F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1435, 662);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(GenerateReportBTN);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AttendenceViewer";
            Text = "AttendenceViewer";
            Load += AttendenceViewer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button GenerateReportBTN;
        private ComboBox comboBox1;
        private Button button1;
    }
}