namespace HKX2
{
    public enum WalkableTriangleSettings
    {
        ONLY_FIX_WALKABLE = 0,
        PREFER_WALKABLE = 1,
        PREFER_UNWALKABLE = 2
    }

    public class hkaiOverlappingTriangles : IHavokObject
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