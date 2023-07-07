using System;
using System.Collections.Generic;

namespace WebAPI1.Models;

public partial class Department
{
    public int Id { get; set; }

    public string DeptName { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
