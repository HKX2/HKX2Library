using System.Collections.Generic;

namespace HKX2
{
    public enum BuildType
    {
        BUILT_WITH_CHUNK_SUBDIVISION = 0,
        BUILT_WITHOUT_CHUNK_SUBDIVISION = 1,
        BUILD_NOT_SET = 2
    }

    public class hkpMoppCode : hkReferencedObject
    {
        public BuildType m_buildType;
        public List<byte> m_data;

        public hkpMoppCodeCodeInfo m_info;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_info = new hkpMoppCodeCodeInfo();
            m_info.Read(des, br);
            m_data = des.ReadByteArray(br);
            m_buildType = (BuildType) br.ReadSByte();
            br.ReadUInt64();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            m_info.Write(s, bw);
            s.WriteByteArray(bw, m_data);
            bw.WriteSByte((sbyte) m_buildType);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}