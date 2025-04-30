using System;

namespace Prajire
{
    public class Session
    {
        //private List<int> _deltaTrace;

        public delegate void MinimumPointHandler(SessionItem roastParams);
        //public TimeSpan RoastElapsedTime { get; private set; }

        //private int minTempIndex;
        //private int deltaStep;

        private RoastTrace _trace;

        public Session()
        {
            //roastParamList = new List<RoastParams>();
            _trace = new RoastTrace();
        }

        //private List<RoastParams> roastParamList;
        public MachineParams MachineParams { get; private set; }

        //public RoastParams RoastParams { get; private set; }
        //public int MinTemp { get; private set; }
        //public int DeltaTemp { get; set; }
        public DateTime StartTime { get; private set; }

        public RoastParams[] Items => _trace.Items.ToArray();
        public event MinimumPointHandler MinimumPointEvent;

        public TimeSpan GetElapsedTimeFor(RoastParams roastParams)
        {
            var td = roastParams.Timestamp - StartTime;
            return new TimeSpan(td.Hours, td.Minutes, td.Seconds);
        }

        public SessionItem Last()
        {
            var lastIndex = _trace.Items.Count - 1;
            if (lastIndex < 0)
            {
                return null;
            }

            return new SessionItem(
                _trace.Items[lastIndex],
                GetElapsedTimeFor(_trace.Items[lastIndex]));
        }

        public void Init(SessionParams sessionParams)
        {
            _trace = new RoastTrace();
            //MinTemp = -1;
            //DeltaTemp = 0;
            //deltaStep = 60 / sessionParams.Interval;
            MachineParams = sessionParams;
        }

        public SessionInterval Start(DateTime? startTime = null)
        {
            var result = new SessionInterval(this);
            StartTime = startTime ?? result.RoastParams.Timestamp;
            return result;
        }

        public SessionInterval Stop()
        {
            return new SessionInterval(this);
        }

        public SessionInterval NewInterval()
        {
            return new SessionInterval(this);
        }

        public RoastItemTrace AddRoastParameters(RoastParams roastParams)
        {
            var result = _trace.Add(roastParams);
            result.RoastParams.Delta = result.DeltaTemp;
            if (result.TurningPoint && MinimumPointEvent != null)
            {
                MinimumPointEvent(new SessionItem(
                    _trace.TurningPoint,
                    GetElapsedTimeFor(_trace.TurningPoint)));
            }

            return result;
            //RoastParams= roastParams;
            //var td= RoastParams.Timestamp - StartTime;
            //RoastElapsedTime = new TimeSpan(td.Hours, td.Minutes, td.Seconds);
            //if (roastParamList.Count > 0)
            //{
            //    if (MinTemp > 0)
            //    {
            //        // delta compute at max 1 min range
            //        if (roastParamList.Count - minTempIndex > deltaStep)
            //        {
            //            // enough values to compute
            //            DeltaTemp = roastParams.Temp - roastParamList[roastParamList.Count - deltaStep].Temp;
            //        }
            //        else
            //        {
            //            DeltaTemp= (roastParams.Temp - roastParamList.Last().Temp) * deltaStep;
            //        }
            //    }
            //    else if (roastParams.Temp > roastParamList.Last().Temp && MinTemp == -1)
            //    {
            //        minTempIndex = roastParamList.Count - 1;
            //        MinTemp = roastParamList[minTempIndex].Temp;
            //        if (MinimumPointEvent != null)
            //        {
            //            MinimumPointEvent(roastParamList[minTempIndex]);
            //        }
            //    }
            //}
            //roastParamList.Add(roastParams);
        }
    }
}