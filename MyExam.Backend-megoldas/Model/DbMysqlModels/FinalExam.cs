using System;
using System.Collections.Generic;

namespace MyExam.Backend.Model.DbMysqlModels;

public partial class FinalExam
{
    public int Id { get; set; }

    public string Név { get; set; }

    public string Osztály { get; set; }

    public string Tantárgy { get; set; }

    public int Jegy { get; set; }
}
