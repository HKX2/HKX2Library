namespace HKX2
{
    public class hkcdDynamicTreeCodecInt16 : IHavokObject
    {
        public hkcdDynamicTreeCodecInt16IntAabb m_aabb;
        public uint m_children_0;
        public uint m_children_1;
        public uint m_pad;
        public uint m_parent;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_aabb = new hkcdDynamicTreeCodecInt16IntAabb();
            m_aabb.Read(des, br);
            m_parent = br.ReadUInt32();
            m_children_0 = br.ReadUInt32();
            m_children_1 = br.ReadUInt32();
            m_pad = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_aabb.Write(s, bw);
            bw.WriteUInt32(m_parent);
            bw.WriteUInt32(m_children_0);
            bw.WriteUInt32(m_children_1);
            bw.WriteUInt32(m_pad);
        }
    }
}