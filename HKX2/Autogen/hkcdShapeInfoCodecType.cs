namespace HKX2
{
    public enum ShapeInfoCodecTypeEnum
    {
        NULL_CODEC = 0,
        UFM358 = 1,
        MAX_NUM_CODECS = 16
    }

    public class hkcdShapeInfoCodecType : IHavokObject
    {
        public virtual uint Signature => 0;


        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            br.ReadByte();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteByte(0);
        }
    }
}