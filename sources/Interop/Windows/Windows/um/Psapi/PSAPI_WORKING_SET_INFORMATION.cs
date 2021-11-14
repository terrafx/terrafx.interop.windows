// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public partial struct PSAPI_WORKING_SET_INFORMATION
    {
        [NativeTypeName("ULONG_PTR")]
        public nuint NumberOfEntries;

        [NativeTypeName("PSAPI_WORKING_SET_BLOCK [1]")]
        public _WorkingSetInfo_e__FixedBuffer WorkingSetInfo;

        public partial struct _WorkingSetInfo_e__FixedBuffer
        {
            public PSAPI_WORKING_SET_BLOCK e0;

            public ref PSAPI_WORKING_SET_BLOCK this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<PSAPI_WORKING_SET_BLOCK> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
