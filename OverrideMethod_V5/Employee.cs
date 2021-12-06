using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMethod_V5
{
    public class Employee : Person
    {
        // Referance number to the employee
        // should not be change after and object as been made
        public int Id { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">
        /// Used to referance the eployee later
        /// </param>
        public Employee(int id)
        {
            Id = id;
        }
    }
}
