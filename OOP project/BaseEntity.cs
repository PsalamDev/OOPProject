using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_project
{
    public class BaseEntity
    {
        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        public Guid Id { get; set; }

    }

    public class BaseEntity2
    {
        private int _companyId;

        public BaseEntity2(int companyId)
        {
            _companyId = companyId;
        }
        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }
         
        public Guid Id { get; set; }

    }
} 