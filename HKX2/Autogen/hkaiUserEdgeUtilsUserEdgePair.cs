using System.Numerics;

namespace HKX2
{
    public class hkaiUserEdgeUtilsUserEdgePair : IHavokObject
    {
        public short m_costAtoB;
        public short m_costBtoA;
        public UserEdgeDirection m_direction;
        public int m_faceA;
        public int m_faceB;
        public uint m_instanceUidA;
        public uint m_instanceUidB;
        public int m_userDataA;
        public int m_userDataB;

        public Vector4 m_x;
        public Vector4 m_y;
        public Vector4 m_z;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_x = des.ReadVector4(br);
            m_y = des.ReadVector4(br);
            m_z = des.ReadVector4(br);
            m_instanceUidA = br.ReadUInt32();
            m_instanceUidB = br.ReadUInt32();
            m_faceA = br.ReadInt32();
            m_faceB = br.ReadInt32();
            m_userDataA = br.ReadInt32();
            m_userDataB = br.ReadInt32();
            m_costAtoB = br.ReadInt16();
            m_costBtoA = br.ReadInt16();
            m_direction = (UserEdgeDirection) br.ReadByte();
            br.ReadUInt16();
            br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            s.WriteVector4(bw, m_x);
            s.WriteVector4(bw, m_y);
            s.WriteVector4(bw, m_z);
            bw.WriteUInt32(m_instanceUidA);
            bw.WriteUInt32(m_instanceUidB);
            bw.WriteInt32(m_faceA);
            bw.WriteInt32(m_faceB);
            bw.WriteInt32(m_userDataA);
            bw.WriteInt32(m_userDataB);
            bw.WriteInt16(m_costAtoB);
            bw.WriteInt16(m_costBtoA);
            bw.WriteByte((byte) m_direction);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}