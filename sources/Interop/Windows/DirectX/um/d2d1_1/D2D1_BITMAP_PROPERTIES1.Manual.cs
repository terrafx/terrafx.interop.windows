// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.DirectX.D2D1_BITMAP_OPTIONS;
using static TerraFX.Interop.DirectX.DirectX;

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D2D1_BITMAP_PROPERTIES1
{
    public static ref readonly D2D1_BITMAP_PROPERTIES1 DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data;

            if (Environment.Is64BitProcess)
            {
                data = [
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0xC0, 0x42,
                    0x00, 0x00, 0xC0, 0x42,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                ];
            }
            else
            {
                data = [
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0xC0, 0x42,
                    0x00, 0x00, 0xC0, 0x42,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00
                ];
            }

            Debug.Assert(data.Length == Unsafe.SizeOf<D2D1_BITMAP_PROPERTIES1>());
            return ref Unsafe.As<byte, D2D1_BITMAP_PROPERTIES1>(ref MemoryMarshal.GetReference(data));
        }
    }

    public D2D1_BITMAP_PROPERTIES1(D2D1_BITMAP_OPTIONS bitmapOptions = D2D1_BITMAP_OPTIONS_NONE, [NativeTypeName("const D2D1_PIXEL_FORMAT")] D2D1_PIXEL_FORMAT pixelFormat = default, float dpiX = 96.0f, float dpiY = 96.0f, ID2D1ColorContext* colorContext = null)
    {
        this = BitmapProperties1(bitmapOptions, pixelFormat, dpiX, dpiY, colorContext);
    }
}
