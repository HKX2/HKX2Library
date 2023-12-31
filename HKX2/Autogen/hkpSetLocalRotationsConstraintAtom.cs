using System.Numerics;

namespace HKX2
{
    public class hkpSetLocalRotationsConstraintAtom : hkpConstraintAtom
    {
        public Matrix4x4 m_rotationA;
        public Matrix4x4 m_rotationB;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            br.ReadUInt32();
            br.ReadUInt16();
            m_rotationA = des.ReadMatrix3(br);
            m_rotationB = des.ReadMatrix3(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            s.WriteMatrix3(bw, m_rotationA);
            s.WriteMatrix3(bw, m_rotationB);
        }
    }
}