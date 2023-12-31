namespace HKX2
{
    public class hclSetupMeshSectionTriangle : IHavokObject
    {
        public uint m_indices_0;
        public uint m_indices_1;
        public uint m_indices_2;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_indices_0 = br.ReadUInt32();
            m_indices_1 = br.ReadUInt32();
            m_indices_2 = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_indices_0);
            bw.WriteUInt32(m_indices_1);
            bw.WriteUInt32(m_indices_2);
        }
    }
}