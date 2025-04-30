using System.Windows.Forms;
using Prajire.Data;

namespace Prajire
{
    public partial class DataView : Form
    {
        public DataView()
        {
            InitializeComponent();
        }

        private void LoadData(Session session)
        {
            foreach (var item in session.Items)
            {
                string[] row =
                {
                    item.Temp.ToString(),
                    item.Delta > 0 ? item.Delta.ToString("N2") : "",
                    item.Power.ToString(),
                    item.Ventilation.ToString(),
                    session.GetElapsedTimeFor(item).ToString(),
                    item.Event.ToString()
                };
                lvRoast.Items.Add(new ListViewItem(row));
            }
        }

        public static void ShowDataView(string path, DataFormat format)
        {
            var storage = new DataStorage(format);
            var ses = storage.ReadFrom(path);
            if (ses == null)
            {
                MessageBox.Show($"Nu se poate incarca '{path}'", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var frm = new DataView();
            frm.Text = path;
            frm.LoadData(ses);

            frm.ShowDialog();
        }
    }
}