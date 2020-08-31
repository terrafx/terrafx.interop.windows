// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SD_ENUM_SDS_OUTPUT
    {
        [NativeTypeName("DWORDLONG")]
        public ulong NextOffset;

        [NativeTypeName("DWORDLONG")]
        public ulong NumSDEntriesReturned;

        [NativeTypeName("DWORDLONG")]
        public ulong NumSDBytesReturned;

        [NativeTypeName("SD_ENUM_SDS_ENTRY [1]")]
        public _SDEntry_e__FixedBuffer SDEntry;

        public partial struct _SDEntry_e__FixedBuffer
        {
            public SD_ENUM_SDS_ENTRY e0;

            public ref SD_ENUM_SDS_ENTRY this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<SD_ENUM_SDS_ENTRY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
