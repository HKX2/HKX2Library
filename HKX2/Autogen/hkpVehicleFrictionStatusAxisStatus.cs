namespace HKX2
{
    public class hkpVehicleFrictionStatusAxisStatus : IHavokObject
    {
        public float m_delayed_forward_impulse;

        public float m_forward_slip_velocity;
        public float m_forwardRhs;
        public float m_relativeForwardForce;
        public float m_relativeSideForce;
        public float m_side_force;
        public float m_side_slip_velocity;
        public float m_sideRhs;
        public float m_skid_energy_density;
        public virtual uint Signature => 0;

        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_forward_slip_velocity = br.ReadSingle();
            m_side_slip_velocity = br.ReadSingle();
            m_skid_energy_density = br.ReadSingle();
            m_side_force = br.ReadSingle();
            m_delayed_forward_impulse = br.ReadSingle();
            m_sideRhs = br.ReadSingle();
            m_forwardRhs = br.ReadSingle();
            m_relativeSideForce = br.ReadSingle();
            m_relativeForwardForce = br.ReadSingle();
        }

        public virtual void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            bw.WriteSingle(m_forward_slip_velocity);
            bw.WriteSingle(m_side_slip_velocity);
            bw.WriteSingle(m_skid_energy_density);
            bw.WriteSingle(m_side_force);
            bw.WriteSingle(m_delayed_forward_impulse);
            bw.WriteSingle(m_sideRhs);
            bw.WriteSingle(m_forwardRhs);
            bw.WriteSingle(m_relativeSideForce);
            bw.WriteSingle(m_relativeForwardForce);
        }
    }
}