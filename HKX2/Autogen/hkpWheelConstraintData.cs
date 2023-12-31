using System.Numerics;

namespace HKX2
{
    public class hkpWheelConstraintData : hkpConstraintData
    {
        public hkpWheelConstraintDataAtoms m_atoms;
        public Vector4 m_initialAxleInB;
        public Vector4 m_initialSteeringAxisInB;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_atoms = new hkpWheelConstraintDataAtoms();
            m_atoms.Read(des, br);
            m_initialAxleInB = des.ReadVector4(br);
            m_initialSteeringAxisInB = des.ReadVector4(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            m_atoms.Write(s, bw);
            s.WriteVector4(bw, m_initialAxleInB);
            s.WriteVector4(bw, m_initialSteeringAxisInB);
        }
    }
}