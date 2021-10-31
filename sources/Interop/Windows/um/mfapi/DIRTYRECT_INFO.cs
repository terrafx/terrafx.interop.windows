// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DIRTYRECT_INFO
    {
        public uint FrameNumber;

        public uint NumDirtyRects;

        [NativeTypeName("RECT [1]")]
        public _DirtyRects_e__FixedBuffer DirtyRects;

        public partial struct _DirtyRects_e__FixedBuffer
        {
            public RECT e0;

            public ref RECT this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<RECT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
