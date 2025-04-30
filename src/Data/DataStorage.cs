using System;

namespace Prajire.Data
{
    public class DataStorage
    {
        private readonly DataFormat _format;

        public DataStorage(DataFormat format)
        {
            _format = format;
        }

        private IFileWriter GetWriter(string filePath)
        {
            switch (_format)
            {
                case DataFormat.Csv:
                    return new CsvWriter(filePath, new CsvFormatter());
                case DataFormat.ArtisanCsv:
                    return new CsvWriter(filePath, new ArtisanCsvFormatter());
                default:
                    throw new NotSupportedException($"Data format {_format} not supported");
            }
        }

        private IFileReader GetReader(string filePath)
        {
            switch (_format)
            {
                case DataFormat.Csv:
                    return new CsvFileReader(filePath, new CsvFormatter());
                case DataFormat.ArtisanCsv:
                    return new CsvFileReader(filePath, new ArtisanCsvFormatter());
                default:
                    throw new NotSupportedException($"Data format {_format} not supported");
            }
        }

        public bool SaveTo(string filePath, Session session)
        {
            var writer = GetWriter(filePath);
            if (writer != null)
            {
                var items = session.Items;
                foreach (var item in items)
                {
                    writer.AddEntry(item);
                }

                writer.Save();
                return true;
            }

            return false;
        }

        public Session ReadFrom(string filePath)
        {
            var reader = GetReader(filePath);
            if (reader != null)
            {
                var items = reader.ReadAll();
                if (items.Length == 0)
                {
                    return null;
                }

                var session = new Session();
                var rp = items[0];
                session.Init(new SessionParams(rp.Temp, rp.Power, rp.Ventilation, -1));
                session.Start(rp.Timestamp);
                foreach (var item in items)
                {
                    session.AddRoastParameters(item);
                }

                return session;
            }

            return null;
        }
    }
}