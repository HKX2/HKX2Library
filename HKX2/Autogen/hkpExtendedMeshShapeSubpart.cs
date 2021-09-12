namespace HKX2
{
    public class hkpExtendedMeshShapeSubpart : IHavokObject
    {
        public ushort m_materialIndexStriding;
        public ushort m_shapeInfo;

        public ushort m_typeAndFlags;
        public ulong m_userData;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_typeAndFlags = br.ReadUInt16();
            m_shapeInfo = br.ReadUInt16();
            br.ReadUInt16();
            m_materialIndexStriding = br.ReadUInt16();
            br.ReadUInt64();
            br.ReadUInt64();
            m_userData = br.ReadUInt64();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt16(m_typeAndFlags);
            bw.WriteUInt16(m_shapeInfo);
            bw.WriteUInt16(0);
            bw.WriteUInt16(m_materialIndexStriding);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(m_userData);
        }
    }
}