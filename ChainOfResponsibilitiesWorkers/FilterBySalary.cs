using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainOfResponsibilitiesWorkers
{
     class FilterBySalary : FilterBase
    {
        public FilterBySalary(FilterBase nextFilter) : base(nextFilter)
        {
        }

        public override void OperateFilter(ref List<Kolhoznik> result)
        {
            if (Program.form1.checkBoxSalary.CheckState == CheckState.Checked)
            {
                var filtered = result.Where(item => (item.Salary >= (int)Program.form1.numericUpDownMinSalary.Value && item.Age <= (int)Program.form1.numericUpDownMaxSalary.Value));
                result = new List<Kolhoznik>(filtered.ToList());
                //for (int i = 0; i < sacrifice.Count; i++)
                //{

                //    if (sacrifice[i].Salary < Program.form1.numericUpDownMinSalary.Value || sacrifice[i].Salary > Program.form1.numericUpDownMaxSalary.Value)
                //    {
                //        sacrifice.RemoveAt(i);
                //    }
                //}
            }
            base.OperateFilter(ref result);
        }
    }
}
