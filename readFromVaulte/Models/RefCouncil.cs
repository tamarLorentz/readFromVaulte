using System;
using System.Collections.Generic;

namespace readFromVaulte.Models;

public partial class RefCouncil
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
