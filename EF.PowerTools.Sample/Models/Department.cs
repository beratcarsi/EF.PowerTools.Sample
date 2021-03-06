using System;
using System.Collections.Generic;

namespace EF.PowerTools.Sample.Models
{
    public partial class Department
    {
        public Department()
        {
            this.Courses = new List<Course>();
        }

        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<int> Administrator { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
