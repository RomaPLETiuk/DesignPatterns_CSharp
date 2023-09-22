using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_Bilder_
{
    public class EmployeeReport
    {
        public string Head { get; set; }
        public string Body { get; set; }
        public string Foot { get; set; }

        public override string ToString() =>
            new StringBuilder()
             .Append(Head)
            .Append(Body)
            .Append(Foot)
            .ToString();
        
    }
}
