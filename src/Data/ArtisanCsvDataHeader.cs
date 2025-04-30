using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Prajire.Data
{
    public class ArtisanCsvDataHeader
    {
        private const int ItemsCount = 12;

        private const string DateLabel = "Date";
        private const string TimeLabel = "Time";
        private const string UnitLabel = "Unit";

        private static readonly string[] EventNames = new string[]
        {
            "Charge",
            "TP",
            "DRYe",
            "FCs",
            "FCe",
            "SCs",
            "SCe",
            "DROP"
        };

        private Dictionary<RoastEvent, TimeSpan> _events;

        public ArtisanCsvDataHeader()
        {
            _events = new Dictionary<RoastEvent, TimeSpan>();
            //Unit = 'C';
        }


        public DateTime TimeStamp { get; set; }
        public char Unit { get; set; }

        public void SetEventTime(RoastEvent e, TimeSpan time)
        {
            _events[e] = time;
        }

        public void SetEventTime(RoastEvent e, DateTime dt)
        {
            _events[e] = dt - TimeStamp;
        }

        public TimeSpan? GetEventTime(RoastEvent e)
        {
            if (_events.ContainsKey(e))
            {
                return _events[e];
            }

            return null;
        }

        public static ArtisanCsvDataHeader FromString(string line)
        {
            var items = line.Split('\t');
            if (items.Length != ItemsCount)
            {
                // not recognized
                return null;
            }

            var fieldValue = ExtractValueFromRawField(DateLabel, items[0]);
            var date = DateTime.Parse(fieldValue);
            fieldValue = ExtractValueFromRawField(TimeLabel, items[ItemsCount - 1]);
            if (!string.IsNullOrEmpty(fieldValue))
            {
                var time = TimeSpan.Parse(fieldValue);
                date = date.Add(time);
            }

            var result = new ArtisanCsvDataHeader
            {
                TimeStamp = date
            };
            fieldValue = ExtractValueFromRawField(UnitLabel, items[1]);
            if (!string.IsNullOrEmpty(fieldValue))
            {
                result.Unit = fieldValue[0];
            }

            // events
            for (RoastEvent e = RoastEvent.Charge; e <= RoastEvent.Drop; e++)
            {
                int index = e - RoastEvent.Charge;
                fieldValue = ExtractValueFromRawField(EventNames[index], items[index + 2]);
                if (!string.IsNullOrEmpty(fieldValue))
                {
                    result.SetEventTime(e, TimeSpan.ParseExact(fieldValue, @"mm\:ss", CultureInfo.InvariantCulture));
                }
            }

            return result;
        }

        public override string ToString()
        {
            // Date:04.03.2025	Unit:C	CHARGE:00:04	TP:01:08	DRYe:03:39	FCs:07:29	FCe: 	SCs: 	SCe: 	DROP:09:22	COOL:	Time:12:00:00
            var sb = new StringBuilder();
            sb.Append($"Date:{TimeStamp.Date.ToString("MM.dd.yyyy")}\t");
            sb.Append($"Unit:{Unit}\t");
            sb.Append($"CHARGE:{GetEventTimeString(RoastEvent.Charge)}\t");
            sb.Append($"TP:{GetEventTimeString(RoastEvent.TurningPoint)}\t");
            sb.Append($"DRYe:{GetEventTimeString(RoastEvent.DryEnd)}\t");
            sb.Append($"FCs:{GetEventTimeString(RoastEvent.FirstCrackStart)}\t");
            sb.Append($"FCe:{GetEventTimeString(RoastEvent.FirstCrackEnd)}\t");
            sb.Append($"SCs:{GetEventTimeString(RoastEvent.SecondCrackStart)}\t");
            sb.Append($"SCe:{GetEventTimeString(RoastEvent.SecondCrackEnd)}\t");
            sb.Append($"DROP:{GetEventTimeString(RoastEvent.Drop)}\t");
            sb.Append("COOL:\t");
            sb.Append($"Time:{TimeStamp:HH:mm:ss}");
            return sb.ToString();
        }

        /// <summary>
        /// When an event is missing return empty string. When Charge is missing, return 00:00
        /// </summary>
        /// <param name="ev"></param>
        /// <returns></returns>
        private string GetEventTimeString(RoastEvent ev)
        {
            if (ev == RoastEvent.Charge)
            {
                return _events.ContainsKey(ev) ? _events[ev].ToString(@"mm\:ss") : "00:00";
            }

            return _events.ContainsKey(ev) ? _events[ev].ToString(@"mm\:ss") : " ";
        }

        private static string ExtractValueFromRawField(string fieldLabel, string raw)
        {
            if (fieldLabel.Length + 1 >= raw.Length)
            {
                return string.Empty;
            }

            return raw.Substring(fieldLabel.Length + 1).Trim();
        }
    }
}