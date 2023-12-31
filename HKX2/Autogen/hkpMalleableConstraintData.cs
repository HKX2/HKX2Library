namespace HKX2
{
    public class hkpMalleableConstraintData : hkpWrappedConstraintData
    {
        public hkpBridgeAtoms m_atoms;
        public float m_strength;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_atoms = new hkpBridgeAtoms();
            m_atoms.Read(des, br);
            m_strength = br.ReadSingle();
            br.ReadUInt64();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_atoms.Write(s, bw);
            bw.WriteSingle(m_strength);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
        }
    }
}