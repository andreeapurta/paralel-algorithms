using StudentProj_EntityFramework;
using System;
using System.Windows.Forms;

namespace StudentManagerView
{
    public partial class MyForm : System.Windows.Forms.Form
    {
        private StudentContext context;
        private StudentRepository studentRepository;

        public MyForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new StudentContext();
            studentRepository = new StudentRepository(context);
            ViewDataGrid();
        }

        private void ViewDataGrid()
        {
            dataGridView.Rows.Clear();
            foreach (var student in studentRepository.GetAll())
            {
                object[] row = new object[]
                {
                    student.Id,
                    student.Name,
                    student.Department,
                    student.Year,
                    student.Average,
                };
                dataGridView.Rows.Add(row);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Student student = new Student(nameTxtBox.Text, specializareTxtBox.Text, Convert.ToInt32(yearTxtBox.Text), Convert.ToInt32(averageTxtBox.Text));
            studentRepository.Add(student);
            ViewDataGrid();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView.CurrentRow;
            if (selectedRow != null)
            {
                var newStudent = new Student()
                {
                    Id = Convert.ToInt32(idTxtbox.Text),
                    Name = nameTxtBox.Text,
                    Department = specializareTxtBox.Text,
                    Year = Convert.ToInt32(yearTxtBox.Text),
                    Average = Convert.ToInt32(averageTxtBox.Text)
                };
                studentRepository.Update(newStudent);
            }

            ViewDataGrid();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView.CurrentRow;
            if (selectedRow != null)
            {
                if (idTxtbox.Text != "")
                {
                    studentRepository.Remove(Convert.ToInt32(idTxtbox.Text));
                }
            }
            ViewDataGrid();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var x = dataGridView.CurrentRow;
            if (x.Cells[0].Value != null)
            {
                idTxtbox.Text = (x.Cells[0].Value).ToString();
            }
            else
            {
                idTxtbox.Text = "";
            }
            if (x.Cells[1].Value != null)
            {
                nameTxtBox.Text = x.Cells[1].Value.ToString();
            }
            else
            {
                nameTxtBox.Text = "";
            }
            if (x.Cells[2].Value != null)
            {
                specializareTxtBox.Text = x.Cells[2].Value.ToString();
            }
            else
            {
                specializareTxtBox.Text = "";
            }
            if (x.Cells[3].Value != null)
            {
                yearTxtBox.Text = (x.Cells[3].Value).ToString();
            }
            else
            {
                yearTxtBox.Text = "";
            }
            if (x.Cells[4].Value != null)
            {
                averageTxtBox.Text = (x.Cells[4].Value).ToString();
            }
            else
            {
                averageTxtBox.Text = "";
            }
        }
    }
}