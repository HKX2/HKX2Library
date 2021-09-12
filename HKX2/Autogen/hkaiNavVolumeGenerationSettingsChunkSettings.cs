namespace HKX2
{
    public class hkaiNavVolumeGenerationSettingsChunkSettings : IHavokObject
    {
        public bool m_doGreedyMergeAfterCombine;

        public ushort m_maxChunkSizeX;
        public ushort m_maxChunkSizeY;
        public ushort m_maxChunkSizeZ;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_maxChunkSizeX = br.ReadUInt16();
            m_maxChunkSizeY = br.ReadUInt16();
            m_maxChunkSizeZ = br.ReadUInt16();
            m_doGreedyMergeAfterCombine = br.ReadBoolean();
            br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt16(m_maxChunkSizeX);
            bw.WriteUInt16(m_maxChunkSizeY);
            bw.WriteUInt16(m_maxChunkSizeZ);
            bw.WriteBoolean(m_doGreedyMergeAfterCombine);
            bw.WriteByte(0);
        }
    }
}