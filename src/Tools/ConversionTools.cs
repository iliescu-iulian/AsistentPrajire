using System;
using System.Globalization;

namespace Prajire.Tools
{
    public static class ConversionTools
    {
        public static TimeSpan StringToTimeSpan(string input)
        {
            return TimeSpan.ParseExact(input, @"mm\:ss", CultureInfo.InvariantCulture);
        }

        public static string TimeSpanToString(TimeSpan input)
        {
            return input.ToString(@"mm\:ss");
        }

        public static RoastEvent StringToRoastEvent(string input)
        {
            if (Enum.TryParse(input, true, out RoastEvent ev))
            {
                return ev;
            }

            switch (input.ToUpper())
            {
                case "TP":
                    return RoastEvent.TurningPoint;
                case "DRYE":
                case "DRY END":
                    return RoastEvent.DryEnd;
                case "FCS":
                    return RoastEvent.FirstCrackStart;
                case "FCE":
                    return RoastEvent.FirstCrackEnd;
                case "SCS":
                    return RoastEvent.SecondCrackStart;
                case "SCE":
                    return RoastEvent.SecondCrackEnd;
                default:
                    throw new ArgumentException($"Cannot match '{input}' to a RoastEvent", nameof(input));
            }
        }

        public static string RoastEventToString(RoastEvent ev)
        {
            switch (ev)
            {
                case RoastEvent.TurningPoint:
                    return "TP";
                case RoastEvent.DryEnd:
                    return "DE";
                case RoastEvent.FirstCrackStart:
                    return "FCs";
                case RoastEvent.FirstCrackEnd:
                    return "FCe";
                case RoastEvent.SecondCrackStart:
                    return "SCs";
                case RoastEvent.SecondCrackEnd:
                    return "SCe";
                default:
                    return ev.ToString().ToUpper();
            }
        }
    }
}