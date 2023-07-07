using System;
using System.Collections.Generic;

namespace WebAPI1.Models;

public partial class Employee
{
    public int Id { get; set; }

    public int FkdeptId { get; set; }

    public string EmpName { get; set; } = null!;

    public decimal Salary { get; set; }

    public bool IsActive { get; set; }

    public virtual Department Fkdept { get; set; } = null!;
}
