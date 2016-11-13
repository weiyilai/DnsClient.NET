namespace DnsClient.Protocol
{
	public class RecordDHCID : RDataRecord
	{
        internal RecordDHCID(ResourceRecord resource, RecordReader recordReader)
            : base(resource, recordReader)
        {
        }

        public override string ToString()
        {
            return string.Format("not-used");
        }
    }
}
