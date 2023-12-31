namespace HKX2
{
    public class hkcdDynamicTreeCodec32 : IHavokObject
    {
        public hkAabb m_aabb;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_aabb = new hkAabb();
            m_aabb.Read(des, br);
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            m_aabb.Write(s, bw);
        }
    }
}