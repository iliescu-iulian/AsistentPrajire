using System;
using System.Windows.Forms;

namespace Prajire
{
    public partial class UpDownNumber : UserControl
    {
        private int _currentValue;

        public UpDownNumber()
        {
            InitializeComponent();
            CurrentValue = 0;
            MinValue = 0;
            MaxValue = 100;
            Step = 1;
        }

        public int CurrentValue
        {
            get => _currentValue;
            private set
            {
                _currentValue = value;
                lblValue.Text = _currentValue.ToString();
            }
        }

        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int Step { get; set; }

        public void SetInitialValue(int value)
        {
            CurrentValue = value;
        }

        private void btnCustrom_Click(object sender, EventArgs e)
        {
            var value = CustomValueDlg.GetValue(CurrentValue);
            if (value >= MinValue)
            {
                CurrentValue = value;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (CurrentValue - Step >= MinValue)
            {
                CurrentValue -= Step;
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (CurrentValue + Step <= MaxValue)
            {
                CurrentValue += Step;
            }
        }
    }
}