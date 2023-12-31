namespace HKX2
{
    public class hclSimpleMeshBoneDeformOperatorTriangleBonePair : IHavokObject
    {
        public ushort m_boneOffset;
        public ushort m_triangleOffset;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_boneOffset = br.ReadUInt16();
            m_triangleOffset = br.ReadUInt16();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt16(m_boneOffset);
            bw.WriteUInt16(m_triangleOffset);
        }
    }
}