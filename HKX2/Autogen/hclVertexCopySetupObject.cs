namespace HKX2
{
    public class hclVertexCopySetupObject : hclOperatorSetupObject
    {
        public bool m_copyNormals;
        public hclBufferSetupObject m_inputBufferSetupObject;

        public string m_name;
        public hclBufferSetupObject m_outputBufferSetupObject;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_name = des.ReadStringPointer(br);
            m_inputBufferSetupObject = des.ReadClassPointer<hclBufferSetupObject>(br);
            m_outputBufferSetupObject = des.ReadClassPointer<hclBufferSetupObject>(br);
            m_copyNormals = br.ReadBoolean();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_name);
            s.WriteClassPointer(bw, m_inputBufferSetupObject);
            s.WriteClassPointer(bw, m_outputBufferSetupObject);
            bw.WriteBoolean(m_copyNormals);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}