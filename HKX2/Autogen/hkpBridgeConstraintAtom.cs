namespace HKX2
{
    public class hkpBridgeConstraintAtom : hkpConstraintAtom
    {
        public hkpConstraintData m_constraintData;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            br.ReadUInt32();
            br.ReadUInt16();
            m_constraintData = des.ReadClassPointer<hkpConstraintData>(br);
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            s.WriteClassPointer(bw, m_constraintData);
            bw.WriteUInt64(0);
        }
    }
}