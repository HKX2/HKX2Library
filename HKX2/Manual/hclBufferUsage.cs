namespace HKX2
{
    public class hclBufferUsage : IHavokObject
    {
        public enum Component
        {
            COMPONENT_POSITION = 0,
            COMPONENT_NORMAL = 1,
            COMPONENT_TANGENT = 2,
            COMPONENT_BITANGENT = 3
        }

        public enum InternalFlags
        {
            USAGE_NONE = 0,
            USAGE_READ = 1,
            USAGE_WRITE = 2,
            USAGE_FULL_WRITE = 4,
            USAGE_READ_BEFORE_WRITE = 8
        }

        public byte m_perComponentFlags_0;
        public byte m_perComponentFlags_1;
        public byte m_perComponentFlags_2;
        public byte m_perComponentFlags_3;
        public bool m_trianglesRead;
        public virtual uint Signature => 0x0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_perComponentFlags_0 = br.ReadByte();
            m_perComponentFlags_1 = br.ReadByte();
            m_perComponentFlags_2 = br.ReadByte();
            m_perComponentFlags_3 = br.ReadByte();
            m_trianglesRead = br.ReadBoolean();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteByte(m_perComponentFlags_0);
            bw.WriteByte(m_perComponentFlags_1);
            bw.WriteByte(m_perComponentFlags_2);
            bw.WriteByte(m_perComponentFlags_3);
            bw.WriteBoolean(m_trianglesRead);
        }
    }
}