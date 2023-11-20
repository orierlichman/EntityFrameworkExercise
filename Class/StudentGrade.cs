using System;
using System.Collections.Generic;

namespace Class;

public partial class StudentGrade
{
    public int GradeId { get; set; }

    public int Score { get; set; }

    public int StudentId { get; set; }

    public virtual Student Student { get; set; } = null!;
}
