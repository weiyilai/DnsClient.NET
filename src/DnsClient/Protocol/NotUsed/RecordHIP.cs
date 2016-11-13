namespace DnsClient.Protocol
{
	public class RecordHIP : RDataRecord
    {
        internal RecordHIP(ResourceRecord resource, RecordReader recordReader)
            : base(resource, recordReader)
        {
        }

        public override string ToString()
        {
            return string.Format("not-used");
        }
    }
}