using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeDB2.Content
{
    [Table("Employee")]
    public class Employee : IDDB
    {
        [Display(Name = "Name")]
        public string NameEmp { get; set; }
        [Display(Name = "Salary")]
        public decimal Salary { get; set; }

        public virtual IDDB id { get; set; }

    }
}
