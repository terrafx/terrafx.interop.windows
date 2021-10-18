// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct QCMINFO_IDMAP
    {
        [NativeTypeName("UINT")]
        public uint nMaxIds;

        [NativeTypeName("QCMINFO_IDMAP_PLACEMENT [1]")]
        public _pIdList_e__FixedBuffer pIdList;

        public partial struct _pIdList_e__FixedBuffer
        {
            public QCMINFO_IDMAP_PLACEMENT e0;

            public ref QCMINFO_IDMAP_PLACEMENT this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<QCMINFO_IDMAP_PLACEMENT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
