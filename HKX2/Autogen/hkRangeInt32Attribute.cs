namespace HKX2
{
    public class hkRangeInt32Attribute : IHavokObject
    {
        public int m_absmax;

        public int m_absmin;
        public int m_softmax;
        public int m_softmin;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_absmin = br.ReadInt32();
            m_absmax = br.ReadInt32();
            m_softmin = br.ReadInt32();
            m_softmax = br.ReadInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_absmin);
            bw.WriteInt32(m_absmax);
            bw.WriteInt32(m_softmin);
            bw.WriteInt32(m_softmax);
        }
    }
}