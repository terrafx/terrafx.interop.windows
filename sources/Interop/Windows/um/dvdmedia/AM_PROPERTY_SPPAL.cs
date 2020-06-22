// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct AM_PROPERTY_SPPAL
    {
        [NativeTypeName("AM_DVD_YUV [16]")]
        public _sppal_e__FixedBuffer sppal;

        public partial struct _sppal_e__FixedBuffer
        {
            internal AM_DVD_YUV e0;
            internal AM_DVD_YUV e1;
            internal AM_DVD_YUV e2;
            internal AM_DVD_YUV e3;
            internal AM_DVD_YUV e4;
            internal AM_DVD_YUV e5;
            internal AM_DVD_YUV e6;
            internal AM_DVD_YUV e7;
            internal AM_DVD_YUV e8;
            internal AM_DVD_YUV e9;
            internal AM_DVD_YUV e10;
            internal AM_DVD_YUV e11;
            internal AM_DVD_YUV e12;
            internal AM_DVD_YUV e13;
            internal AM_DVD_YUV e14;
            internal AM_DVD_YUV e15;

            public ref AM_DVD_YUV this[int index] => ref AsSpan()[index];

            public Span<AM_DVD_YUV> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
