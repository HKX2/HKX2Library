using System.Numerics;

namespace HKX2
{
    public class hkSkinnedMeshShapePart : IHavokObject
    {
        public ushort m_boneSetId;
        public Vector4 m_boundingSphere;
        public ushort m_meshSectionIndex;
        public int m_numIndices;
        public int m_numVertices;
        public int m_startIndex;

        public int m_startVertex;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_startVertex = br.ReadInt32();
            m_numVertices = br.ReadInt32();
            m_startIndex = br.ReadInt32();
            m_numIndices = br.ReadInt32();
            m_boneSetId = br.ReadUInt16();
            m_meshSectionIndex = br.ReadUInt16();
            br.ReadUInt64();
            br.ReadUInt32();
            m_boundingSphere = des.ReadVector4(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_startVertex);
            bw.WriteInt32(m_numVertices);
            bw.WriteInt32(m_startIndex);
            bw.WriteInt32(m_numIndices);
            bw.WriteUInt16(m_boneSetId);
            bw.WriteUInt16(m_meshSectionIndex);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            s.WriteVector4(bw, m_boundingSphere);
        }
    }
}