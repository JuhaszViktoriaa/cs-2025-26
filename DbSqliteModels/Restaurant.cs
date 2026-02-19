using System;
using System.Collections.Generic;

namespace MyExam.Desktop.DbSqliteModels;

public partial class Restaurant
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Owner { get; set; } = string.Empty;

    public int Income { get; set; }
}
