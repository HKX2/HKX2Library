namespace HKX2
{
    public class hkpSimpleMeshShapeTriangle : IHavokObject
    {
        public int m_a;
        public int m_b;
        public int m_c;
        public ushort m_weldingInfo;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_a = br.ReadInt32();
            m_b = br.ReadInt32();
            m_c = br.ReadInt32();
            m_weldingInfo = br.ReadUInt16();
            br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_a);
            bw.WriteInt32(m_b);
            bw.WriteInt32(m_c);
            bw.WriteUInt16(m_weldingInfo);
            bw.WriteUInt16(0);
        }
    }
}