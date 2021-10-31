// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct WICRawToneCurve
    {
        public uint cPoints;

        [NativeTypeName("WICRawToneCurvePoint [1]")]
        public _aPoints_e__FixedBuffer aPoints;

        public partial struct _aPoints_e__FixedBuffer
        {
            public WICRawToneCurvePoint e0;

            public ref WICRawToneCurvePoint this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan(int.MaxValue)[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<WICRawToneCurvePoint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
