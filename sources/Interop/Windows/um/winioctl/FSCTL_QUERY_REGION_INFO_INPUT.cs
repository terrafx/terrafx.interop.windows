// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct FSCTL_QUERY_REGION_INFO_INPUT
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint NumberOfTierIds;

        [NativeTypeName("GUID [1]")]
        public _TierIds_e__FixedBuffer TierIds;

        public partial struct _TierIds_e__FixedBuffer
        {
            public Guid e0;

            public ref Guid this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<Guid> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
