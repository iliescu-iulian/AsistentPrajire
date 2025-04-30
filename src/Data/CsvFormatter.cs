using System;
using System.ComponentModel;
using System.Text;
using Prajire.Tools;

namespace Prajire.Data
{
    public class CsvFormatter : IDataFormatter
    {
        private const int FieldCount = 5;
        private readonly char _seperator;

        public CsvFormatter(char seperator = ',')
        {
            _seperator = seperator;
        }

        public bool AddHeaderLine(string line)
        {
            // just ignore
            return false;
        }

        public string ToString(RoastParams roastParams)
        {
            var sb = new StringBuilder();
            sb.Append(roastParams.Temp);
            sb.Append(_seperator);
            sb.Append(roastParams.Power);
            sb.Append(_seperator);
            sb.Append(roastParams.Ventilation);
            sb.Append(_seperator);
            sb.Append(roastParams.Timestamp);
            sb.Append(_seperator);
            if (roastParams.Event != RoastEvent.None)
            {
                sb.Append(ConversionTools.RoastEventToString(roastParams.Event));
            }

            return sb.ToString();
        }

        public RoastParams FromString(string rawData)
        {
            var items = rawData.Split(_seperator);
            if (items.Length != FieldCount)
            {
                return null;
            }

            try
            {
                var temp = int.Parse(items[0]);
                var power = int.Parse(items[1]);
                var vent = int.Parse(items[2]);
                var time = DateTime.Parse(items[3]);
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
            catch (Exception ex)
            {
                throw new InvalidEnumArgumentException(ex.Message, ex);
            }
        }

        public string GetHeader()
        {
            var sb = new StringBuilder();
            sb.Append("Temp" + _seperator);
            sb.Append("Power" + _seperator);
            sb.Append("Vent" + _seperator);
            sb.Append("Time" + _seperator);
            sb.Append("Event");
            return sb.ToString();
        }
    }
}