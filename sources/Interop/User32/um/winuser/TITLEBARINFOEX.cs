// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\winuser.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct TITLEBARINFOEX
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public RECT rcTitleBar;

        [NativeTypeName("DWORD [6]")]
        public fixed uint rgstate[6];

        [NativeTypeName("RECT [6]")]
        public _rgrect_e__FixedBuffer rgrect;

        public partial struct _rgrect_e__FixedBuffer
        {
            internal RECT e0;
            internal RECT e1;
            internal RECT e2;
            internal RECT e3;
            internal RECT e4;
            internal RECT e5;

            public ref RECT this[int index] => ref AsSpan()[index];

            public Span<RECT> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 6);
        }
    }
}
