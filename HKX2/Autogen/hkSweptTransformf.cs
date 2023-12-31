using System.Numerics;

namespace HKX2
{
    public class hkSweptTransformf : IHavokObject
    {
        public Vector4 m_centerOfMass0;
        public Vector4 m_centerOfMass1;
        public Vector4 m_centerOfMassLocal;
        public Quaternion m_rotation0;
        public Quaternion m_rotation1;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_centerOfMass0 = des.ReadVector4(br);
            m_centerOfMass1 = des.ReadVector4(br);
            m_rotation0 = des.ReadQuaternion(br);
            m_rotation1 = des.ReadQuaternion(br);
            m_centerOfMassLocal = des.ReadVector4(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4(bw, m_centerOfMass0);
            s.WriteVector4(bw, m_centerOfMass1);
            s.WriteQuaternion(bw, m_rotation0);
            s.WriteQuaternion(bw, m_rotation1);
            s.WriteVector4(bw, m_centerOfMassLocal);
        }
    }
}