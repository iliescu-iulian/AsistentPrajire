using System.Windows.Forms;

namespace Prajire
{
    public partial class MachineParamsForm : Form
    {
        public MachineParamsForm()
        {
            InitializeComponent();
        }

        private SessionParams GetParams()
        {
            return new SessionParams(
                (int)numTemp.Value,
                (int)numPower.Value,
                (int)numVent.Value,
                (int)numInterval.Value);
        }

        public static SessionParams ShowParamsDialog(int temp, int power, int vent)
        {
            var frm = new MachineParamsForm();
            frm.numTemp.Value = temp;
            frm.numPower.Value = power;
            frm.numVent.Value = vent;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                return frm.GetParams();
            }

            return null;
        }
    }
}