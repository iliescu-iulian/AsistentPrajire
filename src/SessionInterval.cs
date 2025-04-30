using System.Linq;

namespace Prajire
{
    public class SessionInterval
    {
        private Session session;

        public SessionInterval(Session session)
        {
            RoastParams = new RoastParams(
                session.Items.LastOrDefault() ?? session.MachineParams);
            this.session = session;
        }

        public RoastParams RoastParams { get; }

        public void UpdateParams(RoastParams roastParams)
        {
            if (roastParams != null)
            {
                roastParams.Timestamp = RoastParams.Timestamp;
            }
            else
            {
                roastParams = RoastParams;
            }

            session.AddRoastParameters(roastParams);
        }
    }
}