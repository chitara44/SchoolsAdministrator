using SchoolsAdministrator.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolsAdministrator.Web.Models
{
    public class ClassroomModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
    }
}
