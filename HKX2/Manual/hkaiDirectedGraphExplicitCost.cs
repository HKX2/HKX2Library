using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public enum EdgeBits
    {
        EDGE_IS_USER = 2,
        EDGE_EXTERNAL_OPPOSITE = 64
    }

    public class hkaiDirectedGraphExplicitCost : hkReferencedObject
    {
        public enum Constants
        {
            INVALID_NODE_INDEX = -1,
            INVALID_EDGE_INDEX = -1,
            INVALID_VERTEX_INDEX = -1
        }

        public List<uint> m_edgeData;
        public int m_edgeDataStriding;
        public List<hkaiDirectedGraphExplicitCostEdge> m_edges;
        public List<uint> m_nodeData;
        public int m_nodeDataStriding;
        public List<hkaiDirectedGraphExplicitCostNode> m_nodes;

        public List<Vector4> m_positions;
        public List<hkaiStreamingSet> m_streamingSets;
        public override uint Signature => 0x2F02D92C;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_positions = des.ReadVector4Array(br);
            m_nodes = des.ReadClassArray<hkaiDirectedGraphExplicitCostNode>(br);
            m_edges = des.ReadClassArray<hkaiDirectedGraphExplicitCostEdge>(br);
            m_nodeData = des.ReadUInt32Array(br);
            m_edgeData = des.ReadUInt32Array(br);
            m_nodeDataStriding = br.ReadInt32();
            m_edgeDataStriding = br.ReadInt32();
            m_streamingSets = des.ReadClassArray<hkaiStreamingSet>(br);
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteVector4Array(bw, m_positions);
            s.WriteClassArray(bw, m_nodes);
            s.WriteClassArray(bw, m_edges);
            s.WriteUInt32Array(bw, m_nodeData);
            s.WriteUInt32Array(bw, m_edgeData);
            bw.WriteInt32(m_nodeDataStriding);
            bw.WriteInt32(m_edgeDataStriding);
            s.WriteClassArray(bw, m_streamingSets);
        }
    }
}