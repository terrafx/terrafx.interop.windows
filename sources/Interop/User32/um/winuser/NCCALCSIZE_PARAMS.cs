// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winuser.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct NCCALCSIZE_PARAMS
    {
        [NativeTypeName("RECT [3]")]
        public _rgrc_e__FixedBuffer rgrc;

        [NativeTypeName("PWINDOWPOS")]
        public WINDOWPOS* lppos;

        public partial struct _rgrc_e__FixedBuffer
        {
            internal RECT e0;
            internal RECT e1;
            internal RECT e2;

            public ref RECT this[int index] => ref AsSpan()[index];

            public Span<RECT> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 3);
        }
    }
}
