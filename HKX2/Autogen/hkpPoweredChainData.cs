using System.Collections.Generic;

namespace HKX2
{
    public class hkpPoweredChainData : hkpConstraintChainData
    {
        public hkpBridgeAtoms m_atoms;
        public float m_cfmAngAdd;
        public float m_cfmAngMul;
        public float m_cfmLinAdd;
        public float m_cfmLinMul;
        public float m_damping;
        public List<hkpPoweredChainDataConstraintInfo> m_infos;
        public float m_maxErrorDistance;
        public float m_tau;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            m_atoms = new hkpBridgeAtoms();
            m_atoms.Read(des, br);
            m_infos = des.ReadClassArray<hkpPoweredChainDataConstraintInfo>(br);
            m_tau = br.ReadSingle();
            m_damping = br.ReadSingle();
            m_cfmLinAdd = br.ReadSingle();
            m_cfmLinMul = br.ReadSingle();
            m_cfmAngAdd = br.ReadSingle();
            m_cfmAngMul = br.ReadSingle();
            m_maxErrorDistance = br.ReadSingle();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            m_atoms.Write(s, bw);
            s.WriteClassArray(bw, m_infos);
            bw.WriteSingle(m_tau);
            bw.WriteSingle(m_damping);
            bw.WriteSingle(m_cfmLinAdd);
            bw.WriteSingle(m_cfmLinMul);
            bw.WriteSingle(m_cfmAngAdd);
            bw.WriteSingle(m_cfmAngMul);
            bw.WriteSingle(m_maxErrorDistance);
            bw.WriteUInt32(0);
        }
    }
}