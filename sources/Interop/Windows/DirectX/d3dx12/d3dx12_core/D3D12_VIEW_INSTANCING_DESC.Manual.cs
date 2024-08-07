// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D12_VIEW_INSTANCING_DESC
{
    public static ref readonly D3D12_VIEW_INSTANCING_DESC DEFAULT
    {
        get
        {
            ReadOnlySpan<byte> data;

            if (Environment.Is64BitProcess)
            {
                data = [
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00
                ];
            }
            else
            {
                data = [
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00
                ];
            }

            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_VIEW_INSTANCING_DESC>());
            return ref Unsafe.As<byte, D3D12_VIEW_INSTANCING_DESC>(ref MemoryMarshal.GetReference(data));
        }
    }
}
