// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MIB_IPFORWARDROW
    {
        [NativeTypeName("DWORD")]
        public uint dwForwardDest;

        [NativeTypeName("DWORD")]
        public uint dwForwardMask;

        [NativeTypeName("DWORD")]
        public uint dwForwardPolicy;

        [NativeTypeName("DWORD")]
        public uint dwForwardNextHop;

        [NativeTypeName("IF_INDEX")]
        public uint dwForwardIfIndex;

        [NativeTypeName("_MIB_IPFORWARDROW::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/ipmib.h:112:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("_MIB_IPFORWARDROW::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/ipmib.h:116:5)")]
        public _Anonymous2_e__Union Anonymous2;

        [NativeTypeName("DWORD")]
        public uint dwForwardAge;

        [NativeTypeName("DWORD")]
        public uint dwForwardNextHopAS;

        [NativeTypeName("DWORD")]
        public uint dwForwardMetric1;

        [NativeTypeName("DWORD")]
        public uint dwForwardMetric2;

        [NativeTypeName("DWORD")]
        public uint dwForwardMetric3;

        [NativeTypeName("DWORD")]
        public uint dwForwardMetric4;

        [NativeTypeName("DWORD")]
        public uint dwForwardMetric5;

        public ref uint dwForwardType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.dwForwardType, 1));
            }
        }

        public ref MIB_IPFORWARD_TYPE ForwardType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.ForwardType, 1));
            }
        }

        public ref uint dwForwardProto
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwForwardProto, 1));
            }
        }

        public ref MIB_IPFORWARD_PROTO ForwardProto
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.ForwardProto, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwForwardType;

            [FieldOffset(0)]
            public MIB_IPFORWARD_TYPE ForwardType;
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwForwardProto;

            [FieldOffset(0)]
            public MIB_IPFORWARD_PROTO ForwardProto;
        }
    }
}
