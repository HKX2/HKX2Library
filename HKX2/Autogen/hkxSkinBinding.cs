using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkxSkinBinding : hkReferencedObject
    {
        public List<Matrix4x4> m_bindPose;
        public Matrix4x4 m_initSkinTransform;

        public List<string> m_nodeNames;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_nodeNames = des.ReadStringPointerArray(br);
            m_bindPose = des.ReadMatrix4Array(br);
            br.ReadUInt64();
            m_initSkinTransform = des.ReadMatrix4(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            s.WriteStringPointerArray(bw, m_nodeNames);
            s.WriteMatrix4Array(bw, m_bindPose);
            bw.WriteUInt64(0);
            s.WriteMatrix4(bw, m_initSkinTransform);
        }
    }
}