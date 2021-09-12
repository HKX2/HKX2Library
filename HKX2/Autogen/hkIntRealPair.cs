namespace HKX2
{
    public class hkIntRealPair : IHavokObject
    {
        public int m_key;
        public float m_value;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_key = br.ReadInt32();
            m_value = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteInt32(m_key);
            bw.WriteSingle(m_value);
        }
    }
}