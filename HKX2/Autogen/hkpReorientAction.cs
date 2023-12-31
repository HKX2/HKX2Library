using System.Numerics;

namespace HKX2
{
    public class hkpReorientAction : hkpUnaryAction
    {
        public float m_damping;

        public Vector4 m_rotationAxis;
        public float m_strength;
        public Vector4 m_upAxis;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_rotationAxis = des.ReadVector4(br);
            m_upAxis = des.ReadVector4(br);
            m_strength = br.ReadSingle();
            m_damping = br.ReadSingle();
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            s.WriteVector4(bw, m_rotationAxis);
            s.WriteVector4(bw, m_upAxis);
            bw.WriteSingle(m_strength);
            bw.WriteSingle(m_damping);
            bw.WriteUInt64(0);
        }
    }
}