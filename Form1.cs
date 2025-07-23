using System.ComponentModel;

namespace Assignment_3._3
{
    public partial class Form1 : Form
    {
        List<Student> students;
        public Form1()
        {
            InitializeComponent();
            setBindings();
        }

        private void setBindings()
        {
            students = Student.MockData();
            studentBindingSource.DataSource = students;
        }

        private void updateBindings()
        {
            studentBindingSource.ResetBindings(false);
        }

        private void deleteLastStudent_Click(object sender, EventArgs e)
        {
            if(students.Count > 0) 
                students.RemoveAt(students.Count - 1);
            updateBindings();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            students.Add(new Student() { FirstName = textBoxFirstName.Text, LastName = textBoxLastName.Text, Id = Convert.ToInt32(textBoxID.Text), Address = textBoxAddress.Text, Grade = textBoxGrade.Text[0] });
            updateBindings();
        }
    }
}
