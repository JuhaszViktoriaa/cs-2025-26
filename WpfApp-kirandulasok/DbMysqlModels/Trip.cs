using System;
using System.Collections.Generic;

namespace WpfApp1.DbMysqlModels;

public partial class Trip
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Gender { get; set; } = string.Empty;

    public int Desposit { get; set; }

    public string HasMedicalNote { get; set; } = string.Empty;
}
