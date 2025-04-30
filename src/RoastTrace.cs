using System;
using System.Collections.Generic;
using System.Linq;

namespace Prajire
{
    public class RoastTrace
    {
        public RoastTrace()
        {
            Items = new List<RoastParams>();
        }

        public RoastParams TurningPoint { get; private set; }

        public List<RoastParams> Items { get; }
        public int Interval { get; private set; }

        private int ComputeInterval()
        {
            if (Items.Count < 3)
            {
                return -1;
            }

            DateTime last = Items.Last().Timestamp;
            int total = 0;
            int count = 0;
            for (var i = Items.Count - 2; i > 0 && count < 30; i--, count++)
            {
                TimeSpan ti = last - Items[i].Timestamp;
                total += ti.Seconds;
                last = Items[i].Timestamp;
            }

            return count > 0 ? total / count : 0;
        }

        private float ComputeDeltaTime()
        {
            if (Interval <= 0)
            {
                return 0f;
            }

            int threshold = Math.Max(10, Interval);
            var lastItem = Items.Last();
            DateTime last = lastItem.Timestamp;
            int oldestIndex = 0;


            for (var i = Items.Count - 2; i >= 0; i--)
            {
                int seconds = (last - Items[i].Timestamp).Seconds;
                if (seconds > threshold)
                {
                    int prevSeconds = (last - Items[i + 1].Timestamp).Seconds;
                    if (prevSeconds > 0)
                    {
                        // two candidates
                        if (threshold - prevSeconds < seconds - threshold)
                        {
                            oldestIndex = i + 1;
                            break;
                        }
                    }

                    oldestIndex = i;
                    break;
                }

                if (seconds == threshold)
                {
                    oldestIndex = i;
                    break;
                }
            }

            if (lastItem.Temp < Items[oldestIndex].Temp)
            {
                // on TP curve
                return 0;
            }

            int secInterval = (last - Items[oldestIndex].Timestamp).Seconds;
            float adjustement = 60.0f / secInterval;
            return (lastItem.Temp - Items[oldestIndex].Temp) * adjustement;
        }

        public RoastItemTrace Add(RoastParams item)
        {
            bool isTurningPoint = false;
            if (TurningPoint == null && Items.Count > 0)
            {
                if (item.Temp > Items.Last().Temp)
                {
                    TurningPoint = Items.Last();
                    isTurningPoint = true;
                    TurningPoint.MarkEvent(RoastEvent.TurningPoint);

                    var interval = ComputeInterval();
                    if (interval > 0)
                    {
                        Interval = interval;
                    }
                }
            }

            Items.Add(new RoastParams(item));
            if (TurningPoint != null && Interval <= 0)
            {
                Interval = ComputeInterval();
            }

            return new RoastItemTrace(Items.Last())
            {
                TurningPoint = isTurningPoint,
                DeltaTemp = ComputeDeltaTime()
            };
        }
    }
}