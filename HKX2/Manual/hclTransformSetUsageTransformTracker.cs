namespace HKX2
{
    public class hclTransformSetUsageTransformTracker : IHavokObject
    {
        public hkBitField m_read;
        public hkBitField m_readBeforeWrite;
        public hkBitField m_written;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_read = new hkBitField();
            m_read.Read(des, br);
            m_readBeforeWrite = new hkBitField();
            m_readBeforeWrite.Read(des, br);
            m_written = new hkBitField();
            m_written.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_read.Write(s, bw);
            m_readBeforeWrite.Write(s, bw);
            m_written.Write(s, bw);
        }
    }
}