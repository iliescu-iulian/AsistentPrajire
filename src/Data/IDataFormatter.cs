namespace Prajire.Data
{
    public interface IDataFormatter
    {
        /// <summary>
        /// Add header lines
        /// </summary>
        /// <param name="line"></param>
        /// <returns><c>true</c> if require another file, <c>false</c> if no other header line is required</returns>
        bool AddHeaderLine(string line);

        string ToString(RoastParams roastParams);
        RoastParams FromString(string rawData);

        string GetHeader();
    }
}