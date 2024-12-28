using System;
using System.Collections.Generic;

namespace Entity_Framework_Coreda_amaliyot.Model;

public partial class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly BirthDate { get; set; }

    public int GradeId { get; set; }

    public virtual Grade Grade { get; set; } = null!;

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
