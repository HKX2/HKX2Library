using System.Numerics;

namespace HKX2
{
    public enum OrientationConstraintType
    {
        CONSTRAIN_ORIENTATION_INVALID = 0,
        CONSTRAIN_ORIENTATION_NONE = 1,
        CONSTRAIN_ORIENTATION_ALLOW_SPIN = 2,
        CONSTRAIN_ORIENTATION_TO_PATH = 3,
        CONSTRAIN_ORIENTATION_MAX_ID = 4
    }

    public class hkpPointToPathConstraintData : hkpConstraintData
    {
        public OrientationConstraintType m_angularConstrainedDOF;

        public hkpBridgeAtoms m_atoms;
        public float m_maxFrictionForce;
        public hkpParametricCurve m_path;
        public Matrix4x4 m_transform_OS_KS_0;
        public Matrix4x4 m_transform_OS_KS_1;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_atoms = new hkpBridgeAtoms();
            m_atoms.Read(des, br);
            m_path = des.ReadClassPointer<hkpParametricCurve>(br);
            m_maxFrictionForce = br.ReadSingle();
            m_angularConstrainedDOF = (OrientationConstraintType) br.ReadSByte();
            br.ReadUInt16();
            br.ReadByte();
            m_transform_OS_KS_0 = des.ReadTransform(br);
            m_transform_OS_KS_1 = des.ReadTransform(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            m_atoms.Write(s, bw);
            s.WriteClassPointer(bw, m_path);
            bw.WriteSingle(m_maxFrictionForce);
            bw.WriteSByte((sbyte) m_angularConstrainedDOF);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            s.WriteTransform(bw, m_transform_OS_KS_0);
            s.WriteTransform(bw, m_transform_OS_KS_1);
        }
    }
}