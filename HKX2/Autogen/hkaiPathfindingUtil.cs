namespace HKX2
{
    public enum NearestFeatureType
    {
        CALLBACK_EDGE = 0,
        CALLBACK_FACE = 1
    }

    public class hkaiPathfindingUtil : IHavokObject
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