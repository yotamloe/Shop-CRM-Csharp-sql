using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsApplication1
{

    public class Employee
    {
        private int employeeID;
        private string employeeName;
        private string gender;
        private DateTime dob;
        private EmplyeeStatus status;
        private Role role;
        private DateTime startDate;
        private string password;

        public Employee(int id, string Name, string gender, DateTime DOB, EmplyeeStatus status, Role role, DateTime startDate, string password,  bool is_new)
        {
            this.employeeID = id;
            this.employeeName = Name;
            this.gender = gender;
            this.dob = DOB;
            this.status = status;
            this.role = role;
            this.startDate = startDate;
            this.password = password;
          
        }
        public int getID()
        {
            return this.employeeID;
        }

        public string getName()
        {
            return this.employeeName;
        }

        public string getGender()
        {
            return this.gender;
        }
        public DateTime getDOB()
        {
            return this.dob;
        }

        public EmplyeeStatus getStatus()
        {
            return this.status;
        }
        public Role getRole()
        {
            return this.role;
        }
        public DateTime getStartDate()
        {
            return this.startDate;
        }
        public void setStatus(EmplyeeStatus status)
        {
            this.status = status;
        }
        public void setRole(Role role)
        {
            this.role = role;
        }
        public string getPassword()
        {
            return this.password;
        }


    }
}