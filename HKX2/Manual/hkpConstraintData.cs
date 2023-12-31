namespace HKX2
{
    public enum ConstraintType
    {
        CONSTRAINT_TYPE_BALLANDSOCKET = 0,
        CONSTRAINT_TYPE_HINGE = 1,
        CONSTRAINT_TYPE_LIMITEDHINGE = 2,
        CONSTRAINT_TYPE_POINTTOPATH = 3,
        CONSTRAINT_TYPE_PRISMATIC = 6,
        CONSTRAINT_TYPE_RAGDOLL = 7,
        CONSTRAINT_TYPE_STIFFSPRING = 8,
        CONSTRAINT_TYPE_WHEEL = 9,
        CONSTRAINT_TYPE_GENERIC = 10,
        CONSTRAINT_TYPE_CONTACT = 11,
        CONSTRAINT_TYPE_BREAKABLE = 12,
        CONSTRAINT_TYPE_MALLEABLE = 13,
        CONSTRAINT_TYPE_POINTTOPLANE = 14,
        CONSTRAINT_TYPE_PULLEY = 15,
        CONSTRAINT_TYPE_ROTATIONAL = 16,
        CONSTRAINT_TYPE_HINGE_LIMITS = 18,
        CONSTRAINT_TYPE_RAGDOLL_LIMITS = 19,
        CONSTRAINT_TYPE_CUSTOM = 20,
        CONSTRAINT_TYPE_RACK_AND_PINION = 21,
        CONSTRAINT_TYPE_COG_WHEEL = 22,
        CONSTRAINT_TYPE_FIXED = 23,
        CONSTRAINT_TYPE_DEFORMABLE_FIXED = 24,
        CONSTRAINT_TYPE_LINEAR_SLACK = 25,
        CONSTRAINT_TYPE_ANGULAR_FRICTION = 26,
        CONSTRAINT_TYPE_6DOF = 27,
        BEGIN_CONSTRAINT_CHAIN_TYPES = 100,
        CONSTRAINT_TYPE_STIFF_SPRING_CHAIN = 100,
        CONSTRAINT_TYPE_BALL_SOCKET_CHAIN = 101,
        CONSTRAINT_TYPE_POWERED_CHAIN = 102
    }

    public class hkpConstraintData : hkReferencedObject
    {
        public ulong m_userData;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_userData = br.ReadUSize();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUSize(m_userData);
        }
    }
}