// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct MIB_IPNETROW_LH
    {
        [NativeTypeName("IF_INDEX")]
        public uint dwIndex;

        [NativeTypeName("DWORD")]
        public uint dwPhysAddrLen;

        [NativeTypeName("UCHAR [8]")]
        public fixed byte bPhysAddr[8];

        [NativeTypeName("DWORD")]
        public uint dwAddr;

        [NativeTypeName("_MIB_IPNETROW_LH::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/ipmib.h:159:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint dwType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwType, 1));
            }
        }

        public ref MIB_IPNET_TYPE Type
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Type, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint dwType;

            [FieldOffset(0)]
            public MIB_IPNET_TYPE Type;
        }
    }
}
