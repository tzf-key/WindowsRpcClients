//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\webplatstorageserver.dll
// Interface ID: c59c3bf4-7812-43e9-bc34-d369f1cf8416
// Interface Version: 1.0



namespace rpc_c59c3bf4_7812_43e9_bc34_d369f1cf8416_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Union_1 p0, long p1)
        {
            WriteUnion<Union_1>(p0, p1);
        }
        public void Write_2(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_3(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_4(char[] p0, long p1)
        {
            WriteConformantArray<char>(p0, p1);
        }
        public void Write_5(Struct_0[] p0, long p1)
        {
            WriteConformantStructArray<Struct_0>(p0, p1);
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
        public Union_1 Read_1()
        {
            return ReadStruct<Union_1>();
        }
        public Struct_2 Read_2()
        {
            return ReadStruct<Struct_2>();
        }
        public Struct_3 Read_3()
        {
            return ReadStruct<Struct_3>();
        }
        public char[] Read_4()
        {
            return ReadConformantArray<char>();
        }
        public Struct_0[] Read_5()
        {
            return ReadConformantStructArray<Struct_0>();
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
            m.WriteEnum16(Member0);
            m.WriteInt64(Member8);
            m.Write_1(Member10, Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEnum16();
            Member8 = u.ReadInt64();
            Member10 = u.Read_1();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0;
        public long Member8;
        public Union_1 Member10;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(NtApiDotNet.Ndr.Marshal.NdrEnum16 Member0, long Member8, Union_1 Member10)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
        }
    }
    public struct Union_1 : NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            throw new System.NotImplementedException();
        }
        void NtApiDotNet.Ndr.Marshal.INdrNonEncapsulatedUnion.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m, long l)
        {
            Selector = ((ushort)(l));
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteUInt16(Selector);
            if ((Selector == 0))
            {
                m.WriteEmbeddedPointer<Struct_2>(Arm_0, new System.Action<Struct_2>(m.Write_2));
                goto done;
            }
            throw new System.ArgumentException("No matching union selector when marshaling Union_1");
        done:
            return;
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Selector = u.ReadUInt16();
            if ((Selector == 0))
            {
                Arm_0 = u.ReadEmbeddedPointer<Struct_2>(new System.Func<Struct_2>(u.Read_2), false);
                goto done;
            }
            throw new System.ArgumentException("No matching union selector when marshaling Union_1");
        done:
            return;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 1;
        }
        private ushort Selector;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_2> Arm_0;
        public static Union_1 CreateDefault()
        {
            return new Union_1();
        }
        public Union_1(ushort Selector, System.Nullable<Struct_2> Arm_0)
        {
            this.Selector = Selector;
            this.Arm_0 = Arm_0;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_3(Member0);
            m.WriteInt64(Member10);
            m.WriteInt64(Member18);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_3();
            Member10 = u.ReadInt64();
            Member18 = u.ReadInt64();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 8;
        }
        public Struct_3 Member0;
        public long Member10;
        public long Member18;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(Struct_3 Member0, long Member10, long Member18)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member18 = Member18;
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
            m.WriteInt32(Member0);
            m.WriteEmbeddedPointer<char[], long>(Member8, new System.Action<char[], long>(m.Write_4), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<char[]>(new System.Func<char[]>(u.Read_4), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<char[]> Member8;
        public static Struct_3 CreateDefault()
        {
            return new Struct_3();
        }
        public Struct_3(int Member0, char[] Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("c59c3bf4-7812-43e9-bc34-d369f1cf8416", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int s_WebPlatStorageEvents_CreateChannel(out long p0, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p1, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            _Unmarshal_Helper u = SendReceive(0, m);
            p0 = u.ReadInt64();
            p1 = u.ReadContextHandle();
            p2 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int s_WebPlatStorageEvents_WaitForEvents(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, out int p1, out Struct_0[] p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p1 = u.ReadInt32();
            p2 = u.ReadReferent<Struct_0[]>(new System.Func<Struct_0[]>(u.Read_5), false);
            return u.ReadInt32();
        }
        public void s_WebPlatStorageEvents_CloseChannel(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            p0 = u.ReadContextHandle();
        }
        public void s_WebPlatStorageEvents_Shutdown(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(3, m);
            p0 = u.ReadContextHandle();
        }
    }
    #endregion
}

