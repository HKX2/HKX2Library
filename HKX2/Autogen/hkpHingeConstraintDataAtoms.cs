namespace HKX2
{
    public class hkpHingeConstraintDataAtoms : IHavokObject
    {
        public enum Axis
        {
            AXIS_AXLE = 0
        }

        public hkp2dAngConstraintAtom m_2dAng;
        public hkpBallSocketConstraintAtom m_ballSocket;
        public hkpSetupStabilizationAtom m_setupStabilization;

        public hkpSetLocalTransformsConstraintAtom m_transforms;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des, br);
            m_setupStabilization = new hkpSetupStabilizationAtom();
            m_setupStabilization.Read(des, br);
            m_2dAng = new hkp2dAngConstraintAtom();
            m_2dAng.Read(des, br);
            m_ballSocket = new hkpBallSocketConstraintAtom();
            m_ballSocket.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_transforms.Write(s, bw);
            m_setupStabilization.Write(s, bw);
            m_2dAng.Write(s, bw);
            m_ballSocket.Write(s, bw);
        }
    }
}