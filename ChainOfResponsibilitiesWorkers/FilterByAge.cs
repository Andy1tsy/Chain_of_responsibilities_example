using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ChainOfResponsibilitiesWorkers
{
    class FilterByAge : FilterBase
    {
        public FilterByAge(FilterBase nextFilter) : base(nextFilter)
        {
        }

        public override void OperateFilter(ref List<Kolhoznik> result)
        {
            if (Program.form1.checkBoxAge.CheckState == CheckState.Checked)
            {
                var filtered = result.Where(item => (item.Age >= (int)Program.form1.numericUpDownMinAge.Value && item.Age <= (int)Program.form1.numericUpDownMaxAge.Value));
                result = new List<Kolhoznik>( filtered.ToList());
                //for (int i = 0; i < sacrifice.Count; i++)
                //{

                //    if (sacrifice[i].Age < Program.form1.numericUpDownMinAge.Value || sacrifice[i].Age > Program.form1.numericUpDownMaxAge.Value)
                //    {
                //        sacrifice.RemoveAt(i);
                //    }
                //}
            }
            base.OperateFilter(ref result);
        }
    }
}
