using System.Numerics;

namespace HKX2
{
    public class hkFourTransposedPointsf : IHavokObject
    {
        public Vector4 m_vertices_0;
        public Vector4 m_vertices_1;
        public Vector4 m_vertices_2;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_vertices_0 = des.ReadVector4(br);
            m_vertices_1 = des.ReadVector4(br);
            m_vertices_2 = des.ReadVector4(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4(bw, m_vertices_0);
            s.WriteVector4(bw, m_vertices_1);
            s.WriteVector4(bw, m_vertices_2);
        }
    }
}