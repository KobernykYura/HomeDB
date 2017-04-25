using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace HomeEFCodeFirst.Entitys
{
    public class Employee : ID
    {
        [DisplayName("Имя")]
        public string Name { get; set; }

        [DisplayName("Зарплата")]
        public decimal Salary { get; set; }

        [DisplayName("Возраст")]
        public int Age { get; set; }

        [Browsable(false)]
        public int? DepartmentId { get; set; }

        [Browsable(false)]
        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        [NotMapped]
        [DisplayName("Департамент")]
        public string DepartmentName => this?.Department?.Name;
    }
}
