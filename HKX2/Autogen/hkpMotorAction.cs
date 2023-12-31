using System.Numerics;

namespace HKX2
{
    public class hkpMotorAction : hkpUnaryAction
    {
        public bool m_active;

        public Vector4 m_axis;
        public float m_gain;
        public float m_spinRate;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_axis = des.ReadVector4(br);
            m_spinRate = br.ReadSingle();
            m_gain = br.ReadSingle();
            m_active = br.ReadBoolean();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            s.WriteVector4(bw, m_axis);
            bw.WriteSingle(m_spinRate);
            bw.WriteSingle(m_gain);
            bw.WriteBoolean(m_active);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}