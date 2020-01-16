using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class Student
    {
        private string _filePath = "student.json";
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public DateTime DateofBirth { get; set; }
        public string ContactNo { get; set; }
        public string Gender { get; set; }
        public string EnrolledProgram { get; set; }
        public DateTime RegistrationDate { get; set; }
        public void Add(Student info)
        {
            Random r = new Random();
            info.Id = r.Next(1000, 9999);
            string data = JsonConvert.SerializeObject(info, Formatting.None);
            Utility.WriteToTextFile(_filePath, data);

        }
        public Student Edit(int id)
        {
            Student obj = new Student();
            return obj;
        }
        public void Edit(Student info)
        {
            //invoking list method of the student class to get student list
            List<Student> list = List();
            //using linq to select student having the specified id
            Student s = list.Where(x => x.Id == info.Id).FirstOrDefault();
            //removing  student object that is to be updated from the list
            list.Remove(s);
            //adding the updated student object to the list
            list.Add(info);
            //converting list of student to string
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            //invoking method of utility class 
            Utility.WriteToTextFile(_filePath, data, false);
        }
        public void Delete(int id)
        {
            //invoking list method of the student class to get student list
            List<Student> list = List();
            //using linq to select student having the specified id
            Student s = list.Where(x => x.Id == id).FirstOrDefault();
            //removing  student object that is to be updated from the list
            list.Remove(s);
            //converting list of student to string
            int count = list.Count;
            string data = JsonConvert.SerializeObject(list, Formatting.None);
            //invoking method of utility class 
            Utility.WriteToTextFile(_filePath, data, false,count);
        }
        public Student Detail(int id)
        {
            Student obj = new Student();
            return obj;
        }
        public List<Student> List()
        {
            string d = Utility.ReadFromTextFile(_filePath);
            if (d != null)
            {
                List<Student> lst = JsonConvert.DeserializeObject<List<Student>>(d);
                return lst;
            }
            return null;
        }

        public List<Student> sortByAscendingFName(List<Student> studentList)
        {
            int id;
            string name;
            string address;
            string email;
            string program;
            DateTime dateOB;
            string contacts;
            string gender;
            DateTime registered;

            if (studentList != null)
            {
                for (int i = 0; i < studentList.Count - 1; i++)
                {
                    for (int j = i + 1; j < studentList.Count; j++)
                    {
                        if (studentList[i].Name.CompareTo(studentList[j].Name) > 0)
                        {
                            id = studentList[i].Id;
                            studentList[i].Id = studentList[j].Id;
                            studentList[j].Id = id;

                            registered = studentList[i].RegistrationDate;
                            studentList[i].RegistrationDate = studentList[j].RegistrationDate;
                            studentList[j].RegistrationDate = registered;

                            name = studentList[i].Name;
                            studentList[i].Name = studentList[j].Name;
                            studentList[j].Name = name;

                            dateOB = studentList[i].DateofBirth;
                            studentList[i].DateofBirth = studentList[j].DateofBirth;
                            studentList[j].DateofBirth = dateOB;

                            address = studentList[i].Address;
                            studentList[i].Address = studentList[j].Address;
                            studentList[j].Address = address;

                            gender = studentList[i].Gender;
                            studentList[i].Gender = studentList[j].Gender;
                            studentList[j].Gender = gender;

                            contacts = studentList[i].ContactNo;
                            studentList[i].ContactNo = studentList[j].ContactNo;
                            studentList[j].ContactNo = contacts;

                            program = studentList[i].EnrolledProgram;
                            studentList[i].EnrolledProgram = studentList[j].EnrolledProgram;
                            studentList[j].EnrolledProgram = program;

                            email = studentList[i].Email;
                            studentList[i].Email = studentList[j].Email;
                            studentList[j].Email = email;
                        }
                    }
                }
                return studentList;
            }
            return null;
        }

        public List<Student> sortByDescendingFName(List<Student> studentList)
        {
            int id;
            string name;
            string address;
            string email;
            string program;
            DateTime dateOB;
            string contacts;
            string gender;
            DateTime registered;

            if (studentList != null)
            {
                for (int i = 0; i < studentList.Count - 1; i++)
                {
                    for (int j = i + 1; j < studentList.Count; j++)
                    {
                        if (studentList[i].Name.CompareTo(studentList[j].Name) < 0)
                        {
                            id = studentList[i].Id;
                            studentList[i].Id = studentList[j].Id;
                            studentList[j].Id = id;

                            registered = studentList[i].RegistrationDate;
                            studentList[i].RegistrationDate = studentList[j].RegistrationDate;
                            studentList[j].RegistrationDate = registered;

                            name = studentList[i].Name;
                            studentList[i].Name = studentList[j].Name;
                            studentList[j].Name = name;

                            dateOB = studentList[i].DateofBirth;
                            studentList[i].DateofBirth = studentList[j].DateofBirth;
                            studentList[j].DateofBirth = dateOB;

                            address = studentList[i].Address;
                            studentList[i].Address = studentList[j].Address;
                            studentList[j].Address = address;

                            gender = studentList[i].Gender;
                            studentList[i].Gender = studentList[j].Gender;
                            studentList[j].Gender = gender;

                            contacts = studentList[i].ContactNo;
                            studentList[i].ContactNo = studentList[j].ContactNo;
                            studentList[j].ContactNo = contacts;

                            program = studentList[i].EnrolledProgram;
                            studentList[i].EnrolledProgram = studentList[j].EnrolledProgram;
                            studentList[j].EnrolledProgram = program;

                            email = studentList[i].Email;
                            studentList[i].Email = studentList[j].Email;
                            studentList[j].Email = email;
                        }
                    }
                }
                return studentList;
            }
            return null;
        }

        public List<Student> sortByAscendingRegisteredDate(List<Student> studentList)
        {
            int id;
            string name;
            string address;
            string email;
            string program;
            DateTime dateOB;
            string contacts;
            string gender;
            DateTime registered;

            if (studentList != null)
            {
                for (int i = 0; i < studentList.Count - 1; i++)
                {
                    for (int j = i + 1; j < studentList.Count; j++)
                    {
                        if (studentList[i].RegistrationDate.CompareTo(studentList[j].RegistrationDate) > 0)
                        {
                            id = studentList[i].Id;
                            studentList[i].Id = studentList[j].Id;
                            studentList[j].Id = id;

                            registered = studentList[i].RegistrationDate;
                            studentList[i].RegistrationDate = studentList[j].RegistrationDate;
                            studentList[j].RegistrationDate = registered;

                            name = studentList[i].Name;
                            studentList[i].Name = studentList[j].Name;
                            studentList[j].Name = name;

                            dateOB = studentList[i].DateofBirth;
                            studentList[i].DateofBirth = studentList[j].DateofBirth;
                            studentList[j].DateofBirth = dateOB;

                            address = studentList[i].Address;
                            studentList[i].Address = studentList[j].Address;
                            studentList[j].Address = address;

                            gender = studentList[i].Gender;
                            studentList[i].Gender = studentList[j].Gender;
                            studentList[j].Gender = gender;

                            contacts = studentList[i].ContactNo;
                            studentList[i].ContactNo = studentList[j].ContactNo;
                            studentList[j].ContactNo = contacts;

                            program = studentList[i].EnrolledProgram;
                            studentList[i].EnrolledProgram = studentList[j].EnrolledProgram;
                            studentList[j].EnrolledProgram = program;

                            email = studentList[i].Email;
                            studentList[i].Email = studentList[j].Email;
                            studentList[j].Email = email;
                        }
                    }
                }
                return studentList;
            }
            return null;
        }

        public List<Student> sortByDescendingRegisteredDate(List<Student> studentList)
        {
            int id;
            string name;
            string address;
            string email;
            string program;
            DateTime dateOB;
            string contacts;
            string gender;
            DateTime registered;

            if (studentList != null)
            {
                for (int i = 0; i < studentList.Count - 1; i++)
                {
                    for (int j = i + 1; j < studentList.Count; j++)
                    {
                        if (studentList[i].RegistrationDate.CompareTo(studentList[j].RegistrationDate) < 0)
                        {
                            id = studentList[i].Id;
                            studentList[i].Id = studentList[j].Id;
                            studentList[j].Id = id;

                            registered = studentList[i].RegistrationDate;
                            studentList[i].RegistrationDate = studentList[j].RegistrationDate;
                            studentList[j].RegistrationDate = registered;

                            name = studentList[i].Name;
                            studentList[i].Name = studentList[j].Name;
                            studentList[j].Name = name;

                            dateOB = studentList[i].DateofBirth;
                            studentList[i].DateofBirth = studentList[j].DateofBirth;
                            studentList[j].DateofBirth = dateOB;

                            address = studentList[i].Address;
                            studentList[i].Address = studentList[j].Address;
                            studentList[j].Address = address;

                            gender = studentList[i].Gender;
                            studentList[i].Gender = studentList[j].Gender;
                            studentList[j].Gender = gender;

                            contacts = studentList[i].ContactNo;
                            studentList[i].ContactNo = studentList[j].ContactNo;
                            studentList[j].ContactNo = contacts;

                            program = studentList[i].EnrolledProgram;
                            studentList[i].EnrolledProgram = studentList[j].EnrolledProgram;
                            studentList[j].EnrolledProgram = program;

                            email = studentList[i].Email;
                            studentList[i].Email = studentList[j].Email;
                            studentList[j].Email = email;
                        }
                    }
                }
                return studentList;
            }
            return null;
        }
    }
}
