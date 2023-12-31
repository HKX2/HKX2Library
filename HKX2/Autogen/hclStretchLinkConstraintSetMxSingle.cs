namespace HKX2
{
    public class hclStretchLinkConstraintSetMxSingle : IHavokObject
    {
        public uint m_particleA;
        public uint m_particleB;

        public float m_restLength;
        public float m_stiffness;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_restLength = br.ReadSingle();
            m_stiffness = br.ReadSingle();
            m_particleA = br.ReadUInt32();
            m_particleB = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_restLength);
            bw.WriteSingle(m_stiffness);
            bw.WriteUInt32(m_particleA);
            bw.WriteUInt32(m_particleB);
        }
    }
}