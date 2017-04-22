using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace HomeDB2.Content
{
    [Table("Departmen")]
    public class Department : IDDB
    {
        [Display(Name = "Name")]
        public string NameDep { get; set; }

        public virtual IDDB id { get; set; }

    }
}
