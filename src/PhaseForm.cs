using System;
using System.Windows.Forms;

namespace Prajire
{
    public partial class PhaseForm : Form
    {
        public PhaseForm()
        {
            InitializeComponent();
            ctrlTemp.MaxValue = 230;
            ctrlTemp.Step = 1;
        }

        private int Temp => ctrlTemp.CurrentValue;

        public static RoastParams ShowPhaseForm(RoastParams roastParams, RoastEvent roastEvent)
        {
            string phaseName;
            switch (roastEvent)
            {
                case RoastEvent.TurningPoint:
                    phaseName = "TP";
                    break;
                case RoastEvent.DryEnd:
                    phaseName = "DE";
                    break;
                case RoastEvent.FirstCrackStart:
                    phaseName = "FC";
                    break;
                default: // unexpected
                    return null;
            }

            var frm = new PhaseForm();
            frm.ctrlTemp.SetInitialValue((int)Math.Round(roastParams.Temp));
            frm.Text = $"Faza: {phaseName}";

            if (frm.ShowDialog() == DialogResult.OK)
            {
                var result = new RoastParams(frm.Temp, roastParams.Power, roastParams.Ventilation);
                result.MarkEvent(roastEvent);
                return result;
            }

            return null;
        }
    }
}