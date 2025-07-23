namespace Assignment_3._3
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            monthOfAdmissionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gradeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            deleteButton = new Button();
            labelID = new Label();
            textBoxID = new TextBox();
            textBoxFirstName = new TextBox();
            labelFirstName = new Label();
            textBoxLastName = new TextBox();
            labelLastName = new Label();
            textBoxAddress = new TextBox();
            labelAddress = new Label();
            addButton = new Button();
            textBoxAdmitMonth = new TextBox();
            labelMonth = new Label();
            textBoxGrade = new TextBox();
            labelGrade = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, monthOfAdmissionDataGridViewTextBoxColumn, gradeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = studentBindingSource;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(799, 450);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 64;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 128;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 126;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Width = 113;
            // 
            // monthOfAdmissionDataGridViewTextBoxColumn
            // 
            monthOfAdmissionDataGridViewTextBoxColumn.DataPropertyName = "MonthOfAdmission";
            monthOfAdmissionDataGridViewTextBoxColumn.HeaderText = "MonthOfAdmission";
            monthOfAdmissionDataGridViewTextBoxColumn.MinimumWidth = 8;
            monthOfAdmissionDataGridViewTextBoxColumn.Name = "monthOfAdmissionDataGridViewTextBoxColumn";
            monthOfAdmissionDataGridViewTextBoxColumn.Width = 205;
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            gradeDataGridViewTextBoxColumn.MinimumWidth = 8;
            gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            gradeDataGridViewTextBoxColumn.Width = 95;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            // 
            // deleteButton
            // 
            deleteButton.AutoSize = true;
            deleteButton.Location = new Point(926, 403);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(112, 35);
            deleteButton.TabIndex = 1;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteLastStudent_Click;
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.Location = new Point(805, 9);
            labelID.Name = "labelID";
            labelID.Size = new Size(30, 25);
            labelID.TabIndex = 2;
            labelID.Text = "ID";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(926, 6);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(150, 31);
            textBoxID.TabIndex = 3;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(926, 43);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(150, 31);
            textBoxFirstName.TabIndex = 5;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new Point(805, 46);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(45, 25);
            labelFirstName.TabIndex = 4;
            labelFirstName.Text = "First";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(926, 80);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(150, 31);
            textBoxLastName.TabIndex = 7;
            // 
            // labelLastName
            // 
            labelLastName.AutoSize = true;
            labelLastName.Location = new Point(805, 83);
            labelLastName.Name = "labelLastName";
            labelLastName.Size = new Size(43, 25);
            labelLastName.TabIndex = 6;
            labelLastName.Text = "Last";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(926, 117);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(150, 31);
            textBoxAddress.TabIndex = 9;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(805, 120);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(77, 25);
            labelAddress.TabIndex = 8;
            labelAddress.Text = "Address";
            // 
            // addButton
            // 
            addButton.AutoSize = true;
            addButton.Location = new Point(926, 362);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 35);
            addButton.TabIndex = 10;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // textBoxAdmitMonth
            // 
            textBoxAdmitMonth.Location = new Point(926, 154);
            textBoxAdmitMonth.Name = "textBoxAdmitMonth";
            textBoxAdmitMonth.Size = new Size(150, 31);
            textBoxAdmitMonth.TabIndex = 12;
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.Location = new Point(805, 157);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(119, 25);
            labelMonth.TabIndex = 11;
            labelMonth.Text = "Admit Month";
            // 
            // textBoxGrade
            // 
            textBoxGrade.Location = new Point(926, 191);
            textBoxGrade.Name = "textBoxGrade";
            textBoxGrade.Size = new Size(150, 31);
            textBoxGrade.TabIndex = 14;
            // 
            // labelGrade
            // 
            labelGrade.AutoSize = true;
            labelGrade.Location = new Point(805, 194);
            labelGrade.Name = "labelGrade";
            labelGrade.Size = new Size(59, 25);
            labelGrade.TabIndex = 13;
            labelGrade.Text = "Grade";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1088, 450);
            Controls.Add(textBoxGrade);
            Controls.Add(labelGrade);
            Controls.Add(textBoxAdmitMonth);
            Controls.Add(labelMonth);
            Controls.Add(addButton);
            Controls.Add(textBoxAddress);
            Controls.Add(labelAddress);
            Controls.Add(textBoxLastName);
            Controls.Add(labelLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(labelFirstName);
            Controls.Add(textBoxID);
            Controls.Add(labelID);
            Controls.Add(deleteButton);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource studentBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn monthOfAdmissionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private Button deleteButton;
        private Label labelID;
        private TextBox textBoxID;
        private TextBox textBoxFirstName;
        private Label labelFirstName;
        private TextBox textBoxLastName;
        private Label labelLastName;
        private TextBox textBoxAddress;
        private Label labelAddress;
        private Button addButton;
        private TextBox textBoxAdmitMonth;
        private Label labelMonth;
        private TextBox textBoxGrade;
        private Label labelGrade;
    }
}
