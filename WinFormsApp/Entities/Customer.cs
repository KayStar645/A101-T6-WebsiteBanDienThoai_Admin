using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Common;

namespace WinFormsApp.Entities
{
    public class Customer : BaseEntity
    {
        public string? InternalCode { get; set; }
        public string? Phone { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
    }
}
