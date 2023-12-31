using System.Numerics;

namespace HKX2
{
    public class hkpSpringAction : hkpBinaryAction
    {
        public float m_damping;

        public Vector4 m_lastForce;
        public bool m_onCompression;
        public bool m_onExtension;
        public Vector4 m_positionAinA;
        public Vector4 m_positionBinB;
        public float m_restLength;
        public float m_strength;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_lastForce = des.ReadVector4(br);
            m_positionAinA = des.ReadVector4(br);
            m_positionBinB = des.ReadVector4(br);
            m_restLength = br.ReadSingle();
            m_strength = br.ReadSingle();
            m_damping = br.ReadSingle();
            m_onCompression = br.ReadBoolean();
            m_onExtension = br.ReadBoolean();
            br.ReadUInt16();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVector4(bw, m_lastForce);
            s.WriteVector4(bw, m_positionAinA);
            s.WriteVector4(bw, m_positionBinB);
            bw.WriteSingle(m_restLength);
            bw.WriteSingle(m_strength);
            bw.WriteSingle(m_damping);
            bw.WriteBoolean(m_onCompression);
            bw.WriteBoolean(m_onExtension);
            bw.WriteUInt16(0);
        }
    }
}