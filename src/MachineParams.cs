using System;

namespace Prajire
{
    public class MachineParams : IEquatable<MachineParams>
    {
        public MachineParams(float temp, int power, int ventilation)
        {
            if (temp > 0 && temp <= 230)
            {
                Temp = temp;
            }

            if (power >= 0 && power <= 100)
            {
                Power = power - power % 5;
            }

            if (ventilation >= 0 && ventilation <= 100)
            {
                Ventilation = ventilation - ventilation % 5;
            }
        }

        public float Temp { get; }
        public int Power { get; }
        public int Ventilation { get; }

        public bool Equals(MachineParams other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return Temp == other.Temp && Power == other.Power && Ventilation == other.Ventilation;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((MachineParams)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Temp.GetHashCode();
                hashCode = (hashCode * 397) ^ Power;
                hashCode = (hashCode * 397) ^ Ventilation;
                return hashCode;
            }
        }
    }
}