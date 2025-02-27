﻿using System;
using System.Collections.Generic;

namespace readFromVaulte.Models;

public partial class RefCertificateType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Certificate> Certificates { get; set; } = new List<Certificate>();
}
