using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_Bilder_
{
    public interface IEmployeeReportBilder
    {
        IEmployeeReportBilder BildHead();
        IEmployeeReportBilder BildBody();
        IEmployeeReportBilder BildFoot();
        EmployeeReport GetReport();
    }
}
