using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_Builder;

public class EmployeeReportDirector
{
    private readonly IEmployeeReportBuilder _builder;

    public EmployeeReportDirector(IEmployeeReportBuilder builder)
    {
        _builder = builder;
    }

    public EmployeeReport BuildFullReport()
    {
        _builder.BuildHeader();
        _builder.BuildBody();
        _builder.BuildFooter();

        return _builder.GetResult();
    }
}

