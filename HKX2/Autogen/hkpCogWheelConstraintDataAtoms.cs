namespace HKX2
{
    public class hkpCogWheelConstraintDataAtoms : IHavokObject
    {
        public hkpCogWheelConstraintAtom m_cogWheels;

        public hkpSetLocalTransformsConstraintAtom m_transforms;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_transforms = new hkpSetLocalTransformsConstraintAtom();
            m_transforms.Read(des, br);
            m_cogWheels = new hkpCogWheelConstraintAtom();
            m_cogWheels.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_transforms.Write(s, bw);
            m_cogWheels.Write(s, bw);
        }
    }
}