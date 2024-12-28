using System;
using System.Collections.Generic;

namespace Entity_Framework_Coreda_amaliyot.Model;

public partial class Grade
{
    public int Id { get; set; }

    public string GradeName { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
