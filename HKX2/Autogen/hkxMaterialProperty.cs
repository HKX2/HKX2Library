namespace HKX2
{
    public class hkxMaterialProperty : IHavokObject
    {
        public uint m_key;
        public uint m_value;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_key = br.ReadUInt32();
            m_value = br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt32(m_key);
            bw.WriteUInt32(m_value);
        }
    }
}