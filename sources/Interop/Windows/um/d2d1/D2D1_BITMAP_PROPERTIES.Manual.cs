// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public partial struct D2D1_BITMAP_PROPERTIES
    {
        public static ref readonly D2D1_BITMAP_PROPERTIES DEFAULT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0xC0, 0x42,
                    0x00, 0x00, 0xC0, 0x42,
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<D2D1_BITMAP_PROPERTIES>());
                return ref Unsafe.As<byte, D2D1_BITMAP_PROPERTIES>(ref MemoryMarshal.GetReference(data));
            }
        }

        public D2D1_BITMAP_PROPERTIES([NativeTypeName("const D2D1_PIXEL_FORMAT &")] in D2D1_PIXEL_FORMAT pixelFormat = default, [NativeTypeName("FLOAT")] float dpiX = 96.0f, [NativeTypeName("FLOAT")] float dpiY = 96.0f)
        {
            this = BitmapProperties(pixelFormat, dpiX, dpiY);
        }
    }
}
