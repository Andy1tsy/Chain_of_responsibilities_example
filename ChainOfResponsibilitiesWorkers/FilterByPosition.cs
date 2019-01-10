using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChainOfResponsibilitiesWorkers
{
     class FilterByPosition : FilterBase
    {
        public FilterByPosition(FilterBase nextFilter) : base(nextFilter)
        {
        }

        public override void OperateFilter(ref List<Kolhoznik> result)
        {
            if (Program.form1.checkBoxPosition.CheckState == CheckState.Checked)
            {
                var filtered = result.Where(item => item.Position == Program.form1.comboBoxPositionSelect.SelectedItem.ToString());
                result = new List<Kolhoznik>(filtered.ToList());
                //for (int i = 0; i < sacrifice.Count; i++)
                //{

                //    if (!sacrifice[i].Position.Equals(Program.form1.comboBoxPositionSelect.SelectedItem.ToString()))
                //    {
                //        sacrifice.RemoveAt(i);
                //    }
                //}

            }
           
            base.OperateFilter(ref result);
        }
    }
}
