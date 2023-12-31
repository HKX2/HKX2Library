namespace HKX2
{
    public class hkpCompressedMeshShapeBigTriangle : IHavokObject
    {
        public ushort m_a;
        public ushort m_b;
        public ushort m_c;
        public uint m_material;
        public ushort m_transformIndex;
        public ushort m_weldingInfo;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_a = br.ReadUInt16();
            m_b = br.ReadUInt16();
            m_c = br.ReadUInt16();
            br.ReadUInt16();
            m_material = br.ReadUInt32();
            m_weldingInfo = br.ReadUInt16();
            m_transformIndex = br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt16(m_a);
            bw.WriteUInt16(m_b);
            bw.WriteUInt16(m_c);
            bw.WriteUInt16(0);
            bw.WriteUInt32(m_material);
            bw.WriteUInt16(m_weldingInfo);
            bw.WriteUInt16(m_transformIndex);
        }
    }
}