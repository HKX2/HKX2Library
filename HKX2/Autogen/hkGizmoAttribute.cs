namespace HKX2
{
    public enum GizmoType
    {
        POINT = 0,
        SPHERE = 1,
        PLANE = 2,
        ARROW = 3
    }

    public class hkGizmoAttribute : IHavokObject
    {
        public string m_label;
        public GizmoType m_type;

        public bool m_visible;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_visible = br.ReadBoolean();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
            m_label = des.ReadStringPointer(br);
            m_type = (GizmoType) br.ReadSByte();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteBoolean(m_visible);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            s.WriteStringPointer(bw, m_label);
            bw.WriteSByte((sbyte) m_type);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}