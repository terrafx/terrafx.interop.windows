// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct TRANSMSGLIST
    {
        public uint uMsgCount;

        [NativeTypeName("TRANSMSG [1]")]
        public _TransMsg_e__FixedBuffer TransMsg;

        public partial struct _TransMsg_e__FixedBuffer
        {
            public TRANSMSG e0;

            public ref TRANSMSG this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<TRANSMSG> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
