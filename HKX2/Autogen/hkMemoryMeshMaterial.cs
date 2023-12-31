using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkMemoryMeshMaterial : hkMeshMaterial
    {
        public Vector4 m_ambientColor;
        public Vector4 m_diffuseColor;
        public float m_displacementAmount;
        public Vector4 m_emissiveColor;

        public string m_materialName;
        public Vector4 m_specularColor;
        public float m_tesselationFactor;
        public List<hkMeshTexture> m_textures;
        public ulong m_userData;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_materialName = des.ReadStringPointer(br);
            m_textures = des.ReadClassPointerArray<hkMeshTexture>(br);
            br.ReadUInt64();
            m_diffuseColor = des.ReadVector4(br);
            m_ambientColor = des.ReadVector4(br);
            m_specularColor = des.ReadVector4(br);
            m_emissiveColor = des.ReadVector4(br);
            m_userData = br.ReadUInt64();
            m_tesselationFactor = br.ReadSingle();
            m_displacementAmount = br.ReadSingle();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteStringPointer(bw, m_materialName);
            s.WriteClassPointerArray(bw, m_textures);
            bw.WriteUInt64(0);
            s.WriteVector4(bw, m_diffuseColor);
            s.WriteVector4(bw, m_ambientColor);
            s.WriteVector4(bw, m_specularColor);
            s.WriteVector4(bw, m_emissiveColor);
            bw.WriteUInt64(m_userData);
            bw.WriteSingle(m_tesselationFactor);
            bw.WriteSingle(m_displacementAmount);
        }
    }
}