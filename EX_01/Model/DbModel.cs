using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EX_01.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        [Column(TypeName ="date"),DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
        public DateTime joindate { get; set; }
        public bool Ismarrid { get; set; }
        public string Addres { get; set; }
    }
    public class EMPDB : DbContext
    {
        public EMPDB(DbContextOptions<EMPDB>options):base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
