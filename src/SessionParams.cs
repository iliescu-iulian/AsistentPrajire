namespace Prajire
{
    public class SessionParams : MachineParams
    {
        public SessionParams(float temp, int power, int ventilation, int interval) : base(temp, power, ventilation)
        {
            Interval = interval;
        }

        public int Interval { get; }
    }
}