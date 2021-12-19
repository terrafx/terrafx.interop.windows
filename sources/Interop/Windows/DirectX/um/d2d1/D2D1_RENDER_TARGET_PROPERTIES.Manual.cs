// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.DirectX.D2D1_FEATURE_LEVEL;
using static TerraFX.Interop.DirectX.D2D1_RENDER_TARGET_TYPE;
using static TerraFX.Interop.DirectX.D2D1_RENDER_TARGET_USAGE;
using static TerraFX.Interop.DirectX.DirectX;

namespace TerraFX.Interop.DirectX;

public partial struct D2D1_RENDER_TARGET_PROPERTIES
{
    public static ref readonly D2D1_RENDER_TARGET_PROPERTIES DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                };

            Debug.Assert(data.Length == Unsafe.SizeOf<D2D1_RENDER_TARGET_PROPERTIES>());
            return ref Unsafe.As<byte, D2D1_RENDER_TARGET_PROPERTIES>(ref MemoryMarshal.GetReference(data));
        }
    }

    public D2D1_RENDER_TARGET_PROPERTIES(D2D1_RENDER_TARGET_TYPE type = D2D1_RENDER_TARGET_TYPE_DEFAULT, [NativeTypeName("const D2D1_PIXEL_FORMAT &")] in D2D1_PIXEL_FORMAT pixelFormat = default, float dpiX = 0.0f, float dpiY = 0.0f, D2D1_RENDER_TARGET_USAGE usage = D2D1_RENDER_TARGET_USAGE_NONE, D2D1_FEATURE_LEVEL minLevel = D2D1_FEATURE_LEVEL_DEFAULT)
    {
        this = RenderTargetProperties(type, pixelFormat, dpiX, dpiY, usage, minLevel);
    }
}
