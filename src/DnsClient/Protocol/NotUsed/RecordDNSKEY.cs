namespace DnsClient.Protocol
{
	public class RecordDNSKEY : RDataRecord
    {
        internal RecordDNSKEY(ResourceRecord resource, RecordReader recordReader)
            : base(resource, recordReader)
        {
        }

        public override string ToString()
        {
            return string.Format("not-used");
        }
    }
}