using System.Collections.Generic;

namespace HKX2
{
    public class hclUpdateAllVertexFramesOperator : hclOperator
    {
        public List<float> m_biTangentFlip;
        public uint m_bufferIdx;
        public uint m_numUniqueNormalIDs;
        public List<ushort> m_referenceVertices;
        public List<float> m_tangentEdgeCosAngle;
        public List<float> m_tangentEdgeSinAngle;
        public List<byte> m_triangleFlips;
        public bool m_updateBiTangents;
        public bool m_updateNormals;
        public bool m_updateTangents;

        public List<ushort> m_vertToNormalID;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_vertToNormalID = des.ReadUInt16Array(br);
            m_triangleFlips = des.ReadByteArray(br);
            m_referenceVertices = des.ReadUInt16Array(br);
            m_tangentEdgeCosAngle = des.ReadSingleArray(br);
            m_tangentEdgeSinAngle = des.ReadSingleArray(br);
            m_biTangentFlip = des.ReadSingleArray(br);
            m_bufferIdx = br.ReadUInt32();
            m_numUniqueNormalIDs = br.ReadUInt32();
            m_updateNormals = br.ReadBoolean();
            m_updateTangents = br.ReadBoolean();
            m_updateBiTangents = br.ReadBoolean();
            br.ReadUInt32();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteUInt16Array(bw, m_vertToNormalID);
            s.WriteByteArray(bw, m_triangleFlips);
            s.WriteUInt16Array(bw, m_referenceVertices);
            s.WriteSingleArray(bw, m_tangentEdgeCosAngle);
            s.WriteSingleArray(bw, m_tangentEdgeSinAngle);
            s.WriteSingleArray(bw, m_biTangentFlip);
            bw.WriteUInt32(m_bufferIdx);
            bw.WriteUInt32(m_numUniqueNormalIDs);
            bw.WriteBoolean(m_updateNormals);
            bw.WriteBoolean(m_updateTangents);
            bw.WriteBoolean(m_updateBiTangents);
            bw.WriteUInt32(0);
            bw.WriteByte(0);
        }
    }
}