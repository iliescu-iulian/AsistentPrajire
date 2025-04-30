using System.Collections.Generic;
using System.IO;

namespace Prajire.Data
{
    public class CsvFileReader : IFileReader
    {
        private readonly IDataFormatter _formatter;
        private readonly string _path;

        public CsvFileReader(string path, IDataFormatter formatter)
        {
            _path = path;
            _formatter = formatter;
        }

        public RoastParams[] ReadAll()
        {
            var result = new List<RoastParams>();
            using (var io = new StreamReader(_path))
            {
                var hdr = new List<string>();
                while (!io.EndOfStream)
                {
                    if (!_formatter.AddHeaderLine(io.ReadLine()))
                    {
                        break;
                    }
                }

                while (!io.EndOfStream)
                {
                    var ln = io.ReadLine();
                    if (!string.IsNullOrEmpty(ln))
                    {
                        var param = _formatter.FromString(ln);
                        // ignore all we do not know
                        if (param != null)
                        {
                            result.Add(param);
                        }
                    }
                }
            }

            return result.ToArray();
        }
    }
}