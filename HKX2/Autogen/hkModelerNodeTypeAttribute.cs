namespace HKX2
{
    public enum ModelerType
    {
        DEFAULT = 0,
        LOCATOR = 1
    }

    public class hkModelerNodeTypeAttribute : IHavokObject
    {
        public ModelerType m_type;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_type = (ModelerType) br.ReadSByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSByte((sbyte) m_type);
        }
    }
}