using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            BindGrid();

            btnUpdate.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(Valid())
            {
                Student obj = new Student();
                string firstName = FirstNameTb.Text;
                string lastName = LastNameTb.Text;
                obj.Name = firstName + " " + lastName;
                obj.Address = AddressTb.Text;
                obj.Email = EmailTb.Text;
                obj.DateofBirth = agePicker.Value;
                obj.ContactNo = ContactNoTb.Text;
                obj.Gender = GenderCb.SelectedItem.ToString();
                obj.RegistrationDate = RegistrationDatePicker.Value;
                obj.EnrolledProgram = ProgramCb.SelectedItem.ToString();
                obj.Add(obj);
                BindGrid();
                Clear();
            }
        }

        private bool Valid()
        {
            if (FirstNameTb.Text == "" && LastNameTb.Text == "" && AddressTb.Text == "" && EmailTb.Text == "" && ContactNoTb.Text == "")
            {
                MessageBox.Show("Please Enter Valid Data");
                return false;
            }
            return true;
        }
        private void BindGrid()
        {
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            DataTable dt = Utility.ConvertToDataTable(listStudents);
            dataGridStudents.DataSource = dt;
            BindChart(listStudents);
        }
        private void Clear()
        {
            IdTb.Text = "";
            FirstNameTb.Text = "";
            LastNameTb.Text = "";
            AddressTb.Text = "";
            EmailTb.Text = "";
            agePicker.Value = DateTime.Today;
            ContactNoTb.Text = "";
            GenderCb.SelectedItem = null;
            ProgramCb.SelectedItem = null;
            RegistrationDatePicker.Value = DateTime.Today;

        }

        private void dataGridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Student obj = new Student();
            if (e.ColumnIndex == 0)
            {
                //get the value of the clicked rows id column
                string value = dataGridStudents[2, e.RowIndex].Value.ToString();
                int id = 0;
                if (String.IsNullOrEmpty(value))
                {
                    MessageBox.Show("Invalid Data");
                }
                else
                {
                    id = int.Parse(value);
                    Student s = obj.List().Where(x => x.Id == id).FirstOrDefault();
                    IdTb.Text = s.Id.ToString();
                    FirstNameTb.Text = s.Name.Split(' ')[0];
                    LastNameTb.Text = s.Name.Split(' ')[1];
                    AddressTb.Text = s.Address;
                    EmailTb.Text = s.Email;
                    agePicker.Value = s.DateofBirth;
                    ContactNoTb.Text = s.ContactNo;
                    GenderCb.SelectedItem = s.Gender;
                    ProgramCb.SelectedItem = s.EnrolledProgram;
                    RegistrationDatePicker.Value = s.RegistrationDate;
                    btnSubmit.Visible = false;
                    btnUpdate.Visible = true;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                string value = dataGridStudents[2, e.RowIndex].Value.ToString();
                if(String.IsNullOrEmpty(value))
                {
                    MessageBox.Show("Unable to delete empty row");
                }
                else
                {
                    string message = "Do you want to Delete this Record?";
                    string title = "Delete Confirmation";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.OK)
                    {
                        //get the value of the clicked rows id column
                        string values = dataGridStudents[2, e.RowIndex].Value.ToString();
                        obj.Delete(int.Parse(values));
                        BindGrid();
                        MessageBox.Show("Record Successfully Deleted");
                    }
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(Valid())
            {
                Student obj = new Student();
                obj.Id = int.Parse(IdTb.Text);
                string firstName = FirstNameTb.Text;
                string lastName = LastNameTb.Text;
                obj.Name = firstName + " " + lastName;
                obj.Address = AddressTb.Text;
                obj.Email = EmailTb.Text;
                obj.DateofBirth = agePicker.Value;
                obj.ContactNo = ContactNoTb.Text;
                obj.Gender = GenderCb.SelectedItem.ToString();
                obj.RegistrationDate = RegistrationDatePicker.Value;
                obj.EnrolledProgram = ProgramCb.SelectedItem.ToString();
                obj.Edit(obj);
                BindGrid();
                Clear();
                btnUpdate.Visible = false;
                btnSubmit.Visible = true;
            }
        }

        private void sortingCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student = new Student();
            List<Student> studentList = student.List();
            if (sortingCB.SelectedItem.ToString().Equals("Name(Ascending)"))
            {
                List<Student> list = student.sortByAscendingFName(studentList);
                DataTable dt = Utility.ConvertToDataTable(list);
                dataGridStudents.DataSource = dt;
            }
            else if(sortingCB.SelectedItem.ToString().Equals("Name(Descending)"))
            {
                List<Student> list = student.sortByDescendingFName(studentList);
                DataTable dt = Utility.ConvertToDataTable(list);
                dataGridStudents.DataSource = dt;
            }
            else if (sortingCB.SelectedItem.ToString().Equals("Registered Date (Ascending)"))
            {
                List<Student> list = student.sortByAscendingRegisteredDate(studentList);
                DataTable dt = Utility.ConvertToDataTable(list);
                dataGridStudents.DataSource = dt;
            }
            else if (sortingCB.SelectedItem.ToString().Equals("Registered Date (Descending)"))
            {
                List<Student> list = student.sortByDescendingRegisteredDate(studentList);
                DataTable dt = Utility.ConvertToDataTable(list);
                dataGridStudents.DataSource = dt;
            }
        }

        private void BindChart(List<Student> lst)
        {
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => l.EnrolledProgram)
                    .Select(cl => new
                    {
                        EnrolledProgram = cl.First().EnrolledProgram,
                        Count = cl.Count().ToString()
                    }).ToList();
                DataTable dt = Utility.ConvertToDataTable(result);
                ProgramChart.DataSource = dt;
                ProgramChart.Name = "Enrolled Programs";
                ProgramChart.Series["Series1"].XValueMember = "EnrolledProgram";
                ProgramChart.Series["Series1"].YValueMembers = "Count";
                ProgramChart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                ProgramChart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                this.ProgramChart.Titles.Remove(this.ProgramChart.Titles.FirstOrDefault());
                this.ProgramChart.Titles.Add("Program Enrolled Chart");
                ProgramChart.Series["Series1"].IsValueShownAsLabel = true;
            }
        }
        private void WeeklyRptPicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime DTselected = WeeklyRptPicker.Value;
            var CurrCult = System.Threading.Thread.CurrentThread.CurrentCulture;
            var seperate = DTselected.DayOfWeek - CurrCult.DateTimeFormat.FirstDayOfWeek;
            if (seperate < 0)
                seperate += 7;
            var FdayofWeek = DTselected.AddDays(-seperate).Date;
            var LdayofWeek = DTselected.AddDays(7);
            WeeklyReportGrid.Rows.Clear();
            Student obj = new Student();
            List<Student> listStuds = obj.List();
            var converting = listStuds.Where(s => s.RegistrationDate >= FdayofWeek && s.RegistrationDate < LdayofWeek);

            int comp = 0;
            int net = 0;
            int mult = 0;

            foreach(Student stud in converting)
            {
                if(stud.EnrolledProgram == "Computing")
                {
                    comp += 1;
                }
                else if(stud.EnrolledProgram == "Networking")
                {
                    net += 1;
                }
                else if(stud.EnrolledProgram == "Multimedia")
                {
                    mult += 1;
                }
            }

            WeeklyReportGrid.Rows.Add(new Object[] { "Computing", comp });
            WeeklyReportGrid.Rows.Add(new Object[] { "Networking", net });
            WeeklyReportGrid.Rows.Add(new Object[] { "Multimedia", mult });

            if(comp == 0 && net == 0 && mult == 0)
            {
                //empty
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void lblContactNo_Click(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
