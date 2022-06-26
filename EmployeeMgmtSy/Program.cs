using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMgmtSy
{
    class Program
    {
        class Employee
        {
            public int EmpNo;
            public string EmpName;
            public double Salary;
            public double HRA;
            public double TA;
            public double DA;
            public double PF;
            public double TDS;
            public double NetSalary;
            public double GrossSalary;

            


            public void EmployeeData(int EmpNo, string EmpName, double Salary, double HRA, double TA, double DA, double PF, double TDS)
            {

                this.EmpNo = EmpNo;
                this.EmpName = EmpName;
                this.Salary = Salary;
                this.HRA = HRA;
                this.TA = TA;
                this.DA = DA;
                this.PF = PF;
                this.TDS = TDS;

                //static void Main(string[] args)
        {
        }
    

