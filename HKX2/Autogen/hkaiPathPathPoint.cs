using System.Numerics;

namespace HKX2
{
    public class hkaiPathPathPoint : IHavokObject
    {
        public byte m_flags;
        public Vector4 m_normal;

        public Vector4 m_position;
        public int m_sectionId;
        public uint m_userEdgeData;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_position = des.ReadVector4(br);
            m_normal = des.ReadVector4(br);
            m_userEdgeData = br.ReadUInt32();
            m_sectionId = br.ReadInt32();
            m_flags = br.ReadByte();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4(bw, m_position);
            s.WriteVector4(bw, m_normal);
            bw.WriteUInt32(m_userEdgeData);
            bw.WriteInt32(m_sectionId);
            bw.WriteByte(m_flags);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}