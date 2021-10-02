using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolsAdministrator.Core.Entities
{
    public class ClassroomSaveModel
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int SchoolId { get; set; }
    }
}
