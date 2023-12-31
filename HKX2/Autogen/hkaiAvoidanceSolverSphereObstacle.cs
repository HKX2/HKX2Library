using System.Numerics;

namespace HKX2
{
    public class hkaiAvoidanceSolverSphereObstacle : IHavokObject
    {
        public hkSphere m_sphere;
        public Vector4 m_velocity;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_sphere = new hkSphere();
            m_sphere.Read(des, br);
            m_velocity = des.ReadVector4(br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_sphere.Write(s, bw);
            s.WriteVector4(bw, m_velocity);
        }
    }
}