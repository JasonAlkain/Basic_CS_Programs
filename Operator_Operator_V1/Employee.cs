using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Operator_V1
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }





        public static bool operator ==(Employee emp_1, Employee emp_2)
            => emp_1.Id == emp_2.Id;

        public static bool operator !=(Employee emp_1, Employee emp_2)
            => emp_1.Id != emp_2.Id;
    }
}
