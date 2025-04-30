using System;

namespace Prajire
{
    public class SessionItem
    {
        public SessionItem(RoastParams roast, TimeSpan elapsed)
        {
            Roast = roast;
            Elapsed = elapsed;
        }

        public RoastParams Roast { get; }
        public TimeSpan Elapsed { get; }
    }
}