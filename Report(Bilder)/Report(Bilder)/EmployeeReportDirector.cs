using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_Bilder_
{
    public class EmployeeReportDirector
    {
        private readonly IEmployeeReportBilder _builder;
        public EmployeeReportDirector(IEmployeeReportBilder builder)
        {
            _builder = builder;
        }

        public void Build()
        {
            _builder
                .BildHead()
                .BildBody()
                .BildFoot();

        }
        //public void BuildWithoutFoot()
        //{
        //    _builder
        //        .BildHead()
        //        .BildBody();
               
        //}
    }
}
