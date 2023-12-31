namespace HKX2
{
    public class hclStandardLinkConstraintSetLink : IHavokObject
    {
        public ushort m_particleA;
        public ushort m_particleB;
        public float m_restLength;
        public float m_stiffness;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_particleA = br.ReadUInt16();
            m_particleB = br.ReadUInt16();
            m_restLength = br.ReadSingle();
            m_stiffness = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt16(m_particleA);
            bw.WriteUInt16(m_particleB);
            bw.WriteSingle(m_restLength);
            bw.WriteSingle(m_stiffness);
        }
    }
}