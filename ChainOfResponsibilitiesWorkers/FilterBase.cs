using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilitiesWorkers
{
     class FilterBase
    {
        public FilterBase NextFilter { get; set; }
        public FilterBase(FilterBase nextFilter)
        {
            NextFilter = nextFilter;
        }

        public virtual void OperateFilter(ref List<Kolhoznik> result)
        {
            NextFilter?.OperateFilter(ref result);
        }
    }
}
