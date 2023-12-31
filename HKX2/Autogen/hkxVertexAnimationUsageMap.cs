namespace HKX2
{
    public class hkxVertexAnimationUsageMap : IHavokObject
    {
        public DataUsage m_use;
        public byte m_useIndexLocal;
        public byte m_useIndexOrig;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_use = (DataUsage) br.ReadUInt16();
            m_useIndexOrig = br.ReadByte();
            m_useIndexLocal = br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt16((ushort) m_use);
            bw.WriteByte(m_useIndexOrig);
            bw.WriteByte(m_useIndexLocal);
        }
    }
}