using System.Numerics;

namespace HKX2
{
    public enum State
    {
        STATE_NEEDS_NEW_PATH = 0,
        STATE_FOLLOWING_PATH = 1,
        STATE_SLOWING_TO_GOAL = 2,
        STATE_GOAL_REACHED = 3,
        STATE_PATH_FAILED = 4,
        STATE_WANDERED_OFF_PATH = 5,
        STATE_REPATHING_INCOMPLETE_PATH = 6,
        STATE_MANUAL_CONTROL = 7
    }

    public enum AvoidanceEnabledMaskBits
    {
        AVOID_BOUNDARIES = 1,
        AVOID_CHARACTERS = 2,
        AVOID_OBSTACLES = 4,
        AVOID_NONE = 0,
        AVOID_ALL = 7
    }

    public enum AvoidanceState
    {
        AVOIDANCE_SUCCESS = 0,
        AVOIDANCE_FAILURE = 1
    }

    public class hkaiCharacter : hkReferencedObject
    {
        public hkaiAdaptiveRanger m_adaptiveRanger;
        public uint m_agentFilterInfo;
        public uint m_agentPriority;
        public byte m_avoidanceEnabledMask;
        public hkaiAvoidanceProperties m_avoidanceProperties;
        public float m_avoidanceState;
        public ushort m_avoidanceType;
        public hkaiAstarCostModifier m_costModifier;
        public uint m_currentNavMeshFace;
        public uint m_currentNavVolumeCell;
        public float m_desiredSpeed;
        public hkaiAstarEdgeFilter m_edgeFilter;
        public Vector4 m_forward;
        public uint m_layer;
        public Vector4 m_position;
        public float m_radius;
        public State m_state;
        public Vector4 m_up;

        public ulong m_userData;
        public Vector4 m_velocity;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_userData = br.ReadUInt64();
            br.ReadUInt64();
            m_position = des.ReadVector4(br);
            m_forward = des.ReadVector4(br);
            m_velocity = des.ReadVector4(br);
            m_up = des.ReadVector4(br);
            m_currentNavMeshFace = br.ReadUInt32();
            m_currentNavVolumeCell = br.ReadUInt32();
            m_radius = br.ReadSingle();
            m_desiredSpeed = br.ReadSingle();
            m_adaptiveRanger = new hkaiAdaptiveRanger();
            m_adaptiveRanger.Read(des, br);
            br.ReadUInt32();
            m_costModifier = des.ReadClassPointer<hkaiAstarCostModifier>(br);
            m_edgeFilter = des.ReadClassPointer<hkaiAstarEdgeFilter>(br);
            br.ReadUInt64();
            br.ReadUInt64();
            m_agentFilterInfo = br.ReadUInt32();
            br.ReadUInt32();
            m_avoidanceProperties = des.ReadClassPointer<hkaiAvoidanceProperties>(br);
            m_avoidanceState = br.ReadSingle();
            m_agentPriority = br.ReadUInt32();
            m_avoidanceType = br.ReadUInt16();
            m_avoidanceEnabledMask = br.ReadByte();
            br.ReadUInt32();
            br.ReadByte();
            m_state = (State) br.ReadInt32();
            br.ReadUInt64();
            br.ReadUInt64();
            br.ReadUInt32();
            m_layer = br.ReadUInt32();
            br.ReadUInt64();
            br.ReadUInt32();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            bw.WriteUInt64(m_userData);
            bw.WriteUInt64(0);
            s.WriteVector4(bw, m_position);
            s.WriteVector4(bw, m_forward);
            s.WriteVector4(bw, m_velocity);
            s.WriteVector4(bw, m_up);
            bw.WriteUInt32(m_currentNavMeshFace);
            bw.WriteUInt32(m_currentNavVolumeCell);
            bw.WriteSingle(m_radius);
            bw.WriteSingle(m_desiredSpeed);
            m_adaptiveRanger.Write(s, bw);
            bw.WriteUInt32(0);
            s.WriteClassPointer(bw, m_costModifier);
            s.WriteClassPointer(bw, m_edgeFilter);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt32(m_agentFilterInfo);
            bw.WriteUInt32(0);
            s.WriteClassPointer(bw, m_avoidanceProperties);
            bw.WriteSingle(m_avoidanceState);
            bw.WriteUInt32(m_agentPriority);
            bw.WriteUInt16(m_avoidanceType);
            bw.WriteByte(m_avoidanceEnabledMask);
            bw.WriteUInt32(0);
            bw.WriteByte(0);
            bw.WriteInt32((int) m_state);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteUInt32(m_layer);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
        }
    }
}