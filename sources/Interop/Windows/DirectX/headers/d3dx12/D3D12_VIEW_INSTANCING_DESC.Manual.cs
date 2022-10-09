// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

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
                data = new byte[] {
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00
                };
            }
            else
            {
                data = new byte[] {
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00
                };
            }

            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_VIEW_INSTANCING_DESC>());
            return ref Unsafe.As<byte, D3D12_VIEW_INSTANCING_DESC>(ref MemoryMarshal.GetReference(data));
        }
    }

    public D3D12_VIEW_INSTANCING_DESC(uint InViewInstanceCount, [NativeTypeName("const D3D12_VIEW_INSTANCE_LOCATION *")] D3D12_VIEW_INSTANCE_LOCATION* InViewInstanceLocations, D3D12_VIEW_INSTANCING_FLAGS InFlags)
    {
        ViewInstanceCount = InViewInstanceCount;
        pViewInstanceLocations = InViewInstanceLocations;
        Flags = InFlags;
    }
}
