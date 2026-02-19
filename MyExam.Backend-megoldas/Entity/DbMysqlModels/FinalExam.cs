using System;
using System.Collections.Generic;

namespace MyExam.Backend.Entity.DbMysqlModels;

public partial class FinalExam
{
    public int Id { get; set; }

    public string Név { get; set; } = string.Empty;

    public string Osztály { get; set; } = string.Empty;

    public string Tantárgy { get; set; } = string.Empty;

    public int Jegy { get; set; }
}
