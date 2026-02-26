using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_Builder;

public class EmployeeReport
{
    public string Header { get; init; }
    public string Body { get; init; }
    public string Footer { get; init; }

    public override string ToString() =>
        $"{Header}\n{Body}\n{Footer}";
}

