//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\wevtsvc.dll
// Interface ID: 82273fdc-e32a-18c3-3f78-827929dc23ea
// Interface Version: 0.0



namespace rpc_82273fdc_e32a_18c3_3f78_827929dc23ea_0_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_2(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_3(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_4(Struct_4 p0)
        {
            WriteStruct<Struct_4>(p0);
        }
        public void Write_5(short[] p0, long p1, long p2)
        {
            WriteConformantVaryingArray<short>(p0, p1, p2);
        }
        public void Write_6(int[] p0, long p1)
        {
            WriteConformantArray<int>(p0, p1);
        }
        public void Write_7(sbyte[] p0)
        {
            WriteFixedPrimitiveArray<sbyte>(p0, 6);
        }
        public void Write_8(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_9(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_10(Struct_0[] p0, long p1)
        {
            WriteConformantStructArray<Struct_0>(p0, p1);
        }
        public void Write_11(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_12(Struct_4[] p0, long p1)
        {
            WriteConformantStructArray<Struct_4>(p0, p1);
        }
        public void Write_13(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_14(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_15(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_16(Struct_0[] p0, long p1)
        {
            WriteConformantStructArray<Struct_0>(p0, p1);
        }
        public void Write_17(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_18(Struct_0[] p0, long p1)
        {
            WriteConformantStructArray<Struct_0>(p0, p1);
        }
        public void Write_19(Struct_4[] p0, long p1)
        {
            WriteConformantStructArray<Struct_4>(p0, p1);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public Struct_1 Read_1()
        {
            return ReadStruct<Struct_1>();
        }
        public Struct_2 Read_2()
        {
            return ReadStruct<Struct_2>();
        }
        public Struct_3 Read_3()
        {
            return ReadStruct<Struct_3>();
        }
        public Struct_4 Read_4()
        {
            return ReadStruct<Struct_4>();
        }
        public short[] Read_5()
        {
            return ReadConformantVaryingArray<short>();
        }
        public int[] Read_6()
        {
            return ReadConformantArray<int>();
        }
        public sbyte[] Read_7()
        {
            return ReadFixedPrimitiveArray<sbyte>(6);
        }
        public sbyte[] Read_8()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_9()
        {
            return ReadConformantArray<sbyte>();
        }
        public Struct_0[] Read_10()
        {
            return ReadConformantStructArray<Struct_0>();
        }
        public sbyte[] Read_11()
        {
            return ReadConformantArray<sbyte>();
        }
        public Struct_4[] Read_12()
        {
            return ReadConformantStructArray<Struct_4>();
        }
        public sbyte[] Read_13()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_14()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_15()
        {
            return ReadConformantArray<sbyte>();
        }
        public Struct_0[] Read_16()
        {
            return ReadConformantStructArray<Struct_0>();
        }
        public sbyte[] Read_17()
        {
            return ReadConformantArray<sbyte>();
        }
        public Struct_0[] Read_18()
        {
            return ReadConformantStructArray<Struct_0>();
        }
        public Struct_4[] Read_19()
        {
            return ReadConformantStructArray<Struct_4>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt16(Member0);
            m.WriteInt16(Member2);
            m.WriteEmbeddedPointer<short[], long, long>(Member8, new System.Action<short[], long, long>(m.Write_5), (Member2 / 2), (Member0 / 2));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt16();
            Member2 = u.ReadInt16();
            Member8 = u.ReadEmbeddedPointer<short[]>(new System.Func<short[]>(u.Read_5), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public short Member0;
        public short Member2;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<short[]> Member8;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(short Member0, short Member2, short[] Member8)
        {
            this.Member0 = Member0;
            this.Member2 = Member2;
            this.Member8 = Member8;
        }
    }
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(int Member0, int Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteSByte(Member0);
            m.WriteSByte(Member1);
            m.Write_3(Member2);
            m.Write_6(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member8, "Member8"), Member1);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadSByte();
            Member1 = u.ReadSByte();
            Member2 = u.Read_3();
            Member8 = u.Read_6();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public sbyte Member0;
        public sbyte Member1;
        public Struct_3 Member2;
        public int[] Member8;
        public static Struct_2 CreateDefault()
        {
            Struct_2 ret = new Struct_2();
            ret.Member8 = new int[0];
            return ret;
        }
        public Struct_2(sbyte Member0, sbyte Member1, Struct_3 Member2, int[] Member8)
        {
            this.Member0 = Member0;
            this.Member1 = Member1;
            this.Member2 = Member2;
            this.Member8 = Member8;
        }
    }
    public struct Struct_3 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_7(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_7();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        public sbyte[] Member0;
        public static Struct_3 CreateDefault()
        {
            Struct_3 ret = new Struct_3();
            ret.Member0 = new sbyte[6];
            return ret;
        }
        public Struct_3(sbyte[] Member0)
        {
            this.Member0 = Member0;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt16(Member0);
            m.WriteInt16(Member2);
            m.WriteEmbeddedPointer<sbyte[], long>(Member8, new System.Action<sbyte[], long>(m.Write_8), Member2);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt16();
            Member2 = u.ReadInt16();
            Member8 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_8), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public short Member0;
        public short Member2;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member8;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(short Member0, short Member2, sbyte[] Member8)
        {
            this.Member0 = Member0;
            this.Member2 = Member2;
            this.Member8 = Member8;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("82273fdc-e32a-18c3-3f78-827929dc23ea", 0, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int ElfrClearELFW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Nullable<Struct_0> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<Struct_0>(m.Write_0));
            _Unmarshal_Helper u = SendReceive(0, m);
            return u.ReadInt32();
        }
        public int ElfrBackupELFW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_0 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_0(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
        public int ElfrCloseEL(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int ElfrDeregisterEventSource(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int ElfrNumberOfRecords(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(4, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int ElfrOldestRecord(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(5, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int ElfrChangeNotify(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_1 p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_1(p1);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(6, m);
            return u.ReadInt32();
        }
        public int ElfrOpenELW(System.Nullable<char> p0, Struct_0 p1, Struct_0 p2, int p3, int p4, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<char>(m.WriteChar));
            m.Write_0(p1);
            m.Write_0(p2);
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(7, m);
            p5 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int ElfrRegisterEventSourceW(System.Nullable<char> p0, Struct_0 p1, Struct_0 p2, int p3, int p4, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<char>(m.WriteChar));
            m.Write_0(p1);
            m.Write_0(p2);
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(8, m);
            p5 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int ElfrOpenBELW(System.Nullable<char> p0, Struct_0 p1, int p2, int p3, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<char>(m.WriteChar));
            m.Write_0(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(9, m);
            p4 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int ElfrReadELW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, int p3, out sbyte[] p4, out int p5, out int p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(10, m);
            p4 = u.Read_9();
            p5 = u.ReadInt32();
            p6 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int ElfrReportEventW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, short p2, short p3, int p4, short p5, int p6, Struct_0 p7, System.Nullable<Struct_2> p8, Struct_0[] p9, sbyte[] p10, short p11, ref System.Nullable<int> p12, ref System.Nullable<int> p13)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt16(p2);
            m.WriteInt16(p3);
            m.WriteInt32(p4);
            m.WriteInt16(p5);
            m.WriteInt32(p6);
            m.Write_0(p7);
            m.WriteReferent(p8, new System.Action<Struct_2>(m.Write_2));
            m.WriteReferent(p9, new System.Action<Struct_0[], long>(m.Write_10), p5);
            m.WriteReferent(p10, new System.Action<sbyte[], long>(m.Write_11), p6);
            m.WriteInt16(p11);
            m.WriteReferent(p12, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p13, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(11, m);
            p12 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p13 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
        public int ElfrClearELFA(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, System.Nullable<Struct_4> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteReferent(p1, new System.Action<Struct_4>(m.Write_4));
            _Unmarshal_Helper u = SendReceive(12, m);
            return u.ReadInt32();
        }
        public int ElfrBackupELFA(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_4 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_4(p1);
            _Unmarshal_Helper u = SendReceive(13, m);
            return u.ReadInt32();
        }
        public int ElfrOpenELA(System.Nullable<sbyte> p0, Struct_4 p1, Struct_4 p2, int p3, int p4, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<sbyte>(m.WriteSByte));
            m.Write_4(p1);
            m.Write_4(p2);
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(14, m);
            p5 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int ElfrRegisterEventSourceA(System.Nullable<sbyte> p0, Struct_4 p1, Struct_4 p2, int p3, int p4, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<sbyte>(m.WriteSByte));
            m.Write_4(p1);
            m.Write_4(p2);
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            _Unmarshal_Helper u = SendReceive(15, m);
            p5 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int ElfrOpenBELA(System.Nullable<sbyte> p0, Struct_4 p1, int p2, int p3, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<sbyte>(m.WriteSByte));
            m.Write_4(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(16, m);
            p4 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int ElfrReadELA(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, int p2, int p3, out sbyte[] p4, out int p5, out int p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p2);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(17, m);
            p4 = u.Read_9();
            p5 = u.ReadInt32();
            p6 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int ElfrReportEventA(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, short p2, short p3, int p4, short p5, int p6, Struct_4 p7, System.Nullable<Struct_2> p8, Struct_4[] p9, sbyte[] p10, short p11, ref System.Nullable<int> p12, ref System.Nullable<int> p13)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt16(p2);
            m.WriteInt16(p3);
            m.WriteInt32(p4);
            m.WriteInt16(p5);
            m.WriteInt32(p6);
            m.Write_4(p7);
            m.WriteReferent(p8, new System.Action<Struct_2>(m.Write_2));
            m.WriteReferent(p9, new System.Action<Struct_4[], long>(m.Write_12), p5);
            m.WriteReferent(p10, new System.Action<sbyte[], long>(m.Write_11), p6);
            m.WriteInt16(p11);
            m.WriteReferent(p12, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p13, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(18, m);
            p12 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p13 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
        public int ElfrRegisterClusterSvc(System.Nullable<char> p0, out int p1, out sbyte[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<char>(m.WriteChar));
            _Unmarshal_Helper u = SendReceive(19, m);
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<sbyte[]>(new System.Func<sbyte[]>(u.Read_13), false);
            return u.ReadInt32();
        }
        public int ElfrDeregisterClusterSvc(System.Nullable<char> p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<char>(m.WriteChar));
            _Unmarshal_Helper u = SendReceive(20, m);
            return u.ReadInt32();
        }
        public int ElfrWriteClusterEvents(System.Nullable<char> p0, int p1, sbyte[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<char>(m.WriteChar));
            m.WriteInt32(p1);
            m.Write_14(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"), p1);
            _Unmarshal_Helper u = SendReceive(21, m);
            return u.ReadInt32();
        }
        public int ElfrGetLogInformation(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, out sbyte[] p2, int p3, out int p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(22, m);
            p2 = u.Read_15();
            p4 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int ElfrFlushEL(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(23, m);
            return u.ReadInt32();
        }
        public int ElfrReportEventAndSourceW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, int p1, short p2, short p3, int p4, Struct_0 p5, short p6, int p7, Struct_0 p8, System.Nullable<Struct_2> p9, Struct_0[] p10, sbyte[] p11, short p12, ref System.Nullable<int> p13, ref System.Nullable<int> p14)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.WriteInt32(p1);
            m.WriteInt16(p2);
            m.WriteInt16(p3);
            m.WriteInt32(p4);
            m.Write_0(p5);
            m.WriteInt16(p6);
            m.WriteInt32(p7);
            m.Write_0(p8);
            m.WriteReferent(p9, new System.Action<Struct_2>(m.Write_2));
            m.WriteReferent(p10, new System.Action<Struct_0[], long>(m.Write_16), p6);
            m.WriteReferent(p11, new System.Action<sbyte[], long>(m.Write_17), p7);
            m.WriteInt16(p12);
            m.WriteReferent(p13, new System.Action<int>(m.WriteInt32));
            m.WriteReferent(p14, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(24, m);
            p13 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            p14 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
        public int ElfrReportEventExW(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_1 p1, short p2, short p3, int p4, short p5, int p6, Struct_0 p7, System.Nullable<Struct_2> p8, Struct_0[] p9, sbyte[] p10, short p11, ref System.Nullable<int> p12)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_1(p1);
            m.WriteInt16(p2);
            m.WriteInt16(p3);
            m.WriteInt32(p4);
            m.WriteInt16(p5);
            m.WriteInt32(p6);
            m.Write_0(p7);
            m.WriteReferent(p8, new System.Action<Struct_2>(m.Write_2));
            m.WriteReferent(p9, new System.Action<Struct_0[], long>(m.Write_18), p5);
            m.WriteReferent(p10, new System.Action<sbyte[], long>(m.Write_11), p6);
            m.WriteInt16(p11);
            m.WriteReferent(p12, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(25, m);
            p12 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
        public int ElfrReportEventExA(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_1 p1, short p2, short p3, int p4, short p5, int p6, Struct_4 p7, System.Nullable<Struct_2> p8, Struct_4[] p9, sbyte[] p10, short p11, ref System.Nullable<int> p12)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_1(p1);
            m.WriteInt16(p2);
            m.WriteInt16(p3);
            m.WriteInt32(p4);
            m.WriteInt16(p5);
            m.WriteInt32(p6);
            m.Write_4(p7);
            m.WriteReferent(p8, new System.Action<Struct_2>(m.Write_2));
            m.WriteReferent(p9, new System.Action<Struct_4[], long>(m.Write_19), p5);
            m.WriteReferent(p10, new System.Action<sbyte[], long>(m.Write_11), p6);
            m.WriteInt16(p11);
            m.WriteReferent(p12, new System.Action<int>(m.WriteInt32));
            _Unmarshal_Helper u = SendReceive(26, m);
            p12 = u.ReadReferentValue<int>(new System.Func<int>(u.ReadInt32), false);
            return u.ReadInt32();
        }
    }
    #endregion
}
