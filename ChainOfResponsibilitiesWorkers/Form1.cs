using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ChainOfResponsibilitiesWorkers.Program;


namespace ChainOfResponsibilitiesWorkers
{
    public  partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.listBoxBase.Items.Clear();
            this.listBoxBase.Items.AddRange(kolhoz.ToArray());
        }

        public void buttonAction_Click(object sender, EventArgs e)
        {
           
            filterByAge.OperateFilter(ref sacrifice);
            listBoxResult.Items.Clear();

            listBoxResult.Items.AddRange(sacrifice.ToArray());
        }

      
    }
}
