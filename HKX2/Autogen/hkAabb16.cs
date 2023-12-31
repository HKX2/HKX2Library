namespace HKX2
{
    public class hkAabb16 : IHavokObject
    {
        public ushort m_key;
        public ushort m_key1;
        public ushort m_max_0;
        public ushort m_max_1;
        public ushort m_max_2;

        public ushort m_min_0;
        public ushort m_min_1;
        public ushort m_min_2;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_min_0 = br.ReadUInt16();
            m_min_1 = br.ReadUInt16();
            m_min_2 = br.ReadUInt16();
            m_key = br.ReadUInt16();
            m_max_0 = br.ReadUInt16();
            m_max_1 = br.ReadUInt16();
            m_max_2 = br.ReadUInt16();
            m_key1 = br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt16(m_min_0);
            bw.WriteUInt16(m_min_1);
            bw.WriteUInt16(m_min_2);
            bw.WriteUInt16(m_key);
            bw.WriteUInt16(m_max_0);
            bw.WriteUInt16(m_max_1);
            bw.WriteUInt16(m_max_2);
            bw.WriteUInt16(m_key1);
        }
    }
}