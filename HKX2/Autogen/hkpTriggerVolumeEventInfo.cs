namespace HKX2
{
    public class hkpTriggerVolumeEventInfo : IHavokObject
    {
        public hkpRigidBody m_body;
        public Operation m_operation;

        public ulong m_sortValue;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_sortValue = br.ReadUInt64();
            m_body = des.ReadClassPointer<hkpRigidBody>(br);
            m_operation = (Operation) br.ReadInt32();
            br.ReadUInt32();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteUInt64(m_sortValue);
            s.WriteClassPointer(bw, m_body);
            bw.WriteInt32((int) m_operation);
            bw.WriteUInt32(0);
        }
    }
}