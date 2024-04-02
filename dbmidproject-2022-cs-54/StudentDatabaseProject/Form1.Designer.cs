namespace StudentDatabaseProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Button DeleteButton;
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            ManageRubricButton = new Button();
            ManageCLOButton = new Button();
            AssessmentButton = new Button();
            RubricButton = new Button();
            MarkEvaluationButton = new Button();
            panel1 = new Panel();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            button9 = new Button();
            ADD_Button = new Button();
            FirstNameTextBox = new TextBox();
            LastNameTB = new TextBox();
            ContactTB = new TextBox();
            EmailTB = new TextBox();
            RegNoTB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button7 = new Button();
            GifPictureBox = new PictureBox();
            StatusCB = new ComboBox();
            labe = new Label();
            DeleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GifPictureBox).BeginInit();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Red;
            DeleteButton.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(772, 290);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(142, 37);
            DeleteButton.TabIndex = 17;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.image_removebg_preview;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 204);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ManageRubricButton
            // 
            ManageRubricButton.BackColor = Color.OrangeRed;
            ManageRubricButton.BackgroundImageLayout = ImageLayout.Stretch;
            ManageRubricButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ManageRubricButton.ForeColor = Color.White;
            ManageRubricButton.Location = new Point(3, 363);
            ManageRubricButton.Name = "ManageRubricButton";
            ManageRubricButton.Size = new Size(298, 37);
            ManageRubricButton.TabIndex = 2;
            ManageRubricButton.Text = " Manage Rubrics";
            ManageRubricButton.UseVisualStyleBackColor = false;
            ManageRubricButton.Click += ManageRubricButton_Click;
            // 
            // ManageCLOButton
            // 
            ManageCLOButton.BackColor = Color.OrangeRed;
            ManageCLOButton.BackgroundImageLayout = ImageLayout.Stretch;
            ManageCLOButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ManageCLOButton.ForeColor = Color.White;
            ManageCLOButton.Location = new Point(3, 290);
            ManageCLOButton.Name = "ManageCLOButton";
            ManageCLOButton.Size = new Size(298, 37);
            ManageCLOButton.TabIndex = 3;
            ManageCLOButton.Text = " Manage CLOs ";
            ManageCLOButton.UseVisualStyleBackColor = false;
            ManageCLOButton.Click += button3_Click;
            // 
            // AssessmentButton
            // 
            AssessmentButton.BackColor = Color.OrangeRed;
            AssessmentButton.BackgroundImageLayout = ImageLayout.Stretch;
            AssessmentButton.Font = new Font("Arial Rounded MT Bold", 12F);
            AssessmentButton.ForeColor = Color.White;
            AssessmentButton.Location = new Point(3, 436);
            AssessmentButton.Name = "AssessmentButton";
            AssessmentButton.Size = new Size(301, 37);
            AssessmentButton.TabIndex = 4;
            AssessmentButton.Text = "Assessments";
            AssessmentButton.UseVisualStyleBackColor = false;
            AssessmentButton.Click += AssessmentButton_Click;
            // 
            // RubricButton
            // 
            RubricButton.BackColor = Color.OrangeRed;
            RubricButton.BackgroundImageLayout = ImageLayout.Stretch;
            RubricButton.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RubricButton.ForeColor = Color.White;
            RubricButton.Location = new Point(3, 515);
            RubricButton.Name = "RubricButton";
            RubricButton.Size = new Size(301, 37);
            RubricButton.TabIndex = 5;
            RubricButton.Text = " Rubric Levels ";
            RubricButton.UseVisualStyleBackColor = false;
            // 
            // MarkEvaluationButton
            // 
            MarkEvaluationButton.BackColor = Color.OrangeRed;
            MarkEvaluationButton.BackgroundImageLayout = ImageLayout.Stretch;
            MarkEvaluationButton.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MarkEvaluationButton.ForeColor = Color.White;
            MarkEvaluationButton.Location = new Point(3, 592);
            MarkEvaluationButton.Name = "MarkEvaluationButton";
            MarkEvaluationButton.Size = new Size(301, 37);
            MarkEvaluationButton.TabIndex = 6;
            MarkEvaluationButton.Text = "Mark Evaluation";
            MarkEvaluationButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(MarkEvaluationButton);
            panel1.Controls.Add(RubricButton);
            panel1.Controls.Add(AssessmentButton);
            panel1.Controls.Add(ManageCLOButton);
            panel1.Controls.Add(ManageRubricButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 772);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.OrangeRed;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(3, 657);
            button1.Name = "button1";
            button1.Size = new Size(298, 37);
            button1.TabIndex = 7;
            button1.Text = "Attendance";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.Font = new Font("Bookman Old Style", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.DarkOrange;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = Color.DarkSlateGray;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle2.Font = new Font("Calibri", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Maroon;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSkyBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.GridColor = Color.Gold;
            dataGridView1.Location = new Point(303, 386);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(964, 386);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(254, 9);
            label1.Name = "label1";
            label1.Size = new Size(466, 37);
            label1.TabIndex = 0;
            label1.Text = "Student Management System";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(916, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 30);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(303, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(964, 52);
            panel2.TabIndex = 1;
            // 
            // button9
            // 
            button9.BackColor = Color.LimeGreen;
            button9.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = Color.White;
            button9.Location = new Point(303, 58);
            button9.Name = "button9";
            button9.Size = new Size(64, 34);
            button9.TabIndex = 18;
            button9.Text = "Reset";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // ADD_Button
            // 
            ADD_Button.BackColor = Color.Turquoise;
            ADD_Button.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ADD_Button.ForeColor = Color.White;
            ADD_Button.Location = new Point(373, 290);
            ADD_Button.Name = "ADD_Button";
            ADD_Button.Size = new Size(136, 37);
            ADD_Button.TabIndex = 3;
            ADD_Button.Text = "ADD";
            ADD_Button.UseVisualStyleBackColor = false;
            ADD_Button.Click += button7_Click;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.BackColor = Color.PowderBlue;
            FirstNameTextBox.Location = new Point(372, 98);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(235, 31);
            FirstNameTextBox.TabIndex = 4;
            // 
            // LastNameTB
            // 
            LastNameTB.BackColor = Color.PowderBlue;
            LastNameTB.Location = new Point(373, 156);
            LastNameTB.Name = "LastNameTB";
            LastNameTB.Size = new Size(235, 31);
            LastNameTB.TabIndex = 5;
            // 
            // ContactTB
            // 
            ContactTB.BackColor = Color.PowderBlue;
            ContactTB.Location = new Point(372, 219);
            ContactTB.Name = "ContactTB";
            ContactTB.Size = new Size(235, 31);
            ContactTB.TabIndex = 6;
            // 
            // EmailTB
            // 
            EmailTB.BackColor = Color.PowderBlue;
            EmailTB.Location = new Point(693, 98);
            EmailTB.Name = "EmailTB";
            EmailTB.Size = new Size(235, 31);
            EmailTB.TabIndex = 7;
            // 
            // RegNoTB
            // 
            RegNoTB.BackColor = Color.PowderBlue;
            RegNoTB.Location = new Point(693, 156);
            RegNoTB.Name = "RegNoTB";
            RegNoTB.Size = new Size(235, 31);
            RegNoTB.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 70);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 10;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 132);
            label3.Name = "label3";
            label3.Size = new Size(95, 25);
            label3.TabIndex = 11;
            label3.Text = "Last Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(372, 191);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 12;
            label4.Text = "Contact";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(693, 70);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 13;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(693, 132);
            label6.Name = "label6";
            label6.Size = new Size(135, 25);
            label6.TabIndex = 14;
            label6.Text = "Registration No";
            // 
            // button7
            // 
            button7.BackColor = Color.CornflowerBlue;
            button7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.ForeColor = Color.White;
            button7.Location = new Point(578, 290);
            button7.Name = "button7";
            button7.Size = new Size(139, 37);
            button7.TabIndex = 16;
            button7.Text = "Edit";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // GifPictureBox
            // 
            GifPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            GifPictureBox.Location = new Point(945, 48);
            GifPictureBox.Name = "GifPictureBox";
            GifPictureBox.Size = new Size(322, 341);
            GifPictureBox.TabIndex = 19;
            GifPictureBox.TabStop = false;
            // 
            // StatusCB
            // 
            StatusCB.FormattingEnabled = true;
            StatusCB.Items.AddRange(new object[] { "Active", "InActive" });
            StatusCB.Location = new Point(693, 219);
            StatusCB.Name = "StatusCB";
            StatusCB.Size = new Size(235, 33);
            StatusCB.TabIndex = 20;
            // 
            // labe
            // 
            labe.AutoSize = true;
            labe.Location = new Point(693, 191);
            labe.Name = "labe";
            labe.Size = new Size(60, 25);
            labe.TabIndex = 21;
            labe.Text = "Status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Coral;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1257, 772);
            Controls.Add(labe);
            Controls.Add(StatusCB);
            Controls.Add(GifPictureBox);
            Controls.Add(button9);
            Controls.Add(DeleteButton);
            Controls.Add(button7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(RegNoTB);
            Controls.Add(EmailTB);
            Controls.Add(ContactTB);
            Controls.Add(LastNameTB);
            Controls.Add(FirstNameTextBox);
            Controls.Add(ADD_Button);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GifPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button8;
        private PictureBox pictureBox1;
        private Button ManageRubricButton;
        private Button ManageCLOButton;
        private Button AssessmentButton;
        private Button RubricButton;
        private Button MarkEvaluationButton;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Button button9;
        private Button ADD_Button;
        private TextBox FirstNameTextBox;
        private TextBox LastNameTB;
        private TextBox ContactTB;
        private TextBox EmailTB;
        private TextBox RegNoTB;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button7;
        private PictureBox GifPictureBox;
        private ComboBox StatusCB;
        private Label labe;
        private Button button1;
    }
}
