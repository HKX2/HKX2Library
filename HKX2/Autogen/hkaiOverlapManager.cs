using System.Collections.Generic;

namespace HKX2
{
    public enum UpdateFlags
    {
        UPDATE_NORMAL = 0,
        UPDATE_FORCE_ALL = 1
    }

    public class hkaiOverlapManager : hkReferencedObject
    {
        public float m_hasMovedTolerance;
        public int m_maxCutFacesPerStep;
        public hkaiStreamingCollection m_navMeshCollection;

        public hkaiReferenceFrameAndExtrusion m_referenceFrameAndExtrusion;
        public List<hkaiOverlapManagerSection> m_sections;
        public int m_stepCount;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            br.ReadUInt64();
            br.ReadUInt64();
            m_referenceFrameAndExtrusion = new hkaiReferenceFrameAndExtrusion();
            m_referenceFrameAndExtrusion.Read(des, br);
            m_navMeshCollection = des.ReadClassPointer<hkaiStreamingCollection>(br);
            m_sections = des.ReadClassArray<hkaiOverlapManagerSection>(br);
            m_stepCount = br.ReadInt32();
            m_hasMovedTolerance = br.ReadSingle();
            m_maxCutFacesPerStep = br.ReadInt32();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            m_referenceFrameAndExtrusion.Write(s, bw);
            s.WriteClassPointer(bw, m_navMeshCollection);
            s.WriteClassArray(bw, m_sections);
            bw.WriteInt32(m_stepCount);
            bw.WriteSingle(m_hasMovedTolerance);
            bw.WriteInt32(m_maxCutFacesPerStep);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
        }
    }
}