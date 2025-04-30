namespace Prajire.Data
{
    public interface IFileWriter
    {
        void AddEntry(RoastParams roastParams);

        void Save();
    }
}