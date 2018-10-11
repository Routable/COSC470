using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3P2
{
    public class StudentDetails
    {
        private string name;
        private int id; 

        public StudentDetails(string studentname, int studentid)
        {
            name = studentname;
            id = studentid;
        }

        public int getId()
        {

            return id;
        }

        public void setId(int newid)
        {
            id = newid;
        }

        public string getName()
        {

            return name;
        }

        public void setName(string newname)
        {
            name = newname;
        }
    }
    public class Program
    {
        public string Login(string username, string password)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password))
            {
                return "Username or Password could not be empty.";
            } else if(username == "Admin" && password == "Admin")
            {
                return "Welcome User/Admin";
            } else
            {
                return "Incorrect login...";
            }
        }

        public List<StudentDetails> AllUsers()
        {
            List <StudentDetails> li = new List<StudentDetails>();
            li.Add(new StudentDetails("steven", 300168440));
            li.Add(new StudentDetails("john", 300168440));
            li.Add(new StudentDetails("test", 300168440));
            return li;
        }
        

        static void Main(string[] args)
        {
        }
    }
}
