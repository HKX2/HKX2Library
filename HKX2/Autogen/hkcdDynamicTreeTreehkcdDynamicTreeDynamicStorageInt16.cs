namespace HKX2
{
    public class hkcdDynamicTreeTreehkcdDynamicTreeDynamicStorageInt16 : hkcdDynamicTreeDynamicStorageInt16
    {
        public uint m_numLeaves;
        public uint m_path;
        public uint m_root;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_numLeaves = br.ReadUInt32();
            m_path = br.ReadUInt32();
            m_root = br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt32(m_numLeaves);
            bw.WriteUInt32(m_path);
            bw.WriteUInt32(m_root);
        }
    }
}