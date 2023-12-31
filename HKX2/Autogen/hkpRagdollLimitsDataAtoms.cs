namespace HKX2
{
    public class hkpRagdollLimitsDataAtoms : IHavokObject
    {
        public enum Axis
        {
            AXIS_TWIST = 0,
            AXIS_PLANES = 1,
            AXIS_CROSS_PRODUCT = 2
        }

        public hkpConeLimitConstraintAtom m_coneLimit;
        public hkpConeLimitConstraintAtom m_planesLimit;

        public hkpSetLocalRotationsConstraintAtom m_rotations;
        public hkpTwistLimitConstraintAtom m_twistLimit;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_rotations = new hkpSetLocalRotationsConstraintAtom();
            m_rotations.Read(des, br);
            m_twistLimit = new hkpTwistLimitConstraintAtom();
            m_twistLimit.Read(des, br);
            m_coneLimit = new hkpConeLimitConstraintAtom();
            m_coneLimit.Read(des, br);
            m_planesLimit = new hkpConeLimitConstraintAtom();
            m_planesLimit.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_rotations.Write(s, bw);
            m_twistLimit.Write(s, bw);
            m_coneLimit.Write(s, bw);
            m_planesLimit.Write(s, bw);
        }
    }
}