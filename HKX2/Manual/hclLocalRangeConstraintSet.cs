using System.Collections.Generic;

namespace HKX2
{
    public enum ShapeType
    {
        SHAPE_SPHERE = 0,
        SHAPE_CYLINDER = 1
    }

    public enum ForceUpgrade6
    {
        HCL_FORCE_UPGRADE6 = 0
    }

    public class hclLocalRangeConstraintSet : hclConstraintSet
    {
        public bool m_applyNormalComponent;

        public List<hclLocalRangeConstraintSetLocalConstraint> m_localConstraints;
        public uint m_referenceMeshBufferIdx;
        public ShapeType m_shapeType;
        public float m_stiffness;
        public override uint Signature => 0x82567805;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_localConstraints = des.ReadClassArray<hclLocalRangeConstraintSetLocalConstraint>(br);
            m_referenceMeshBufferIdx = br.ReadUInt32();
            m_stiffness = br.ReadSingle();
            m_shapeType = (ShapeType) br.ReadUInt32();
            m_applyNormalComponent = br.ReadBoolean();
            br.ReadByte();
            br.ReadUInt16();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassArray(bw, m_localConstraints);
            bw.WriteUInt32(m_referenceMeshBufferIdx);
            bw.WriteSingle(m_stiffness);
            bw.WriteUInt32((uint) m_shapeType);
            bw.WriteBoolean(m_applyNormalComponent);
            bw.WriteByte(0);
            bw.WriteUInt16(0);
        }
    }
}