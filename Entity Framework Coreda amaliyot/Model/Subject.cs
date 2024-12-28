using System;
using System.Collections.Generic;

namespace Entity_Framework_Coreda_amaliyot.Model;

public partial class Subject
{
    public int Id { get; set; }

    public string SubjectName { get; set; } = null!;

    public virtual ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
}
