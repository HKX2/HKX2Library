using System.Collections.Generic;

namespace HKX2
{
    public enum SerializedAgentType
    {
        INVALID_AGENT_TYPE = 0,
        BOX_BOX_AGENT3 = 1,
        CAPSULE_TRIANGLE_AGENT3 = 2,
        PRED_GSK_AGENT3 = 3,
        PRED_GSK_CYLINDER_AGENT3 = 4,
        CONVEX_LIST_AGENT3 = 5,
        LIST_AGENT3 = 6,
        BV_TREE_AGENT3 = 7,
        COLLECTION_COLLECTION_AGENT3 = 8,
        COLLECTION_AGENT3 = 9
    }

    public class hkpSerializedAgentNnEntry : hkReferencedObject
    {
        public SerializedAgentType m_agentType;
        public hkpSimpleContactConstraintAtom m_atom;

        public hkpEntity m_bodyA;
        public ulong m_bodyAId;
        public hkpEntity m_bodyB;
        public ulong m_bodyBId;
        public List<hkContactPoint> m_contactPoints;
        public List<byte> m_cpIdMgr;
        public byte m_endianCheckBuffer_0;
        public byte m_endianCheckBuffer_1;
        public byte m_endianCheckBuffer_2;
        public byte m_endianCheckBuffer_3;
        public byte m_nnEntryData_0;
        public byte m_nnEntryData_1;
        public byte m_nnEntryData_10;
        public byte m_nnEntryData_100;
        public byte m_nnEntryData_101;
        public byte m_nnEntryData_102;
        public byte m_nnEntryData_103;
        public byte m_nnEntryData_104;
        public byte m_nnEntryData_105;
        public byte m_nnEntryData_106;
        public byte m_nnEntryData_107;
        public byte m_nnEntryData_108;
        public byte m_nnEntryData_109;
        public byte m_nnEntryData_11;
        public byte m_nnEntryData_110;
        public byte m_nnEntryData_111;
        public byte m_nnEntryData_112;
        public byte m_nnEntryData_113;
        public byte m_nnEntryData_114;
        public byte m_nnEntryData_115;
        public byte m_nnEntryData_116;
        public byte m_nnEntryData_117;
        public byte m_nnEntryData_118;
        public byte m_nnEntryData_119;
        public byte m_nnEntryData_12;
        public byte m_nnEntryData_120;
        public byte m_nnEntryData_121;
        public byte m_nnEntryData_122;
        public byte m_nnEntryData_123;
        public byte m_nnEntryData_124;
        public byte m_nnEntryData_125;
        public byte m_nnEntryData_126;
        public byte m_nnEntryData_127;
        public byte m_nnEntryData_128;
        public byte m_nnEntryData_129;
        public byte m_nnEntryData_13;
        public byte m_nnEntryData_130;
        public byte m_nnEntryData_131;
        public byte m_nnEntryData_132;
        public byte m_nnEntryData_133;
        public byte m_nnEntryData_134;
        public byte m_nnEntryData_135;
        public byte m_nnEntryData_136;
        public byte m_nnEntryData_137;
        public byte m_nnEntryData_138;
        public byte m_nnEntryData_139;
        public byte m_nnEntryData_14;
        public byte m_nnEntryData_140;
        public byte m_nnEntryData_141;
        public byte m_nnEntryData_142;
        public byte m_nnEntryData_143;
        public byte m_nnEntryData_144;
        public byte m_nnEntryData_145;
        public byte m_nnEntryData_146;
        public byte m_nnEntryData_147;
        public byte m_nnEntryData_148;
        public byte m_nnEntryData_149;
        public byte m_nnEntryData_15;
        public byte m_nnEntryData_150;
        public byte m_nnEntryData_151;
        public byte m_nnEntryData_152;
        public byte m_nnEntryData_153;
        public byte m_nnEntryData_154;
        public byte m_nnEntryData_155;
        public byte m_nnEntryData_156;
        public byte m_nnEntryData_157;
        public byte m_nnEntryData_158;
        public byte m_nnEntryData_159;
        public byte m_nnEntryData_16;
        public byte m_nnEntryData_160;
        public byte m_nnEntryData_161;
        public byte m_nnEntryData_162;
        public byte m_nnEntryData_163;
        public byte m_nnEntryData_164;
        public byte m_nnEntryData_165;
        public byte m_nnEntryData_166;
        public byte m_nnEntryData_167;
        public byte m_nnEntryData_168;
        public byte m_nnEntryData_169;
        public byte m_nnEntryData_17;
        public byte m_nnEntryData_170;
        public byte m_nnEntryData_171;
        public byte m_nnEntryData_172;
        public byte m_nnEntryData_173;
        public byte m_nnEntryData_174;
        public byte m_nnEntryData_175;
        public byte m_nnEntryData_176;
        public byte m_nnEntryData_177;
        public byte m_nnEntryData_178;
        public byte m_nnEntryData_179;
        public byte m_nnEntryData_18;
        public byte m_nnEntryData_180;
        public byte m_nnEntryData_181;
        public byte m_nnEntryData_182;
        public byte m_nnEntryData_183;
        public byte m_nnEntryData_184;
        public byte m_nnEntryData_185;
        public byte m_nnEntryData_186;
        public byte m_nnEntryData_187;
        public byte m_nnEntryData_188;
        public byte m_nnEntryData_189;
        public byte m_nnEntryData_19;
        public byte m_nnEntryData_190;
        public byte m_nnEntryData_191;
        public byte m_nnEntryData_2;
        public byte m_nnEntryData_20;
        public byte m_nnEntryData_21;
        public byte m_nnEntryData_22;
        public byte m_nnEntryData_23;
        public byte m_nnEntryData_24;
        public byte m_nnEntryData_25;
        public byte m_nnEntryData_26;
        public byte m_nnEntryData_27;
        public byte m_nnEntryData_28;
        public byte m_nnEntryData_29;
        public byte m_nnEntryData_3;
        public byte m_nnEntryData_30;
        public byte m_nnEntryData_31;
        public byte m_nnEntryData_32;
        public byte m_nnEntryData_33;
        public byte m_nnEntryData_34;
        public byte m_nnEntryData_35;
        public byte m_nnEntryData_36;
        public byte m_nnEntryData_37;
        public byte m_nnEntryData_38;
        public byte m_nnEntryData_39;
        public byte m_nnEntryData_4;
        public byte m_nnEntryData_40;
        public byte m_nnEntryData_41;
        public byte m_nnEntryData_42;
        public byte m_nnEntryData_43;
        public byte m_nnEntryData_44;
        public byte m_nnEntryData_45;
        public byte m_nnEntryData_46;
        public byte m_nnEntryData_47;
        public byte m_nnEntryData_48;
        public byte m_nnEntryData_49;
        public byte m_nnEntryData_5;
        public byte m_nnEntryData_50;
        public byte m_nnEntryData_51;
        public byte m_nnEntryData_52;
        public byte m_nnEntryData_53;
        public byte m_nnEntryData_54;
        public byte m_nnEntryData_55;
        public byte m_nnEntryData_56;
        public byte m_nnEntryData_57;
        public byte m_nnEntryData_58;
        public byte m_nnEntryData_59;
        public byte m_nnEntryData_6;
        public byte m_nnEntryData_60;
        public byte m_nnEntryData_61;
        public byte m_nnEntryData_62;
        public byte m_nnEntryData_63;
        public byte m_nnEntryData_64;
        public byte m_nnEntryData_65;
        public byte m_nnEntryData_66;
        public byte m_nnEntryData_67;
        public byte m_nnEntryData_68;
        public byte m_nnEntryData_69;
        public byte m_nnEntryData_7;
        public byte m_nnEntryData_70;
        public byte m_nnEntryData_71;
        public byte m_nnEntryData_72;
        public byte m_nnEntryData_73;
        public byte m_nnEntryData_74;
        public byte m_nnEntryData_75;
        public byte m_nnEntryData_76;
        public byte m_nnEntryData_77;
        public byte m_nnEntryData_78;
        public byte m_nnEntryData_79;
        public byte m_nnEntryData_8;
        public byte m_nnEntryData_80;
        public byte m_nnEntryData_81;
        public byte m_nnEntryData_82;
        public byte m_nnEntryData_83;
        public byte m_nnEntryData_84;
        public byte m_nnEntryData_85;
        public byte m_nnEntryData_86;
        public byte m_nnEntryData_87;
        public byte m_nnEntryData_88;
        public byte m_nnEntryData_89;
        public byte m_nnEntryData_9;
        public byte m_nnEntryData_90;
        public byte m_nnEntryData_91;
        public byte m_nnEntryData_92;
        public byte m_nnEntryData_93;
        public byte m_nnEntryData_94;
        public byte m_nnEntryData_95;
        public byte m_nnEntryData_96;
        public byte m_nnEntryData_97;
        public byte m_nnEntryData_98;
        public byte m_nnEntryData_99;
        public List<byte> m_propertiesStream;
        public hkpSerializedTrack1nInfo m_trackInfo;
        public bool m_useEntityIds;
        public uint m_version;
        public override uint Signature => 0;

        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_bodyA = des.ReadClassPointer<hkpEntity>(br);
            m_bodyB = des.ReadClassPointer<hkpEntity>(br);
            m_bodyAId = br.ReadUInt64();
            m_bodyBId = br.ReadUInt64();
            m_useEntityIds = br.ReadBoolean();
            m_agentType = (SerializedAgentType) br.ReadSByte();
            br.ReadUInt64();
            br.ReadUInt32();
            br.ReadUInt16();
            m_atom = new hkpSimpleContactConstraintAtom();
            m_atom.Read(des, br);
            m_propertiesStream = des.ReadByteArray(br);
            m_contactPoints = des.ReadClassArray<hkContactPoint>(br);
            m_cpIdMgr = des.ReadByteArray(br);
            m_nnEntryData_0 = br.ReadByte();
            m_nnEntryData_1 = br.ReadByte();
            m_nnEntryData_2 = br.ReadByte();
            m_nnEntryData_3 = br.ReadByte();
            m_nnEntryData_4 = br.ReadByte();
            m_nnEntryData_5 = br.ReadByte();
            m_nnEntryData_6 = br.ReadByte();
            m_nnEntryData_7 = br.ReadByte();
            m_nnEntryData_8 = br.ReadByte();
            m_nnEntryData_9 = br.ReadByte();
            m_nnEntryData_10 = br.ReadByte();
            m_nnEntryData_11 = br.ReadByte();
            m_nnEntryData_12 = br.ReadByte();
            m_nnEntryData_13 = br.ReadByte();
            m_nnEntryData_14 = br.ReadByte();
            m_nnEntryData_15 = br.ReadByte();
            m_nnEntryData_16 = br.ReadByte();
            m_nnEntryData_17 = br.ReadByte();
            m_nnEntryData_18 = br.ReadByte();
            m_nnEntryData_19 = br.ReadByte();
            m_nnEntryData_20 = br.ReadByte();
            m_nnEntryData_21 = br.ReadByte();
            m_nnEntryData_22 = br.ReadByte();
            m_nnEntryData_23 = br.ReadByte();
            m_nnEntryData_24 = br.ReadByte();
            m_nnEntryData_25 = br.ReadByte();
            m_nnEntryData_26 = br.ReadByte();
            m_nnEntryData_27 = br.ReadByte();
            m_nnEntryData_28 = br.ReadByte();
            m_nnEntryData_29 = br.ReadByte();
            m_nnEntryData_30 = br.ReadByte();
            m_nnEntryData_31 = br.ReadByte();
            m_nnEntryData_32 = br.ReadByte();
            m_nnEntryData_33 = br.ReadByte();
            m_nnEntryData_34 = br.ReadByte();
            m_nnEntryData_35 = br.ReadByte();
            m_nnEntryData_36 = br.ReadByte();
            m_nnEntryData_37 = br.ReadByte();
            m_nnEntryData_38 = br.ReadByte();
            m_nnEntryData_39 = br.ReadByte();
            m_nnEntryData_40 = br.ReadByte();
            m_nnEntryData_41 = br.ReadByte();
            m_nnEntryData_42 = br.ReadByte();
            m_nnEntryData_43 = br.ReadByte();
            m_nnEntryData_44 = br.ReadByte();
            m_nnEntryData_45 = br.ReadByte();
            m_nnEntryData_46 = br.ReadByte();
            m_nnEntryData_47 = br.ReadByte();
            m_nnEntryData_48 = br.ReadByte();
            m_nnEntryData_49 = br.ReadByte();
            m_nnEntryData_50 = br.ReadByte();
            m_nnEntryData_51 = br.ReadByte();
            m_nnEntryData_52 = br.ReadByte();
            m_nnEntryData_53 = br.ReadByte();
            m_nnEntryData_54 = br.ReadByte();
            m_nnEntryData_55 = br.ReadByte();
            m_nnEntryData_56 = br.ReadByte();
            m_nnEntryData_57 = br.ReadByte();
            m_nnEntryData_58 = br.ReadByte();
            m_nnEntryData_59 = br.ReadByte();
            m_nnEntryData_60 = br.ReadByte();
            m_nnEntryData_61 = br.ReadByte();
            m_nnEntryData_62 = br.ReadByte();
            m_nnEntryData_63 = br.ReadByte();
            m_nnEntryData_64 = br.ReadByte();
            m_nnEntryData_65 = br.ReadByte();
            m_nnEntryData_66 = br.ReadByte();
            m_nnEntryData_67 = br.ReadByte();
            m_nnEntryData_68 = br.ReadByte();
            m_nnEntryData_69 = br.ReadByte();
            m_nnEntryData_70 = br.ReadByte();
            m_nnEntryData_71 = br.ReadByte();
            m_nnEntryData_72 = br.ReadByte();
            m_nnEntryData_73 = br.ReadByte();
            m_nnEntryData_74 = br.ReadByte();
            m_nnEntryData_75 = br.ReadByte();
            m_nnEntryData_76 = br.ReadByte();
            m_nnEntryData_77 = br.ReadByte();
            m_nnEntryData_78 = br.ReadByte();
            m_nnEntryData_79 = br.ReadByte();
            m_nnEntryData_80 = br.ReadByte();
            m_nnEntryData_81 = br.ReadByte();
            m_nnEntryData_82 = br.ReadByte();
            m_nnEntryData_83 = br.ReadByte();
            m_nnEntryData_84 = br.ReadByte();
            m_nnEntryData_85 = br.ReadByte();
            m_nnEntryData_86 = br.ReadByte();
            m_nnEntryData_87 = br.ReadByte();
            m_nnEntryData_88 = br.ReadByte();
            m_nnEntryData_89 = br.ReadByte();
            m_nnEntryData_90 = br.ReadByte();
            m_nnEntryData_91 = br.ReadByte();
            m_nnEntryData_92 = br.ReadByte();
            m_nnEntryData_93 = br.ReadByte();
            m_nnEntryData_94 = br.ReadByte();
            m_nnEntryData_95 = br.ReadByte();
            m_nnEntryData_96 = br.ReadByte();
            m_nnEntryData_97 = br.ReadByte();
            m_nnEntryData_98 = br.ReadByte();
            m_nnEntryData_99 = br.ReadByte();
            m_nnEntryData_100 = br.ReadByte();
            m_nnEntryData_101 = br.ReadByte();
            m_nnEntryData_102 = br.ReadByte();
            m_nnEntryData_103 = br.ReadByte();
            m_nnEntryData_104 = br.ReadByte();
            m_nnEntryData_105 = br.ReadByte();
            m_nnEntryData_106 = br.ReadByte();
            m_nnEntryData_107 = br.ReadByte();
            m_nnEntryData_108 = br.ReadByte();
            m_nnEntryData_109 = br.ReadByte();
            m_nnEntryData_110 = br.ReadByte();
            m_nnEntryData_111 = br.ReadByte();
            m_nnEntryData_112 = br.ReadByte();
            m_nnEntryData_113 = br.ReadByte();
            m_nnEntryData_114 = br.ReadByte();
            m_nnEntryData_115 = br.ReadByte();
            m_nnEntryData_116 = br.ReadByte();
            m_nnEntryData_117 = br.ReadByte();
            m_nnEntryData_118 = br.ReadByte();
            m_nnEntryData_119 = br.ReadByte();
            m_nnEntryData_120 = br.ReadByte();
            m_nnEntryData_121 = br.ReadByte();
            m_nnEntryData_122 = br.ReadByte();
            m_nnEntryData_123 = br.ReadByte();
            m_nnEntryData_124 = br.ReadByte();
            m_nnEntryData_125 = br.ReadByte();
            m_nnEntryData_126 = br.ReadByte();
            m_nnEntryData_127 = br.ReadByte();
            m_nnEntryData_128 = br.ReadByte();
            m_nnEntryData_129 = br.ReadByte();
            m_nnEntryData_130 = br.ReadByte();
            m_nnEntryData_131 = br.ReadByte();
            m_nnEntryData_132 = br.ReadByte();
            m_nnEntryData_133 = br.ReadByte();
            m_nnEntryData_134 = br.ReadByte();
            m_nnEntryData_135 = br.ReadByte();
            m_nnEntryData_136 = br.ReadByte();
            m_nnEntryData_137 = br.ReadByte();
            m_nnEntryData_138 = br.ReadByte();
            m_nnEntryData_139 = br.ReadByte();
            m_nnEntryData_140 = br.ReadByte();
            m_nnEntryData_141 = br.ReadByte();
            m_nnEntryData_142 = br.ReadByte();
            m_nnEntryData_143 = br.ReadByte();
            m_nnEntryData_144 = br.ReadByte();
            m_nnEntryData_145 = br.ReadByte();
            m_nnEntryData_146 = br.ReadByte();
            m_nnEntryData_147 = br.ReadByte();
            m_nnEntryData_148 = br.ReadByte();
            m_nnEntryData_149 = br.ReadByte();
            m_nnEntryData_150 = br.ReadByte();
            m_nnEntryData_151 = br.ReadByte();
            m_nnEntryData_152 = br.ReadByte();
            m_nnEntryData_153 = br.ReadByte();
            m_nnEntryData_154 = br.ReadByte();
            m_nnEntryData_155 = br.ReadByte();
            m_nnEntryData_156 = br.ReadByte();
            m_nnEntryData_157 = br.ReadByte();
            m_nnEntryData_158 = br.ReadByte();
            m_nnEntryData_159 = br.ReadByte();
            m_nnEntryData_160 = br.ReadByte();
            m_nnEntryData_161 = br.ReadByte();
            m_nnEntryData_162 = br.ReadByte();
            m_nnEntryData_163 = br.ReadByte();
            m_nnEntryData_164 = br.ReadByte();
            m_nnEntryData_165 = br.ReadByte();
            m_nnEntryData_166 = br.ReadByte();
            m_nnEntryData_167 = br.ReadByte();
            m_nnEntryData_168 = br.ReadByte();
            m_nnEntryData_169 = br.ReadByte();
            m_nnEntryData_170 = br.ReadByte();
            m_nnEntryData_171 = br.ReadByte();
            m_nnEntryData_172 = br.ReadByte();
            m_nnEntryData_173 = br.ReadByte();
            m_nnEntryData_174 = br.ReadByte();
            m_nnEntryData_175 = br.ReadByte();
            m_nnEntryData_176 = br.ReadByte();
            m_nnEntryData_177 = br.ReadByte();
            m_nnEntryData_178 = br.ReadByte();
            m_nnEntryData_179 = br.ReadByte();
            m_nnEntryData_180 = br.ReadByte();
            m_nnEntryData_181 = br.ReadByte();
            m_nnEntryData_182 = br.ReadByte();
            m_nnEntryData_183 = br.ReadByte();
            m_nnEntryData_184 = br.ReadByte();
            m_nnEntryData_185 = br.ReadByte();
            m_nnEntryData_186 = br.ReadByte();
            m_nnEntryData_187 = br.ReadByte();
            m_nnEntryData_188 = br.ReadByte();
            m_nnEntryData_189 = br.ReadByte();
            m_nnEntryData_190 = br.ReadByte();
            m_nnEntryData_191 = br.ReadByte();
            m_trackInfo = new hkpSerializedTrack1nInfo();
            m_trackInfo.Read(des, br);
            m_endianCheckBuffer_0 = br.ReadByte();
            m_endianCheckBuffer_1 = br.ReadByte();
            m_endianCheckBuffer_2 = br.ReadByte();
            m_endianCheckBuffer_3 = br.ReadByte();
            m_version = br.ReadUInt32();
            br.ReadUInt64();
        }

        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer(bw, m_bodyA);
            s.WriteClassPointer(bw, m_bodyB);
            bw.WriteUInt64(m_bodyAId);
            bw.WriteUInt64(m_bodyBId);
            bw.WriteBoolean(m_useEntityIds);
            bw.WriteSByte((sbyte) m_agentType);
            bw.WriteUInt64(0);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            m_atom.Write(s, bw);
            s.WriteByteArray(bw, m_propertiesStream);
            s.WriteClassArray(bw, m_contactPoints);
            s.WriteByteArray(bw, m_cpIdMgr);
            bw.WriteByte(m_nnEntryData_0);
            bw.WriteByte(m_nnEntryData_1);
            bw.WriteByte(m_nnEntryData_2);
            bw.WriteByte(m_nnEntryData_3);
            bw.WriteByte(m_nnEntryData_4);
            bw.WriteByte(m_nnEntryData_5);
            bw.WriteByte(m_nnEntryData_6);
            bw.WriteByte(m_nnEntryData_7);
            bw.WriteByte(m_nnEntryData_8);
            bw.WriteByte(m_nnEntryData_9);
            bw.WriteByte(m_nnEntryData_10);
            bw.WriteByte(m_nnEntryData_11);
            bw.WriteByte(m_nnEntryData_12);
            bw.WriteByte(m_nnEntryData_13);
            bw.WriteByte(m_nnEntryData_14);
            bw.WriteByte(m_nnEntryData_15);
            bw.WriteByte(m_nnEntryData_16);
            bw.WriteByte(m_nnEntryData_17);
            bw.WriteByte(m_nnEntryData_18);
            bw.WriteByte(m_nnEntryData_19);
            bw.WriteByte(m_nnEntryData_20);
            bw.WriteByte(m_nnEntryData_21);
            bw.WriteByte(m_nnEntryData_22);
            bw.WriteByte(m_nnEntryData_23);
            bw.WriteByte(m_nnEntryData_24);
            bw.WriteByte(m_nnEntryData_25);
            bw.WriteByte(m_nnEntryData_26);
            bw.WriteByte(m_nnEntryData_27);
            bw.WriteByte(m_nnEntryData_28);
            bw.WriteByte(m_nnEntryData_29);
            bw.WriteByte(m_nnEntryData_30);
            bw.WriteByte(m_nnEntryData_31);
            bw.WriteByte(m_nnEntryData_32);
            bw.WriteByte(m_nnEntryData_33);
            bw.WriteByte(m_nnEntryData_34);
            bw.WriteByte(m_nnEntryData_35);
            bw.WriteByte(m_nnEntryData_36);
            bw.WriteByte(m_nnEntryData_37);
            bw.WriteByte(m_nnEntryData_38);
            bw.WriteByte(m_nnEntryData_39);
            bw.WriteByte(m_nnEntryData_40);
            bw.WriteByte(m_nnEntryData_41);
            bw.WriteByte(m_nnEntryData_42);
            bw.WriteByte(m_nnEntryData_43);
            bw.WriteByte(m_nnEntryData_44);
            bw.WriteByte(m_nnEntryData_45);
            bw.WriteByte(m_nnEntryData_46);
            bw.WriteByte(m_nnEntryData_47);
            bw.WriteByte(m_nnEntryData_48);
            bw.WriteByte(m_nnEntryData_49);
            bw.WriteByte(m_nnEntryData_50);
            bw.WriteByte(m_nnEntryData_51);
            bw.WriteByte(m_nnEntryData_52);
            bw.WriteByte(m_nnEntryData_53);
            bw.WriteByte(m_nnEntryData_54);
            bw.WriteByte(m_nnEntryData_55);
            bw.WriteByte(m_nnEntryData_56);
            bw.WriteByte(m_nnEntryData_57);
            bw.WriteByte(m_nnEntryData_58);
            bw.WriteByte(m_nnEntryData_59);
            bw.WriteByte(m_nnEntryData_60);
            bw.WriteByte(m_nnEntryData_61);
            bw.WriteByte(m_nnEntryData_62);
            bw.WriteByte(m_nnEntryData_63);
            bw.WriteByte(m_nnEntryData_64);
            bw.WriteByte(m_nnEntryData_65);
            bw.WriteByte(m_nnEntryData_66);
            bw.WriteByte(m_nnEntryData_67);
            bw.WriteByte(m_nnEntryData_68);
            bw.WriteByte(m_nnEntryData_69);
            bw.WriteByte(m_nnEntryData_70);
            bw.WriteByte(m_nnEntryData_71);
            bw.WriteByte(m_nnEntryData_72);
            bw.WriteByte(m_nnEntryData_73);
            bw.WriteByte(m_nnEntryData_74);
            bw.WriteByte(m_nnEntryData_75);
            bw.WriteByte(m_nnEntryData_76);
            bw.WriteByte(m_nnEntryData_77);
            bw.WriteByte(m_nnEntryData_78);
            bw.WriteByte(m_nnEntryData_79);
            bw.WriteByte(m_nnEntryData_80);
            bw.WriteByte(m_nnEntryData_81);
            bw.WriteByte(m_nnEntryData_82);
            bw.WriteByte(m_nnEntryData_83);
            bw.WriteByte(m_nnEntryData_84);
            bw.WriteByte(m_nnEntryData_85);
            bw.WriteByte(m_nnEntryData_86);
            bw.WriteByte(m_nnEntryData_87);
            bw.WriteByte(m_nnEntryData_88);
            bw.WriteByte(m_nnEntryData_89);
            bw.WriteByte(m_nnEntryData_90);
            bw.WriteByte(m_nnEntryData_91);
            bw.WriteByte(m_nnEntryData_92);
            bw.WriteByte(m_nnEntryData_93);
            bw.WriteByte(m_nnEntryData_94);
            bw.WriteByte(m_nnEntryData_95);
            bw.WriteByte(m_nnEntryData_96);
            bw.WriteByte(m_nnEntryData_97);
            bw.WriteByte(m_nnEntryData_98);
            bw.WriteByte(m_nnEntryData_99);
            bw.WriteByte(m_nnEntryData_100);
            bw.WriteByte(m_nnEntryData_101);
            bw.WriteByte(m_nnEntryData_102);
            bw.WriteByte(m_nnEntryData_103);
            bw.WriteByte(m_nnEntryData_104);
            bw.WriteByte(m_nnEntryData_105);
            bw.WriteByte(m_nnEntryData_106);
            bw.WriteByte(m_nnEntryData_107);
            bw.WriteByte(m_nnEntryData_108);
            bw.WriteByte(m_nnEntryData_109);
            bw.WriteByte(m_nnEntryData_110);
            bw.WriteByte(m_nnEntryData_111);
            bw.WriteByte(m_nnEntryData_112);
            bw.WriteByte(m_nnEntryData_113);
            bw.WriteByte(m_nnEntryData_114);
            bw.WriteByte(m_nnEntryData_115);
            bw.WriteByte(m_nnEntryData_116);
            bw.WriteByte(m_nnEntryData_117);
            bw.WriteByte(m_nnEntryData_118);
            bw.WriteByte(m_nnEntryData_119);
            bw.WriteByte(m_nnEntryData_120);
            bw.WriteByte(m_nnEntryData_121);
            bw.WriteByte(m_nnEntryData_122);
            bw.WriteByte(m_nnEntryData_123);
            bw.WriteByte(m_nnEntryData_124);
            bw.WriteByte(m_nnEntryData_125);
            bw.WriteByte(m_nnEntryData_126);
            bw.WriteByte(m_nnEntryData_127);
            bw.WriteByte(m_nnEntryData_128);
            bw.WriteByte(m_nnEntryData_129);
            bw.WriteByte(m_nnEntryData_130);
            bw.WriteByte(m_nnEntryData_131);
            bw.WriteByte(m_nnEntryData_132);
            bw.WriteByte(m_nnEntryData_133);
            bw.WriteByte(m_nnEntryData_134);
            bw.WriteByte(m_nnEntryData_135);
            bw.WriteByte(m_nnEntryData_136);
            bw.WriteByte(m_nnEntryData_137);
            bw.WriteByte(m_nnEntryData_138);
            bw.WriteByte(m_nnEntryData_139);
            bw.WriteByte(m_nnEntryData_140);
            bw.WriteByte(m_nnEntryData_141);
            bw.WriteByte(m_nnEntryData_142);
            bw.WriteByte(m_nnEntryData_143);
            bw.WriteByte(m_nnEntryData_144);
            bw.WriteByte(m_nnEntryData_145);
            bw.WriteByte(m_nnEntryData_146);
            bw.WriteByte(m_nnEntryData_147);
            bw.WriteByte(m_nnEntryData_148);
            bw.WriteByte(m_nnEntryData_149);
            bw.WriteByte(m_nnEntryData_150);
            bw.WriteByte(m_nnEntryData_151);
            bw.WriteByte(m_nnEntryData_152);
            bw.WriteByte(m_nnEntryData_153);
            bw.WriteByte(m_nnEntryData_154);
            bw.WriteByte(m_nnEntryData_155);
            bw.WriteByte(m_nnEntryData_156);
            bw.WriteByte(m_nnEntryData_157);
            bw.WriteByte(m_nnEntryData_158);
            bw.WriteByte(m_nnEntryData_159);
            bw.WriteByte(m_nnEntryData_160);
            bw.WriteByte(m_nnEntryData_161);
            bw.WriteByte(m_nnEntryData_162);
            bw.WriteByte(m_nnEntryData_163);
            bw.WriteByte(m_nnEntryData_164);
            bw.WriteByte(m_nnEntryData_165);
            bw.WriteByte(m_nnEntryData_166);
            bw.WriteByte(m_nnEntryData_167);
            bw.WriteByte(m_nnEntryData_168);
            bw.WriteByte(m_nnEntryData_169);
            bw.WriteByte(m_nnEntryData_170);
            bw.WriteByte(m_nnEntryData_171);
            bw.WriteByte(m_nnEntryData_172);
            bw.WriteByte(m_nnEntryData_173);
            bw.WriteByte(m_nnEntryData_174);
            bw.WriteByte(m_nnEntryData_175);
            bw.WriteByte(m_nnEntryData_176);
            bw.WriteByte(m_nnEntryData_177);
            bw.WriteByte(m_nnEntryData_178);
            bw.WriteByte(m_nnEntryData_179);
            bw.WriteByte(m_nnEntryData_180);
            bw.WriteByte(m_nnEntryData_181);
            bw.WriteByte(m_nnEntryData_182);
            bw.WriteByte(m_nnEntryData_183);
            bw.WriteByte(m_nnEntryData_184);
            bw.WriteByte(m_nnEntryData_185);
            bw.WriteByte(m_nnEntryData_186);
            bw.WriteByte(m_nnEntryData_187);
            bw.WriteByte(m_nnEntryData_188);
            bw.WriteByte(m_nnEntryData_189);
            bw.WriteByte(m_nnEntryData_190);
            bw.WriteByte(m_nnEntryData_191);
            m_trackInfo.Write(s, bw);
            bw.WriteByte(m_endianCheckBuffer_0);
            bw.WriteByte(m_endianCheckBuffer_1);
            bw.WriteByte(m_endianCheckBuffer_2);
            bw.WriteByte(m_endianCheckBuffer_3);
            bw.WriteUInt32(m_version);
            bw.WriteUInt64(0);
        }
    }
}