using System;
using System.Windows.Forms;
using Prajire.Data;

namespace Prajire
{
    public partial class MainForm : Form
    {
        private Session _session = null;
        private RoastState _state = RoastState.NotIntialized;

        public MainForm()
        {
            InitializeComponent();
            UpdateRoastState(RoastState.NotIntialized);
        }

        private void UpdateRoastState(RoastState newState)
        {
            switch (newState)
            {
                case RoastState.Initialized:
                    btnInit.Enabled = false;
                    btnStart.Enabled = true;
                    btnStop.Enabled = false;
                    btnDryEnd.Enabled = false;
                    btnFirstCrack.Enabled = false;
                    lblElapsed.Visible = false;
                    lblDryEnd.Visible = false;
                    lblFirstCrach.Visible = false;
                    lvRoast.Items.Clear();
                    UpdateUiValues();
                    break;
                case RoastState.Started:
                    btnInit.Enabled = false;
                    btnStart.Enabled = false;
                    btnStop.Enabled = false;
                    btnDryEnd.Enabled = true;
                    btnFirstCrack.Enabled = false;
                    lblElapsed.Visible = true;
                    UpdateUiValues();
                    break;
                case RoastState.DryEnd:
                    btnInit.Enabled = false;
                    btnStart.Enabled = false;
                    btnStop.Enabled = false;
                    btnDryEnd.Enabled = false;
                    btnFirstCrack.Enabled = true;
                    lblDryEnd.Visible = true;
                    UpdateUiValues();
                    break;
                case RoastState.FirstCrack:
                    btnInit.Enabled = false;
                    btnStart.Enabled = false;
                    btnStop.Enabled = true;
                    btnDryEnd.Enabled = false;
                    btnFirstCrack.Enabled = false;
                    lblFirstCrach.Visible = true;
                    UpdateUiValues();
                    break;
                case RoastState.Stopped:
                    btnInit.Enabled = true;
                    btnStart.Enabled = false;
                    btnStop.Enabled = false;
                    btnDryEnd.Enabled = false;
                    btnFirstCrack.Enabled = false;
                    UpdateUiValues();
                    break;
                case RoastState.TurningPoint:
                    btnTurningPoint.Enabled = false;
                    break;
                default:
                    btnInit.Enabled = true;
                    btnStart.Enabled = false;
                    btnStop.Enabled = false;
                    btnDryEnd.Enabled = false;
                    btnFirstCrack.Enabled = false;
                    lblElapsed.Text = "";
                    lvRoast.Items.Clear();
                    break;
            }

            _state = newState;
        }

        private void UpdateUiValues(SessionItem lastItem= null)
        {
            if (lastItem == null)
            {
                lastItem = _session.Last();
            }
            if (lastItem != null)
            {
                lblTemp.Text = $"T: {lastItem.Roast.Temp}";
                lblPower.Text = $"P: {lastItem.Roast.Power}";
                lblFan.Text = $"F: {lastItem.Roast.Ventilation}";
                lblDelta.Text = $"ΔT: {lastItem.Roast.Delta:00}";
                string[] row =
                {
                    lastItem.Roast.Temp.ToString(),
                    lastItem.Roast.Power.ToString(),
                    lastItem.Roast.Ventilation.ToString(),
                    lastItem.Roast.Delta.ToString("N2"),
                    lastItem.Elapsed.ToString(),
                    lastItem.Roast.Event != RoastEvent.None ? lastItem.Roast.Event.ToString() : string.Empty
                };
                lvRoast.Items.Insert(0, new ListViewItem(row));
            }
            else if (_session.MachineParams != null)
            {
                lblTemp.Text = $"T: {_session.MachineParams.Temp}";
                lblPower.Text = $"P: {_session.MachineParams.Power}";
                lblFan.Text = $"F: {_session.MachineParams.Ventilation}";
            }
        }

        private string GetTimeString(RoastParams roastParams)
        {
            DateTime refTime = roastParams?.Timestamp ?? DateTime.Now;
            var ts = refTime - _session.StartTime;
            return $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}";
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            var sp = MachineParamsForm.ShowParamsDialog(180, 70, 50);
            if (sp != null)
            {
                _session = new Session();
                _session.MinimumPointEvent += _session_MinimumPointEvent;
                _session.Init(sp);
                tmSamples.Interval = sp.Interval * 1000;
                UpdateRoastState(RoastState.Initialized);
            }
        }

        private void _session_MinimumPointEvent(SessionItem item)
        {
            Invoke(new MethodInvoker(delegate
            {
                lblTurningPoint.Text = GetTimeString(item.Roast);
                UpdateRoastState(RoastState.TurningPoint);
                UpdateUiValues(item);
            }));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (_session != null)
            {
                var st = _session.Start();
                tmSamples.Start();
                tmElapsed.Start();
                var rp = IntervalDataForm.ShowIntervalForm(st.RoastParams);
                if (rp != null)
                {
                    lblElapsed.Text = GetTimeString(null);
                    rp.MarkEvent(RoastEvent.Charge);
                    st.UpdateParams(rp);
                    UpdateRoastState(RoastState.Started);
                }
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (_session != null)
            {
                tmSamples.Stop();
                tmElapsed.Stop();
                var st = _session.Stop();
                var rp = IntervalDataForm.ShowIntervalForm(st.RoastParams);
                if (rp != null)
                {
                    rp.MarkEvent(RoastEvent.Drop);
                    st.UpdateParams(rp);
                    UpdateRoastState(RoastState.Stopped);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // collect another sample
            if (_session != null)
            {
                var st = _session.NewInterval();
                var rp = IntervalDataForm.ShowIntervalForm(st.RoastParams);
                if (rp != null)
                {
                    st.UpdateParams(rp);
                    UpdateUiValues();
                }
            }
        }

        private void tmElapsed_Tick(object sender, EventArgs e)
        {
            lblElapsed.Text = GetTimeString(null);
        }

        private void btnDryEnd_Click(object sender, EventArgs e)
        {
            if (_session != null)
            {
                var st = _session.NewInterval();
                var rp = PhaseForm.ShowPhaseForm(st.RoastParams, RoastEvent.DryEnd);
                if (rp != null)
                {
                    lblDryEnd.Text = GetTimeString(st.RoastParams);
                    st.UpdateParams(rp);
                    UpdateRoastState(RoastState.DryEnd);
                }
            }
        }

        private void btnFirstCrack_Click(object sender, EventArgs e)
        {
            if (_session != null)
            {
                var st = _session.NewInterval();
                var rp = PhaseForm.ShowPhaseForm(st.RoastParams, RoastEvent.FirstCrackStart);
                if (rp != null)
                {
                    lblFirstCrach.Text = GetTimeString(st.RoastParams);
                    st.UpdateParams(rp);
                    UpdateRoastState(RoastState.FirstCrack);
                }
            }
        }

        private void ExportCsvMenuItem_Click(object sender, EventArgs e)
        {
            if (_session == null)
            {
                return;
            }

            if (dlgSave.ShowDialog(this) == DialogResult.OK)
            {
                var ds = new DataStorage(DataFormat.Csv);
                if (ds.SaveTo(dlgSave.FileName, _session))
                {
                    MessageBox.Show($"Continut salvat cu success in '{dlgSave.FileName}'", "Salvare Csv",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Continutul nu a putut fi salvat in '{dlgSave.FileName}'", "Salvare Csv",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ImportCsvMenuItem_Click(object sender, EventArgs e)
        {
            // file dialog
            if (dlgOpen.ShowDialog(this) == DialogResult.OK)
            {
                DataView.ShowDataView(dlgOpen.FileName, DataFormat.Csv);
                //var storage = new DataStorage(DataFormat.Csv);
                //var ses = storage.ReadFrom(dlgOpen.FileName);
                //// another ui for import
                //if (ses != null)
                //{
                //    _session = ses;
                //}
            }
        }

        private void btnTurningPoint_Click(object sender, EventArgs e)
        {
            if (_session != null)
            {
                var st = _session.NewInterval();
                var rp = PhaseForm.ShowPhaseForm(st.RoastParams, RoastEvent.TurningPoint);
                if (rp != null)
                {
                    st.UpdateParams(rp);
                    lblTurningPoint.Text = GetTimeString(st.RoastParams);
                    lblTurningPoint.Visible = true;
                    //UpdateUiValues();
                    // do not update state here, let the event do that
                }
            }
        }

        private void cSVArtisanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog(this) == DialogResult.OK)
            {
                DataView.ShowDataView(dlgOpen.FileName, DataFormat.ArtisanCsv);
            }
        }
    }
}