using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmployeeData.Models
{
    public class RubixEmployees
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }
        public string Emp_Name { get; set; }

        public string Emp_Salary { get; set;}

    }
}
