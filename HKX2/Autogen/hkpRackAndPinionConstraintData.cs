namespace HKX2
{
    public class hkpRackAndPinionConstraintData : hkpConstraintData
    {
        public enum Type
        {
            TYPE_RACK_AND_PINION = 0,
            TYPE_SCREW = 1
        }

        public hkpRackAndPinionConstraintDataAtoms m_atoms;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_atoms = new hkpRackAndPinionConstraintDataAtoms();
            m_atoms.Read(des, br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            m_atoms.Write(s, bw);
        }
    }
}