// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct IP_ADAPTER_UNICAST_ADDRESS_LH
    {
        [NativeTypeName("_IP_ADAPTER_UNICAST_ADDRESS_LH::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/IPTypes.h:114:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("struct _IP_ADAPTER_UNICAST_ADDRESS_LH *")]
        public IP_ADAPTER_UNICAST_ADDRESS_LH* Next;

        public SOCKET_ADDRESS Address;

        public IP_PREFIX_ORIGIN PrefixOrigin;

        public IP_SUFFIX_ORIGIN SuffixOrigin;

        public IP_DAD_STATE DadState;

        [NativeTypeName("ULONG")]
        public uint ValidLifetime;

        [NativeTypeName("ULONG")]
        public uint PreferredLifetime;

        [NativeTypeName("ULONG")]
        public uint LeaseLifetime;

        [NativeTypeName("UINT8")]
        public byte OnLinkPrefixLength;

        public ref ulong Alignment
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Alignment, 1));
            }
        }

        public ref uint Length
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Length, 1));
            }
        }

        public ref uint Flags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.Flags, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong Alignment;

            [FieldOffset(0)]
            [NativeTypeName("_IP_ADAPTER_UNICAST_ADDRESS_LH::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/IPTypes.h:116:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("ULONG")]
                public uint Length;

                [NativeTypeName("DWORD")]
                public uint Flags;
            }
        }
    }
}
