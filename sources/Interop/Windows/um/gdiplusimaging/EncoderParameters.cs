// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct EncoderParameters
    {
        [NativeTypeName("UINT")]
        public uint Count;

        [NativeTypeName("Gdiplus::EncoderParameter [1]")]
        public _Parameter_e__FixedBuffer Parameter;

        public partial struct _Parameter_e__FixedBuffer
        {
            public EncoderParameter e0;

            public ref EncoderParameter this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<EncoderParameter> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
