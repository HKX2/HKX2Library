namespace HKX2
{
    public class hkAabbUint32 : IHavokObject
    {
        public byte m_expansionMax_0;
        public byte m_expansionMax_1;
        public byte m_expansionMax_2;
        public byte m_expansionMin_0;
        public byte m_expansionMin_1;
        public byte m_expansionMin_2;
        public byte m_expansionShift;
        public uint m_max_0;
        public uint m_max_1;
        public uint m_max_2;

        public uint m_min_0;
        public uint m_min_1;
        public uint m_min_2;
        public byte m_shapeKeyByte;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_min_0 = br.ReadUInt32();
            m_min_1 = br.ReadUInt32();
            m_min_2 = br.ReadUInt32();
            m_expansionMin_0 = br.ReadByte();
            m_expansionMin_1 = br.ReadByte();
            m_expansionMin_2 = br.ReadByte();
            m_expansionShift = br.ReadByte();
            m_max_0 = br.ReadUInt32();
            m_max_1 = br.ReadUInt32();
            m_max_2 = br.ReadUInt32();
            m_expansionMax_0 = br.ReadByte();
            m_expansionMax_1 = br.ReadByte();
            m_expansionMax_2 = br.ReadByte();
            m_shapeKeyByte = br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_min_0);
            bw.WriteUInt32(m_min_1);
            bw.WriteUInt32(m_min_2);
            bw.WriteByte(m_expansionMin_0);
            bw.WriteByte(m_expansionMin_1);
            bw.WriteByte(m_expansionMin_2);
            bw.WriteByte(m_expansionShift);
            bw.WriteUInt32(m_max_0);
            bw.WriteUInt32(m_max_1);
            bw.WriteUInt32(m_max_2);
            bw.WriteByte(m_expansionMax_0);
            bw.WriteByte(m_expansionMax_1);
            bw.WriteByte(m_expansionMax_2);
            bw.WriteByte(m_shapeKeyByte);
        }
    }
}