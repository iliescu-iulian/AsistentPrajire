using System.Collections.Generic;
using System.IO;

namespace Prajire.Data
{
    public class CsvWriter : IFileWriter
    {
        private readonly string _filePath;
        private readonly IDataFormatter _formatter;
        private List<RoastParams> _params;

        public CsvWriter(string filePath, IDataFormatter formatter)
        {
            _filePath = filePath;
            _formatter = formatter;
            _params = new List<RoastParams>();
        }

        public void AddEntry(RoastParams roastParams)
        {
            _params.Add(roastParams);
        }

        public void Save()
        {
            using (var io = new StreamWriter(_filePath))
            {
                // write header
                io.WriteLine(_formatter.GetHeader());
                // write content
                foreach (var p in _params)
                {
                    io.WriteLine(_formatter.ToString(p));
                }
            }
        }
    }
}