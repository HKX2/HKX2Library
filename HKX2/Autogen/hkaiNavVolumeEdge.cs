namespace HKX2
{
    public class hkaiNavVolumeEdge : IHavokObject
    {
        public byte m_flags;
        public uint m_oppositeCell;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_flags = br.ReadByte();
            br.ReadUInt16();
            br.ReadByte();
            m_oppositeCell = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteByte(m_flags);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            bw.WriteUInt32(m_oppositeCell);
        }
    }
}