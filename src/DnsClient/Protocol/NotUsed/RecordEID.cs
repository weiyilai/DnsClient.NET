namespace DnsClient.Protocol
{
	public class RecordEID : RDataRecord
    {
        internal RecordEID(ResourceRecord resource, RecordReader recordReader)
            : base(resource, recordReader)
        {
        }

        public override string ToString()
        {
            return string.Format("not-used");
        }
    }
}