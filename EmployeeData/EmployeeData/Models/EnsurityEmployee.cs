using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations;
namespace EmployeeData.Models
{
    public class EnsurityEmployee
    {
        [Key]
        //[DatabaseGeneratedAttribute(DatabaseGeneratedOption.None)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
