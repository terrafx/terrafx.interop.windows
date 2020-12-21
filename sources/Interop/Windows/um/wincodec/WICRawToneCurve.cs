// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct WICRawToneCurve
    {
        [NativeTypeName("UINT")]
        public uint cPoints;

        [NativeTypeName("WICRawToneCurvePoint [1]")]
        public _aPoints_e__FixedBuffer aPoints;

        public partial struct _aPoints_e__FixedBuffer
        {
            public WICRawToneCurvePoint e0;

            public unsafe ref WICRawToneCurvePoint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe Span<WICRawToneCurvePoint> AsSpan(int length)
            {
#if !NETSTANDARD2_0
                return MemoryMarshal.CreateSpan(ref e0, length);
#else
                return new Span<WICRawToneCurvePoint>((WICRawToneCurvePoint*)Unsafe.AsPointer(ref this), length);
#endif
            }
        }
    }
}
