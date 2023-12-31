using System.Numerics;

namespace HKX2
{
    public class hkpSetLocalTranslationsConstraintAtom : hkpConstraintAtom
    {
        public Vector4 m_translationA;
        public Vector4 m_translationB;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            br.ReadUInt32();
            br.ReadUInt16();
            m_translationA = des.ReadVector4(br);
            m_translationB = des.ReadVector4(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            s.WriteVector4(bw, m_translationA);
            s.WriteVector4(bw, m_translationB);
        }
    }
}