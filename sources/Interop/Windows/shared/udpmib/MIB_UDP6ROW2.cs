// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/udpmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct MIB_UDP6ROW2
    {
        [NativeTypeName("UCHAR [16]")]
        public fixed byte ucLocalAddr[16];

        [NativeTypeName("DWORD")]
        public uint dwLocalScopeId;

        [NativeTypeName("DWORD")]
        public uint dwLocalPort;

        [NativeTypeName("DWORD")]
        public uint dwOwningPid;

        public LARGE_INTEGER liCreateTimestamp;

        [NativeTypeName("_MIB_UDP6ROW2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/udpmib.h:177:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ULONGLONG [16]")]
        public fixed ulong OwningModuleInfo[16];

        [NativeTypeName("UCHAR [16]")]
        public fixed byte ucRemoteAddr[16];

        [NativeTypeName("DWORD")]
        public uint dwRemoteScopeId;

        [NativeTypeName("DWORD")]
        public uint dwRemotePort;

        public int SpecificPortBind
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return Anonymous.Anonymous.SpecificPortBind;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Anonymous.SpecificPortBind = value;
            }
        }

        public ref int dwFlags
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dwFlags, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("_MIB_UDP6ROW2::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/udpmib.h:178:9)")]
            public _Anonymous_e__Struct Anonymous;

            [FieldOffset(0)]
            public int dwFlags;

            public partial struct _Anonymous_e__Struct
            {
                public int _bitfield;

                [NativeTypeName("int : 1")]
                public int SpecificPortBind
                {
                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    get
                    {
                        return _bitfield & 0x1;
                    }

                    [MethodImpl(MethodImplOptions.AggressiveInlining)]
                    set
                    {
                        _bitfield = (_bitfield & ~0x1) | (value & 0x1);
                    }
                }
            }
        }
    }
}
