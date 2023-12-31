namespace HKX2
{
    public class hkcdStaticMeshTreeBaseSection : hkcdStaticTreeTreehkcdStaticTreeDynamicStorage4
    {
        public enum Flags
        {
            SF_REQUIRE_TREE = 1
        }

        public float m_codecParms_0;
        public float m_codecParms_1;
        public float m_codecParms_2;
        public float m_codecParms_3;
        public float m_codecParms_4;
        public float m_codecParms_5;
        public hkcdStaticMeshTreeBaseSectionDataRuns m_dataRuns;
        public uint m_firstPackedVertex;
        public byte m_flags;
        public byte m_layerData;
        public ushort m_leafIndex;
        public byte m_numPackedVertices;
        public byte m_numSharedIndices;
        public byte m_page;
        public hkcdStaticMeshTreeBaseSectionPrimitives m_primitives;
        public hkcdStaticMeshTreeBaseSectionSharedVertices m_sharedVertices;
        public byte m_unusedData;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_codecParms_0 = br.ReadSingle();
            m_codecParms_1 = br.ReadSingle();
            m_codecParms_2 = br.ReadSingle();
            m_codecParms_3 = br.ReadSingle();
            m_codecParms_4 = br.ReadSingle();
            m_codecParms_5 = br.ReadSingle();
            m_firstPackedVertex = br.ReadUInt32();
            m_sharedVertices = new hkcdStaticMeshTreeBaseSectionSharedVertices();
            m_sharedVertices.Read(des, br);
            m_primitives = new hkcdStaticMeshTreeBaseSectionPrimitives();
            m_primitives.Read(des, br);
            m_dataRuns = new hkcdStaticMeshTreeBaseSectionDataRuns();
            m_dataRuns.Read(des, br);
            m_numPackedVertices = br.ReadByte();
            m_numSharedIndices = br.ReadByte();
            m_leafIndex = br.ReadUInt16();
            m_page = br.ReadByte();
            m_flags = br.ReadByte();
            m_layerData = br.ReadByte();
            m_unusedData = br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_codecParms_0);
            bw.WriteSingle(m_codecParms_1);
            bw.WriteSingle(m_codecParms_2);
            bw.WriteSingle(m_codecParms_3);
            bw.WriteSingle(m_codecParms_4);
            bw.WriteSingle(m_codecParms_5);
            bw.WriteUInt32(m_firstPackedVertex);
            m_sharedVertices.Write(s, bw);
            m_primitives.Write(s, bw);
            m_dataRuns.Write(s, bw);
            bw.WriteByte(m_numPackedVertices);
            bw.WriteByte(m_numSharedIndices);
            bw.WriteUInt16(m_leafIndex);
            bw.WriteByte(m_page);
            bw.WriteByte(m_flags);
            bw.WriteByte(m_layerData);
            bw.WriteByte(m_unusedData);
        }
    }
}