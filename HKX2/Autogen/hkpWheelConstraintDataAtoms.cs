namespace HKX2
{
    public class hkpWheelConstraintDataAtoms : IHavokObject
    {
        public enum Axis
        {
            AXIS_SUSPENSION = 0,
            AXIS_PERP_SUSPENSION = 1,
            AXIS_AXLE = 0,
            AXIS_STEERING = 1
        }

        public hkp2dAngConstraintAtom m_2dAng;
        public hkpLinLimitConstraintAtom m_lin0Limit;
        public hkpLinSoftConstraintAtom m_lin0Soft;
        public hkpLinConstraintAtom m_lin1;
        public hkpLinConstraintAtom m_lin2;
        public hkpSetLocalRotationsConstraintAtom m_steeringBase;

        public hkpSetLocalTransformsConstraintAtom m_suspensionBase;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_suspensionBase = new hkpSetLocalTransformsConstraintAtom();
            m_suspensionBase.Read(des, br);
            m_lin0Limit = new hkpLinLimitConstraintAtom();
            m_lin0Limit.Read(des, br);
            m_lin0Soft = new hkpLinSoftConstraintAtom();
            m_lin0Soft.Read(des, br);
            m_lin1 = new hkpLinConstraintAtom();
            m_lin1.Read(des, br);
            m_lin2 = new hkpLinConstraintAtom();
            m_lin2.Read(des, br);
            m_steeringBase = new hkpSetLocalRotationsConstraintAtom();
            m_steeringBase.Read(des, br);
            m_2dAng = new hkp2dAngConstraintAtom();
            m_2dAng.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_suspensionBase.Write(s, bw);
            m_lin0Limit.Write(s, bw);
            m_lin0Soft.Write(s, bw);
            m_lin1.Write(s, bw);
            m_lin2.Write(s, bw);
            m_steeringBase.Write(s, bw);
            m_2dAng.Write(s, bw);
        }
    }
}