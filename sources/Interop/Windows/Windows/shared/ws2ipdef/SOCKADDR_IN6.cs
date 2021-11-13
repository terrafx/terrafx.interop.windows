// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct SOCKADDR_IN6
    {
        [NativeTypeName("ADDRESS_FAMILY")]
        public ushort sin6_family;

        public ushort sin6_port;

        [NativeTypeName("ULONG")]
        public uint sin6_flowinfo;

        public IN6_ADDR sin6_addr;

        [NativeTypeName("sockaddr_in6::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/ws2ipdef.h:196:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint sin6_scope_id
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.sin6_scope_id, 1));
            }
        }

        public ref SCOPE_ID sin6_scope_struct
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.sin6_scope_struct, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint sin6_scope_id;

            [FieldOffset(0)]
            public SCOPE_ID sin6_scope_struct;
        }
    }
}
