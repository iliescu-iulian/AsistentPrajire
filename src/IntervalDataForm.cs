using System;
using System.Windows.Forms;

namespace Prajire
{
    public partial class IntervalDataForm : Form
    {
        public IntervalDataForm()
        {
            InitializeComponent();
            ctrlTemp.MaxValue = 230;
            ctrlTemp.Step = 1;
            ctrlPower.MaxValue = 100;
            ctrlPower.Step = 5;
            ctrlVent.MaxValue = 100;
            ctrlVent.Step = 5;
        }

        private int Temp => ctrlTemp.CurrentValue;
        private int Power => ctrlPower.CurrentValue;
        private int Vent => ctrlVent.CurrentValue;

        private RoastParams getRoastParams()
        {
            return new RoastParams(Temp, Power, Vent);
        }

        public static RoastParams ShowIntervalForm(RoastParams roastParams)
        {
            var frm = new IntervalDataForm();
            frm.ctrlTemp.SetInitialValue((int)Math.Round(roastParams.Temp));
            frm.ctrlPower.SetInitialValue(roastParams.Power);
            frm.ctrlVent.SetInitialValue(roastParams.Ventilation);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                return frm.getRoastParams();
            }

            return null;
        }
    }
}