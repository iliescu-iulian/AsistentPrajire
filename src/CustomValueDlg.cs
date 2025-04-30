using System.Windows.Forms;

namespace Prajire
{
    public partial class CustomValueDlg : Form
    {
        public CustomValueDlg()
        {
            InitializeComponent();
            numValue.Select(0, 3);
        }

        public static int GetValue(int currentValue)
        {
            var frm = new CustomValueDlg();
            frm.numValue.Value = currentValue;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                return (int)frm.numValue.Value;
            }

            return -1;
        }
    }
}