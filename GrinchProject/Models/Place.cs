using System;
using System.Collections.Generic;

namespace GrinchProject.Models;

public partial class Place
{
    public int Id { get; set; }

    public string Area { get; set; } = null!;

    public string? DayImagePath { get; set; }

    public string? NightImagePath { get; set; }

    public virtual ICollection<Character> Characters { get; } = new List<Character>();
}
