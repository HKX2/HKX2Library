namespace HKX2
{
    public class hkaiEdgeGeometryFace : IHavokObject
    {
        public uint m_data;
        public uint m_faceIndex;
        public byte m_flags;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_data = br.ReadUInt32();
            m_faceIndex = br.ReadUInt32();
            m_flags = br.ReadByte();
            br.ReadUInt16();
            br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_data);
            bw.WriteUInt32(m_faceIndex);
            bw.WriteByte(m_flags);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}