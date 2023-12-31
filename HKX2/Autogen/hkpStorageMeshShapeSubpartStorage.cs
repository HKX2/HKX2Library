using System.Collections.Generic;

namespace HKX2
{
    public class hkpStorageMeshShapeSubpartStorage : hkReferencedObject
    {
        public List<ushort> m_indices16;
        public List<uint> m_indices32;
        public List<byte> m_materialIndices;
        public List<ushort> m_materialIndices16;
        public List<uint> m_materials;

        public List<float> m_vertices;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_vertices = des.ReadSingleArray(br);
            m_indices16 = des.ReadUInt16Array(br);
            m_indices32 = des.ReadUInt32Array(br);
            m_materialIndices = des.ReadByteArray(br);
            m_materials = des.ReadUInt32Array(br);
            m_materialIndices16 = des.ReadUInt16Array(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteSingleArray(bw, m_vertices);
            s.WriteUInt16Array(bw, m_indices16);
            s.WriteUInt32Array(bw, m_indices32);
            s.WriteByteArray(bw, m_materialIndices);
            s.WriteUInt32Array(bw, m_materials);
            s.WriteUInt16Array(bw, m_materialIndices16);
        }
    }
}