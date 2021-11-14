// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.DirectX.D2D1_COLOR_SPACE;
using static TerraFX.Interop.DirectX.D2D1_PRINT_FONT_SUBSET_MODE;
using static TerraFX.Interop.DirectX.DirectX;

namespace TerraFX.Interop.DirectX
{
    public partial struct D2D1_PRINT_CONTROL_PROPERTIES
    {
        public static ref readonly D2D1_PRINT_CONTROL_PROPERTIES DEFAULT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x16, 0x43,
                    0x01, 0x00, 0x00, 0x00
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<D2D1_PRINT_CONTROL_PROPERTIES>());
                return ref Unsafe.As<byte, D2D1_PRINT_CONTROL_PROPERTIES>(ref MemoryMarshal.GetReference(data));
            }
        }

        public D2D1_PRINT_CONTROL_PROPERTIES(D2D1_PRINT_FONT_SUBSET_MODE fontSubsetMode = D2D1_PRINT_FONT_SUBSET_MODE_DEFAULT, float rasterDpi = 150.0f, D2D1_COLOR_SPACE colorSpace = D2D1_COLOR_SPACE_SRGB)
        {
            this = PrintControlProperties(fontSubsetMode, rasterDpi, colorSpace);
        }
    }
}
