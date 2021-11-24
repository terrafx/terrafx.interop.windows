// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2ipdef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct IP_MSFILTER
{
    public IN_ADDR imsf_multiaddr;

    public IN_ADDR imsf_interface;

    public MULTICAST_MODE_TYPE imsf_fmode;

    [NativeTypeName("ULONG")]
    public uint imsf_numsrc;

    [NativeTypeName("IN_ADDR [1]")]
    public _imsf_slist_e__FixedBuffer imsf_slist;

    public partial struct _imsf_slist_e__FixedBuffer
    {
        public IN_ADDR e0;

        public ref IN_ADDR this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<IN_ADDR> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
