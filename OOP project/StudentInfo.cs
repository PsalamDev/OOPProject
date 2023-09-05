using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    public class StudentInfo : BaseEntity
    {
        public string Surname { get; set; }

        public string firstname { get; set; }

        public string lastname { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

    }
}
 