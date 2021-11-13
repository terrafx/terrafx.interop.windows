// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct SOCKET_ADDRESS_LIST
    {
        public int iAddressCount;

        [NativeTypeName("SOCKET_ADDRESS [1]")]
        public _Address_e__FixedBuffer Address;

        public partial struct _Address_e__FixedBuffer
        {
            public SOCKET_ADDRESS e0;

            public ref SOCKET_ADDRESS this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<SOCKET_ADDRESS> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
