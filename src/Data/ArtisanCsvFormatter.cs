using System;
using System.Text;
using Prajire.Tools;

namespace Prajire.Data
{
    public class ArtisanCsvFormatter : IDataFormatter
    {
        private const char Separator = '\t';
        private const int FieldCount = 7;
        private bool _buildHeaderFromParams;

        public ArtisanCsvFormatter(ArtisanCsvDataHeader header = null)
        {
            Header = header;
            _buildHeaderFromParams = false;
        }

        public ArtisanCsvDataHeader Header { get; private set; }

        public bool AddHeaderLine(string line)
        {
            if (Header == null)
            {
                Header = ArtisanCsvDataHeader.FromString(line);
                return true;
            }

            return false;
        }

        public string ToString(RoastParams roastParams)
        {
            // Time 1
            // Time 2
            // BT
            // ET
            // Event
            // HTR
            // FAN
            var sb = new StringBuilder();
            var time = GetTimeStringFromRoast(roastParams.Timestamp);
            sb.Append(time + Separator);
            sb.Append(time + Separator);
            sb.Append(roastParams.Temp);
            sb.Append(Separator);
            sb.Append($"-1{Separator}");
            if (roastParams.Event != RoastEvent.None)
            {
                sb.Append(ConversionTools.RoastEventToString(roastParams.Event));
            }

            sb.Append(Separator);
            sb.Append(roastParams.Power);
            sb.Append(Separator);
            sb.Append(roastParams.Ventilation);

            if (Header == null)
            {
                Header = new ArtisanCsvDataHeader();
                _buildHeaderFromParams = true;
                Header.TimeStamp = roastParams.Timestamp;
            }
            else if (_buildHeaderFromParams)
            {
                if (roastParams.Event != RoastEvent.None)
                {
                    Header.SetEventTime(roastParams.Event, roastParams.Timestamp);
                }
            }

            return sb.ToString();
        }

        public RoastParams FromString(string rawData)
        {
            var items = rawData.Split(Separator);
            if (items.Length < FieldCount)
            {
                return null;
            }

            if (Header == null)
            {
                return null;
            }

            try
            {
                var time = Header.TimeStamp + ConversionTools.StringToTimeSpan(items[1]);
                float temp = float.Parse(items[2]);

                var power = int.Parse(items[5]);
                var vent = int.Parse(items[6]);

                RoastEvent ev = RoastEvent.None;
                if (!string.IsNullOrEmpty(items[4]))
                {
                    ev = ConversionTools.StringToRoastEvent(items[4]);
                }

                var result = new RoastParams(temp, power, vent);
                result.Timestamp = time;
                if (ev != RoastEvent.None)
                {
                    result.MarkEvent(ev);
                }

                return result;
            }
            catch
            {
                return null;
            }
        }

        public string GetHeader()
        {
            if (Header == null)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            sb.AppendLine(Header.ToString());
            sb.Append("Time 1" + Separator);
            sb.Append("Time 2" + Separator);
            sb.Append("BT" + Separator);
            sb.Append("ET" + Separator);
            sb.Append("Event" + Separator);
            sb.Append("HTR" + Separator);
            sb.Append("FAN" + Separator);

            return sb.ToString();
        }

        private string GetTimeStringFromRoast(DateTime roastTimeStamp)
        {
            if (roastTimeStamp > Header.TimeStamp)
            {
                var ts = roastTimeStamp - Header.TimeStamp;
                return ts.ToString(@"mm\:ss");
            }

            throw new ArgumentOutOfRangeException(nameof(roastTimeStamp), "Must be at a later time than start time");
        }
    }
}