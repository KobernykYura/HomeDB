using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebService.Items
{
    [Table("Department")]
    public class Department : ID
    {
        [DisplayName("Название департамента")]
        public string Name { get; set; }
    }
}
