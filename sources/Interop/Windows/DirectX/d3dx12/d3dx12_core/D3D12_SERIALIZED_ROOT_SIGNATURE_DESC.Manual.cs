// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

public partial struct D3D12_SERIALIZED_ROOT_SIGNATURE_DESC
{
    public static ref readonly D3D12_SERIALIZED_ROOT_SIGNATURE_DESC DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = [
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
            ];

            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_SERIALIZED_ROOT_SIGNATURE_DESC>());
            return ref Unsafe.As<byte, D3D12_SERIALIZED_ROOT_SIGNATURE_DESC>(ref MemoryMarshal.GetReference(data));
        }
    }
}
