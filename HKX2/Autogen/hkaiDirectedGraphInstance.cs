using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkaiDirectedGraphInstance : hkReferencedObject
    {
        public List<hkaiDirectedGraphInstanceFreeBlockList> m_freeEdgeBlocks;
        public List<hkaiDirectedGraphExplicitCostNode> m_instancedNodes;
        public List<int> m_nodeMap;
        public hkaiDirectedGraphExplicitCost m_originalGraph;
        public List<uint> m_ownedEdgeData;
        public List<hkaiDirectedGraphExplicitCostEdge> m_ownedEdges;
        public int m_runtimeId;

        public uint m_sectionUid;
        public Matrix4x4 m_transform;
        public List<int> m_userEdgeCount;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt32();
            m_sectionUid = br.ReadUInt32();
            m_runtimeId = br.ReadInt32();
            br.ReadUInt32();
            m_originalGraph = des.ReadClassPointer<hkaiDirectedGraphExplicitCost>(br);
            m_nodeMap = des.ReadInt32Array(br);
            m_instancedNodes = des.ReadClassArray<hkaiDirectedGraphExplicitCostNode>(br);
            m_ownedEdges = des.ReadClassArray<hkaiDirectedGraphExplicitCostEdge>(br);
            m_ownedEdgeData = des.ReadUInt32Array(br);
            m_userEdgeCount = des.ReadInt32Array(br);
            m_freeEdgeBlocks = des.ReadClassArray<hkaiDirectedGraphInstanceFreeBlockList>(br);
            br.ReadUInt64();
            m_transform = des.ReadTransform(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteUInt32(m_sectionUid);
            bw.WriteInt32(m_runtimeId);
            bw.WriteUInt32(0);
            s.WriteClassPointer(bw, m_originalGraph);
            s.WriteInt32Array(bw, m_nodeMap);
            s.WriteClassArray(bw, m_instancedNodes);
            s.WriteClassArray(bw, m_ownedEdges);
            s.WriteUInt32Array(bw, m_ownedEdgeData);
            s.WriteInt32Array(bw, m_userEdgeCount);
            s.WriteClassArray(bw, m_freeEdgeBlocks);
            bw.WriteUInt64(0);
            s.WriteTransform(bw, m_transform);
        }
    }
}