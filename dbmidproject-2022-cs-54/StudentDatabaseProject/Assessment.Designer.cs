namespace StudentDatabaseProject
{
    partial class Assessment
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
            txtTitle = new TextBox();
            txtTotalMarks = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label7 = new Label();
            txtTotalWeightage = new TextBox();
            dataGridView1 = new DataGridView();
            addButton = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.PowderBlue;
            txtTitle.Location = new Point(203, 126);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(200, 31);
            txtTitle.TabIndex = 15;
            // 
            // txtTotalMarks
            // 
            txtTotalMarks.BackColor = Color.PowderBlue;
            txtTotalMarks.Location = new Point(203, 234);
            txtTotalMarks.Name = "txtTotalMarks";
            txtTotalMarks.Size = new Size(200, 31);
            txtTotalMarks.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(429, 34);
            label2.Name = "label2";
            label2.Size = new Size(204, 37);
            label2.TabIndex = 17;
            label2.Text = "Assessment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(203, 100);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 22;
            label1.Text = "Title";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(203, 199);
            label4.Name = "label4";
            label4.Size = new Size(156, 23);
            label4.TabIndex = 26;
            label4.Text = "TOTAL MARKS";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(203, 297);
            label7.Name = "label7";
            label7.Size = new Size(169, 23);
            label7.TabIndex = 28;
            label7.Text = "Total Weightage";
            // 
            // txtTotalWeightage
            // 
            txtTotalWeightage.BackColor = Color.PowderBlue;
            txtTotalWeightage.Location = new Point(203, 335);
            txtTotalWeightage.Name = "txtTotalWeightage";
            txtTotalWeightage.Size = new Size(200, 31);
            txtTotalWeightage.TabIndex = 32;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(530, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(540, 266);
            dataGridView1.TabIndex = 33;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // addButton
            // 
            addButton.Location = new Point(958, 372);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 34);
            addButton.TabIndex = 34;
            addButton.Text = "Delete";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(753, 372);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 35;
            button1.Text = "EDIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(530, 372);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 36;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Assessment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1158, 475);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(addButton);
            Controls.Add(dataGridView1);
            Controls.Add(txtTotalWeightage);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(txtTotalMarks);
            Controls.Add(txtTitle);
            Name = "Assessment";
            Text = "Assessment";
            Load += Assessment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtTitle;
        private TextBox txtTotalMarks;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label7;
        private TextBox txtTotalWeightage;
        private DataGridView dataGridView1;
        private Button addButton;
        private Button button1;
        private Button button2;
    }
}