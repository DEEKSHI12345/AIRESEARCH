using System;
using System.Collections.Generic;

namespace BigEmployee_PL.BigEmployee_Entities;

public partial class EmployeeDataRecord
{
    public int EmplId { get; set; }
    public string? Education { get; set; }

    public int? JoiningYear { get; set; }

    public string? City { get; set; }

    public int? PaymentTier { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public string? EverBenched { get; set; }

    public int? ExperienceInCurrentDomain { get; set; }

    public string? LeaveOrNot { get; set; }
}
