using System.Numerics;

namespace HKX2
{
    public class hclVolumeConstraintMxFrameBatchData : IHavokObject
    {
        public Vector4 m_frameVector_0;
        public Vector4 m_frameVector_1;
        public Vector4 m_frameVector_10;
        public Vector4 m_frameVector_11;
        public Vector4 m_frameVector_12;
        public Vector4 m_frameVector_13;
        public Vector4 m_frameVector_14;
        public Vector4 m_frameVector_15;
        public Vector4 m_frameVector_2;
        public Vector4 m_frameVector_3;
        public Vector4 m_frameVector_4;
        public Vector4 m_frameVector_5;
        public Vector4 m_frameVector_6;
        public Vector4 m_frameVector_7;
        public Vector4 m_frameVector_8;
        public Vector4 m_frameVector_9;
        public ushort m_particleIndex_0;
        public ushort m_particleIndex_1;
        public ushort m_particleIndex_10;
        public ushort m_particleIndex_11;
        public ushort m_particleIndex_12;
        public ushort m_particleIndex_13;
        public ushort m_particleIndex_14;
        public ushort m_particleIndex_15;
        public ushort m_particleIndex_2;
        public ushort m_particleIndex_3;
        public ushort m_particleIndex_4;
        public ushort m_particleIndex_5;
        public ushort m_particleIndex_6;
        public ushort m_particleIndex_7;
        public ushort m_particleIndex_8;
        public ushort m_particleIndex_9;
        public float m_weight_0;
        public float m_weight_1;
        public float m_weight_10;
        public float m_weight_11;
        public float m_weight_12;
        public float m_weight_13;
        public float m_weight_14;
        public float m_weight_15;
        public float m_weight_2;
        public float m_weight_3;
        public float m_weight_4;
        public float m_weight_5;
        public float m_weight_6;
        public float m_weight_7;
        public float m_weight_8;
        public float m_weight_9;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_frameVector_0 = des.ReadVector4(br);
            m_frameVector_1 = des.ReadVector4(br);
            m_frameVector_2 = des.ReadVector4(br);
            m_frameVector_3 = des.ReadVector4(br);
            m_frameVector_4 = des.ReadVector4(br);
            m_frameVector_5 = des.ReadVector4(br);
            m_frameVector_6 = des.ReadVector4(br);
            m_frameVector_7 = des.ReadVector4(br);
            m_frameVector_8 = des.ReadVector4(br);
            m_frameVector_9 = des.ReadVector4(br);
            m_frameVector_10 = des.ReadVector4(br);
            m_frameVector_11 = des.ReadVector4(br);
            m_frameVector_12 = des.ReadVector4(br);
            m_frameVector_13 = des.ReadVector4(br);
            m_frameVector_14 = des.ReadVector4(br);
            m_frameVector_15 = des.ReadVector4(br);
            m_particleIndex_0 = br.ReadUInt16();
            m_particleIndex_1 = br.ReadUInt16();
            m_particleIndex_2 = br.ReadUInt16();
            m_particleIndex_3 = br.ReadUInt16();
            m_particleIndex_4 = br.ReadUInt16();
            m_particleIndex_5 = br.ReadUInt16();
            m_particleIndex_6 = br.ReadUInt16();
            m_particleIndex_7 = br.ReadUInt16();
            m_particleIndex_8 = br.ReadUInt16();
            m_particleIndex_9 = br.ReadUInt16();
            m_particleIndex_10 = br.ReadUInt16();
            m_particleIndex_11 = br.ReadUInt16();
            m_particleIndex_12 = br.ReadUInt16();
            m_particleIndex_13 = br.ReadUInt16();
            m_particleIndex_14 = br.ReadUInt16();
            m_particleIndex_15 = br.ReadUInt16();
            m_weight_0 = br.ReadSingle();
            m_weight_1 = br.ReadSingle();
            m_weight_2 = br.ReadSingle();
            m_weight_3 = br.ReadSingle();
            m_weight_4 = br.ReadSingle();
            m_weight_5 = br.ReadSingle();
            m_weight_6 = br.ReadSingle();
            m_weight_7 = br.ReadSingle();
            m_weight_8 = br.ReadSingle();
            m_weight_9 = br.ReadSingle();
            m_weight_10 = br.ReadSingle();
            m_weight_11 = br.ReadSingle();
            m_weight_12 = br.ReadSingle();
            m_weight_13 = br.ReadSingle();
            m_weight_14 = br.ReadSingle();
            m_weight_15 = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4(bw, m_frameVector_0);
            s.WriteVector4(bw, m_frameVector_1);
            s.WriteVector4(bw, m_frameVector_2);
            s.WriteVector4(bw, m_frameVector_3);
            s.WriteVector4(bw, m_frameVector_4);
            s.WriteVector4(bw, m_frameVector_5);
            s.WriteVector4(bw, m_frameVector_6);
            s.WriteVector4(bw, m_frameVector_7);
            s.WriteVector4(bw, m_frameVector_8);
            s.WriteVector4(bw, m_frameVector_9);
            s.WriteVector4(bw, m_frameVector_10);
            s.WriteVector4(bw, m_frameVector_11);
            s.WriteVector4(bw, m_frameVector_12);
            s.WriteVector4(bw, m_frameVector_13);
            s.WriteVector4(bw, m_frameVector_14);
            s.WriteVector4(bw, m_frameVector_15);
            bw.WriteUInt16(m_particleIndex_0);
            bw.WriteUInt16(m_particleIndex_1);
            bw.WriteUInt16(m_particleIndex_2);
            bw.WriteUInt16(m_particleIndex_3);
            bw.WriteUInt16(m_particleIndex_4);
            bw.WriteUInt16(m_particleIndex_5);
            bw.WriteUInt16(m_particleIndex_6);
            bw.WriteUInt16(m_particleIndex_7);
            bw.WriteUInt16(m_particleIndex_8);
            bw.WriteUInt16(m_particleIndex_9);
            bw.WriteUInt16(m_particleIndex_10);
            bw.WriteUInt16(m_particleIndex_11);
            bw.WriteUInt16(m_particleIndex_12);
            bw.WriteUInt16(m_particleIndex_13);
            bw.WriteUInt16(m_particleIndex_14);
            bw.WriteUInt16(m_particleIndex_15);
            bw.WriteSingle(m_weight_0);
            bw.WriteSingle(m_weight_1);
            bw.WriteSingle(m_weight_2);
            bw.WriteSingle(m_weight_3);
            bw.WriteSingle(m_weight_4);
            bw.WriteSingle(m_weight_5);
            bw.WriteSingle(m_weight_6);
            bw.WriteSingle(m_weight_7);
            bw.WriteSingle(m_weight_8);
            bw.WriteSingle(m_weight_9);
            bw.WriteSingle(m_weight_10);
            bw.WriteSingle(m_weight_11);
            bw.WriteSingle(m_weight_12);
            bw.WriteSingle(m_weight_13);
            bw.WriteSingle(m_weight_14);
            bw.WriteSingle(m_weight_15);
        }
    }
}