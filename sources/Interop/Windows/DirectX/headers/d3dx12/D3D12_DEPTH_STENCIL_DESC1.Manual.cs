// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.DirectX;

public partial struct D3D12_DEPTH_STENCIL_DESC1
{
    public D3D12_DEPTH_STENCIL_DESC1([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] in D3D12_DEPTH_STENCIL_DESC o)
    {
        DepthEnable = o.DepthEnable;
        DepthWriteMask = o.DepthWriteMask;
        DepthFunc = o.DepthFunc;
        StencilEnable = o.StencilEnable;
        StencilReadMask = o.StencilReadMask;
        StencilWriteMask = o.StencilWriteMask;
        FrontFace.StencilFailOp = o.FrontFace.StencilFailOp;
        FrontFace.StencilDepthFailOp = o.FrontFace.StencilDepthFailOp;
        FrontFace.StencilPassOp = o.FrontFace.StencilPassOp;
        FrontFace.StencilFunc = o.FrontFace.StencilFunc;
        BackFace.StencilFailOp = o.BackFace.StencilFailOp;
        BackFace.StencilDepthFailOp = o.BackFace.StencilDepthFailOp;
        BackFace.StencilPassOp = o.BackFace.StencilPassOp;
        BackFace.StencilFunc = o.BackFace.StencilFunc;
        DepthBoundsTestEnable = FALSE;
    }

    public static ref readonly D3D12_DEPTH_STENCIL_DESC1 DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x02, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0xFF, 0xFF, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x08, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x08, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_DEPTH_STENCIL_DESC1>());
            return ref Unsafe.As<byte, D3D12_DEPTH_STENCIL_DESC1>(ref MemoryMarshal.GetReference(data));
        }
    }

    public D3D12_DEPTH_STENCIL_DESC1(BOOL depthEnable, D3D12_DEPTH_WRITE_MASK depthWriteMask, D3D12_COMPARISON_FUNC depthFunc, BOOL stencilEnable, [NativeTypeName("UINT8")] byte stencilReadMask, [NativeTypeName("UINT8")] byte stencilWriteMask, D3D12_STENCIL_OP frontStencilFailOp, D3D12_STENCIL_OP frontStencilDepthFailOp, D3D12_STENCIL_OP frontStencilPassOp, D3D12_COMPARISON_FUNC frontStencilFunc, D3D12_STENCIL_OP backStencilFailOp, D3D12_STENCIL_OP backStencilDepthFailOp, D3D12_STENCIL_OP backStencilPassOp, D3D12_COMPARISON_FUNC backStencilFunc, BOOL depthBoundsTestEnable)
    {
        DepthEnable = depthEnable;
        DepthWriteMask = depthWriteMask;
        DepthFunc = depthFunc;
        StencilEnable = stencilEnable;
        StencilReadMask = stencilReadMask;
        StencilWriteMask = stencilWriteMask;
        FrontFace.StencilFailOp = frontStencilFailOp;
        FrontFace.StencilDepthFailOp = frontStencilDepthFailOp;
        FrontFace.StencilPassOp = frontStencilPassOp;
        FrontFace.StencilFunc = frontStencilFunc;
        BackFace.StencilFailOp = backStencilFailOp;
        BackFace.StencilDepthFailOp = backStencilDepthFailOp;
        BackFace.StencilPassOp = backStencilPassOp;
        BackFace.StencilFunc = backStencilFunc;
        DepthBoundsTestEnable = depthBoundsTestEnable;
    }

    public static implicit operator D3D12_DEPTH_STENCIL_DESC1(D3D12_DEPTH_STENCIL_DESC value)
    {
        D3D12_DEPTH_STENCIL_DESC D;
        D.DepthEnable = value.DepthEnable;
        D.DepthWriteMask = value.DepthWriteMask;
        D.DepthFunc = value.DepthFunc;
        D.StencilEnable = value.StencilEnable;
        D.StencilReadMask = value.StencilReadMask;
        D.StencilWriteMask = value.StencilWriteMask;
        D.FrontFace.StencilFailOp = value.FrontFace.StencilFailOp;
        D.FrontFace.StencilDepthFailOp = value.FrontFace.StencilDepthFailOp;
        D.FrontFace.StencilPassOp = value.FrontFace.StencilPassOp;
        D.FrontFace.StencilFunc = value.FrontFace.StencilFunc;
        D.BackFace.StencilFailOp = value.BackFace.StencilFailOp;
        D.BackFace.StencilDepthFailOp = value.BackFace.StencilDepthFailOp;
        D.BackFace.StencilPassOp = value.BackFace.StencilPassOp;
        D.BackFace.StencilFunc = value.BackFace.StencilFunc;
        return D;
    }
}
