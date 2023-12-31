using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public enum ConstructionFlagsBits
    {
        MATERIAL_WALKABLE = 1,
        MATERIAL_CUTTING = 2,
        MATERIAL_WALKABLE_AND_CUTTING = 3
    }

    public enum CharacterWidthUsage
    {
        NONE = 0,
        BLOCK_EDGES = 1,
        SHRINK_NAV_MESH = 2
    }

    public enum TriangleWinding
    {
        WINDING_CCW = 0,
        WINDING_CW = 1
    }

    public enum EdgeMatchingMetric
    {
        ORDER_BY_OVERLAP = 1,
        ORDER_BY_DISTANCE = 2
    }

    public class hkaiNavMeshGenerationSettings : hkReferencedObject
    {
        public hkAabb m_boundsAabb;
        public int m_carvedCuttingMaterialDeprecated;
        public int m_carvedMaterialDeprecated;
        public List<hkaiCarver> m_carvers;

        public float m_characterHeight;
        public CharacterWidthUsage m_characterWidthUsage;
        public bool m_checkEdgeGeometryConsistency;
        public float m_convexThreshold;
        public uint m_defaultConstructionProperties;
        public float m_degenerateAreaThreshold;
        public float m_degenerateWidthThreshold;
        public int m_edgeConnectionIterations;
        public EdgeMatchingMetric m_edgeMatchingMetric;
        public hkaiNavMeshEdgeMatchingParameters m_edgeMatchingParams;
        public bool m_enableSimplification;
        public bool m_fixupOverlappingTriangles;
        public List<hkaiNavMeshGenerationSettingsMaterialConstructionPair> m_materialMap;
        public int m_maxNumEdgesPerFace;
        public float m_maxWalkableSlope;
        public float m_minCharacterWidth;
        public hkaiOverlappingTrianglesSettings m_overlappingTrianglesSettings;
        public List<hkaiNavMeshGenerationSettingsOverrideSettings> m_overrideSettings;
        public List<hkaiMaterialPainter> m_painters;
        public float m_quantizationGridSize;
        public hkaiNavMeshGenerationSettingsRegionPruningSettings m_regionPruningSettings;
        public bool m_saveInputSnapshot;
        public hkaiNavMeshSimplificationUtilsSettings m_simplificationSettings;
        public string m_snapshotFilename;
        public TriangleWinding m_triangleWinding;
        public Vector4 m_up;
        public hkaiNavMeshGenerationSettingsWallClimbingSettings m_wallClimbingSettings;
        public bool m_weldInputVertices;
        public float m_weldThreshold;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_characterHeight = br.ReadSingle();
            m_up = des.ReadVector4(br);
            m_quantizationGridSize = br.ReadSingle();
            m_maxWalkableSlope = br.ReadSingle();
            m_triangleWinding = (TriangleWinding) br.ReadByte();
            br.ReadUInt16();
            br.ReadByte();
            m_degenerateAreaThreshold = br.ReadSingle();
            m_degenerateWidthThreshold = br.ReadSingle();
            m_convexThreshold = br.ReadSingle();
            m_maxNumEdgesPerFace = br.ReadInt32();
            m_edgeMatchingParams = new hkaiNavMeshEdgeMatchingParameters();
            m_edgeMatchingParams.Read(des, br);
            m_edgeMatchingMetric = (EdgeMatchingMetric) br.ReadUInt32();
            m_edgeConnectionIterations = br.ReadInt32();
            br.ReadUInt32();
            m_regionPruningSettings = new hkaiNavMeshGenerationSettingsRegionPruningSettings();
            m_regionPruningSettings.Read(des, br);
            m_wallClimbingSettings = new hkaiNavMeshGenerationSettingsWallClimbingSettings();
            m_wallClimbingSettings.Read(des, br);
            br.ReadUInt64();
            br.ReadUInt32();
            br.ReadUInt16();
            m_boundsAabb = new hkAabb();
            m_boundsAabb.Read(des, br);
            m_carvers = des.ReadClassPointerArray<hkaiCarver>(br);
            m_painters = des.ReadClassPointerArray<hkaiMaterialPainter>(br);
            br.ReadUInt64();
            m_defaultConstructionProperties = br.ReadUInt32();
            br.ReadUInt32();
            m_materialMap = des.ReadClassArray<hkaiNavMeshGenerationSettingsMaterialConstructionPair>(br);
            m_fixupOverlappingTriangles = br.ReadBoolean();
            br.ReadUInt16();
            br.ReadByte();
            m_overlappingTrianglesSettings = new hkaiOverlappingTrianglesSettings();
            m_overlappingTrianglesSettings.Read(des, br);
            m_weldInputVertices = br.ReadBoolean();
            br.ReadUInt16();
            br.ReadByte();
            m_weldThreshold = br.ReadSingle();
            m_minCharacterWidth = br.ReadSingle();
            m_characterWidthUsage = (CharacterWidthUsage) br.ReadByte();
            m_enableSimplification = br.ReadBoolean();
            br.ReadUInt16();
            m_simplificationSettings = new hkaiNavMeshSimplificationUtilsSettings();
            m_simplificationSettings.Read(des, br);
            m_carvedMaterialDeprecated = br.ReadInt32();
            m_carvedCuttingMaterialDeprecated = br.ReadInt32();
            m_checkEdgeGeometryConsistency = br.ReadBoolean();
            m_saveInputSnapshot = br.ReadBoolean();
            br.ReadUInt32();
            br.ReadUInt16();
            m_snapshotFilename = des.ReadStringPointer(br);
            m_overrideSettings = des.ReadClassArray<hkaiNavMeshGenerationSettingsOverrideSettings>(br);
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteSingle(m_characterHeight);
            s.WriteVector4(bw, m_up);
            bw.WriteSingle(m_quantizationGridSize);
            bw.WriteSingle(m_maxWalkableSlope);
            bw.WriteByte((byte) m_triangleWinding);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            bw.WriteSingle(m_degenerateAreaThreshold);
            bw.WriteSingle(m_degenerateWidthThreshold);
            bw.WriteSingle(m_convexThreshold);
            bw.WriteInt32(m_maxNumEdgesPerFace);
            m_edgeMatchingParams.Write(s, bw);
            bw.WriteUInt32((uint) m_edgeMatchingMetric);
            bw.WriteInt32(m_edgeConnectionIterations);
            bw.WriteUInt32(0);
            m_regionPruningSettings.Write(s, bw);
            m_wallClimbingSettings.Write(s, bw);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            m_boundsAabb.Write(s, bw);
            s.WriteClassPointerArray(bw, m_carvers);
            s.WriteClassPointerArray(bw, m_painters);
            bw.WriteUInt64(0);
            bw.WriteUInt32(m_defaultConstructionProperties);
            bw.WriteUInt32(0);
            s.WriteClassArray(bw, m_materialMap);
            bw.WriteBoolean(m_fixupOverlappingTriangles);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            m_overlappingTrianglesSettings.Write(s, bw);
            bw.WriteBoolean(m_weldInputVertices);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
            bw.WriteSingle(m_weldThreshold);
            bw.WriteSingle(m_minCharacterWidth);
            bw.WriteByte((byte) m_characterWidthUsage);
            bw.WriteBoolean(m_enableSimplification);
            bw.WriteUInt16(0);
            m_simplificationSettings.Write(s, bw);
            bw.WriteInt32(m_carvedMaterialDeprecated);
            bw.WriteInt32(m_carvedCuttingMaterialDeprecated);
            bw.WriteBoolean(m_checkEdgeGeometryConsistency);
            bw.WriteBoolean(m_saveInputSnapshot);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            s.WriteStringPointer(bw, m_snapshotFilename);
            s.WriteClassArray(bw, m_overrideSettings);
            bw.WriteUInt64(0);
        }
    }
}