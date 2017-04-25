using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace FormClient.Items
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
        public Department Department { get; set; }

        [DisplayName("Департамент")]
        public string DepartmentName => this?.Department?.Name;
    }
}
