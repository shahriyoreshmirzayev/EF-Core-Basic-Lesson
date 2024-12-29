using System;
using System.Collections.Generic;

namespace Entity_Framework_Coreda_amaliyot.Model;

public partial class Teacher
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int SubjectId { get; set; }

    public virtual Subject Subject { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    public override string ToString()
    {
        return $"{FirstName}, {LastName}";
    }
}
