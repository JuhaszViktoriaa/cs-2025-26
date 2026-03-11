using System;
using System.Collections.Generic;

namespace ClassFundProject.DbMysqlModels;

public partial class Classfund
{
    public int Id { get; set; }

    public string StudentName { get; set; } = string.Empty;

    public string Month { get; set; } = string.Empty;

    public int Amount { get; set; }

    public override string ToString()
    {
        return $"{Id}. {StudentName}, {Month}: {Amount}";
    }
}
