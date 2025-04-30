using System;

namespace Prajire
{
    public class RoastParams : MachineParams, IEquatable<RoastParams>
    {
        public RoastParams(float temp, int power, int ventilation) : base(temp, power, ventilation)
        {
            Timestamp = DateTime.Now;
        }

        public RoastParams(RoastParams roastParams) :
            base(roastParams.Temp, roastParams.Power, roastParams.Ventilation)
        {
            Timestamp = roastParams.Timestamp;
            Delta = roastParams.Delta;
            Event = roastParams.Event;
        }

        public RoastParams(MachineParams machineParams) :
            base(machineParams.Temp, machineParams.Power, machineParams.Ventilation)
        {
            Timestamp = DateTime.Now;
        }

        public float Delta { get; set; }

        //public int RoR { get; }
        public DateTime Timestamp { get; set; }
        public RoastEvent Event { get; private set; }

        public bool Equals(RoastParams other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return base.Equals(other) &&
                   Timestamp == other.Timestamp &&
                   Delta == other.Delta &&
                   Event == other.Event;
        }

        public void MarkEvent(RoastEvent roastEvent)
        {
            Event = roastEvent;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((RoastParams)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (base.GetHashCode() * 397) ^ Delta.GetHashCode();
            }
        }
    }
}