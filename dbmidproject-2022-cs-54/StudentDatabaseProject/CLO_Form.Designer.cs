namespace StudentDatabaseProject
{
    partial class CLO_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLO_Form));
            label2 = new Label();
            FirstNameTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            ADD_Button = new Button();
            label7 = new Label();
            label3 = new Label();
            label1 = new Label();
            HomeButton = new PictureBox();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HomeButton).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(424, 12);
            label2.Name = "label2";
            label2.Size = new Size(292, 46);
            label2.TabIndex = 1;
            label2.Text = "Manage CLOs";
            label2.Click += label2_Click;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.BackColor = Color.PowderBlue;
            FirstNameTextBox.Location = new Point(65, 108);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(235, 31);
            FirstNameTextBox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(65, 185);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(235, 31);
            dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(65, 285);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(235, 31);
            dateTimePicker2.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(424, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(733, 435);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ADD_Button
            // 
            ADD_Button.BackColor = Color.Turquoise;
            ADD_Button.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ADD_Button.ForeColor = Color.White;
            ADD_Button.Location = new Point(65, 396);
            ADD_Button.Name = "ADD_Button";
            ADD_Button.Size = new Size(226, 40);
            ADD_Button.TabIndex = 17;
            ADD_Button.Text = "ADD";
            ADD_Button.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(65, 239);
            label7.Name = "label7";
            label7.Size = new Size(146, 23);
            label7.TabIndex = 29;
            label7.Text = "Date Updated";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(65, 159);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 30;
            label3.Text = "Date Created";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(63, 82);
            label1.Name = "label1";
            label1.Size = new Size(69, 23);
            label1.TabIndex = 31;
            label1.Text = "NAME";
            // 
            // HomeButton
            // 
            HomeButton.BackgroundImage = (Image)resources.GetObject("HomeButton.BackgroundImage");
            HomeButton.BackgroundImageLayout = ImageLayout.Stretch;
            HomeButton.Location = new Point(65, 13);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(43, 45);
            HomeButton.TabIndex = 33;
            HomeButton.TabStop = false;
            HomeButton.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(HomeButton);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, -3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1227, 60);
            panel2.TabIndex = 34;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.image_removebg_preview__1_;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(1172, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(43, 37);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 580);
            panel1.Name = "panel1";
            panel1.Size = new Size(1227, 41);
            panel1.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(232, 6);
            label4.Name = "label4";
            label4.Size = new Size(662, 23);
            label4.TabIndex = 34;
            label4.Text = "Student Management System. Made by Hamza. All Rights Reserved";
            // 
            // CLO_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1227, 618);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(ADD_Button);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(FirstNameTextBox);
            Name = "CLO_Form";
            Text = "CLO_Form";
            Load += CLO_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)HomeButton).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox FirstNameTextBox;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private Button ADD_Button;
        private Label label7;
        private Label label3;
        private Label label1;
        private PictureBox HomeButton;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label4;
    }
}