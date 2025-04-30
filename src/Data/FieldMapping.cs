namespace Prajire.Data
{
    public class FieldMapping
    {
        public FieldMapping(DataField field, string label)
        {
            Field = field;
            Label = label;
        }

        public DataField Field { get; }
        public string Label { get; }
    }
}