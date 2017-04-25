using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace FormClient.Items
{
    public class Department : ID
    {
        [DisplayName("Название департамента")]
        public string Name { get; set; }
    }
}
