namespace HKX2
{
    public enum BvTreeType
    {
        BVTREE_MOPP = 0,
        BVTREE_TRISAMPLED_HEIGHTFIELD = 1,
        BVTREE_STATIC_COMPOUND = 2,
        BVTREE_COMPRESSED_MESH = 3,
        BVTREE_USER = 4,
        BVTREE_MAX = 5
    }

    public class hkpBvTreeShape : hkpShape
    {
        public BvTreeType m_bvTreeType;
        public override uint Signature => 0x0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_bvTreeType = (BvTreeType) br.ReadByte();
            br.ReadByte();
            br.ReadUInt16();

            if (des._header.PointerSize == 8) br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteByte((byte) m_bvTreeType);
            bw.WriteByte(0);
            bw.WriteUInt16(0);

            if (s._header.PointerSize == 8) bw.WriteUInt32(0);
        }
    }
}