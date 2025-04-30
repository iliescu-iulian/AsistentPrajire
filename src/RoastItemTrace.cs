namespace Prajire
{
    public class RoastItemTrace
    {
        public RoastItemTrace(RoastParams roastParams)
        {
            RoastParams = roastParams;
        }

        public bool TurningPoint { get; set; }
        public float DeltaTemp { get; set; }

        public RoastParams RoastParams { get; }
    }
}