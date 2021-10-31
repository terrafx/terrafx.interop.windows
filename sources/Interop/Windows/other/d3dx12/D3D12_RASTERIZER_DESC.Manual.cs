// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D12_RASTERIZER_DESC
    {
        public static ref readonly D3D12_RASTERIZER_DESC DEFAULT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x03, 0x00, 0x00, 0x00,
                    0x03, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x01, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00,
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_RASTERIZER_DESC>());
                return ref Unsafe.As<byte, D3D12_RASTERIZER_DESC>(ref MemoryMarshal.GetReference(data));
            }
        }

        public D3D12_RASTERIZER_DESC(D3D12_FILL_MODE fillMode, D3D12_CULL_MODE cullMode, BOOL frontCounterClockwise, [NativeTypeName("INT")] int depthBias, [NativeTypeName("FLOAT")] float depthBiasClamp, [NativeTypeName("FLOAT")] float slopeScaledDepthBias, BOOL depthClipEnable, BOOL multisampleEnable, BOOL antialiasedLineEnable, [NativeTypeName("UINT")] uint forcedSampleCount, D3D12_CONSERVATIVE_RASTERIZATION_MODE conservativeRaster)
        {
            FillMode = fillMode;
            CullMode = cullMode;
            FrontCounterClockwise = frontCounterClockwise;
            DepthBias = depthBias;
            DepthBiasClamp = depthBiasClamp;
            SlopeScaledDepthBias = slopeScaledDepthBias;
            DepthClipEnable = depthClipEnable;
            MultisampleEnable = multisampleEnable;
            AntialiasedLineEnable = antialiasedLineEnable;
            ForcedSampleCount = forcedSampleCount;
            ConservativeRaster = conservativeRaster;
        }
    }
}
