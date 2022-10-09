// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D12_DEPTH_STENCIL_DESC2
{
    public static ref readonly D3D12_DEPTH_STENCIL_DESC2 DEFAULT
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x02, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x08, 0x00, 0x00, 0x00,
                0xFF, 0xFF, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x01, 0x00, 0x00, 0x00,
                0x08, 0x00, 0x00, 0x00,
                0xFF, 0xFF, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00,
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<D3D12_DEPTH_STENCIL_DESC2>());
            return ref Unsafe.As<byte, D3D12_DEPTH_STENCIL_DESC2>(ref MemoryMarshal.GetReference(data));
        }
    }

    public D3D12_DEPTH_STENCIL_DESC2([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC1 &")] in D3D12_DEPTH_STENCIL_DESC1 o)
    {
        DepthEnable = o.DepthEnable;
        DepthWriteMask = o.DepthWriteMask;
        DepthFunc = o.DepthFunc;
        StencilEnable = o.StencilEnable;
        FrontFace.StencilFailOp = o.FrontFace.StencilFailOp;
        FrontFace.StencilDepthFailOp = o.FrontFace.StencilDepthFailOp;
        FrontFace.StencilPassOp = o.FrontFace.StencilPassOp;
        FrontFace.StencilFunc = o.FrontFace.StencilFunc;
        FrontFace.StencilReadMask = o.StencilReadMask;
        FrontFace.StencilWriteMask = o.StencilWriteMask;
        BackFace.StencilFailOp = o.BackFace.StencilFailOp;
        BackFace.StencilDepthFailOp = o.BackFace.StencilDepthFailOp;
        BackFace.StencilPassOp = o.BackFace.StencilPassOp;
        BackFace.StencilFunc = o.BackFace.StencilFunc;
        BackFace.StencilReadMask = o.StencilReadMask;
        BackFace.StencilWriteMask = o.StencilWriteMask;
        DepthBoundsTestEnable = o.DepthBoundsTestEnable;
    }

    public D3D12_DEPTH_STENCIL_DESC2([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC &")] in D3D12_DEPTH_STENCIL_DESC o)
    {
        DepthEnable = o.DepthEnable;
        DepthWriteMask = o.DepthWriteMask;
        DepthFunc = o.DepthFunc;
        StencilEnable = o.StencilEnable;
        FrontFace.StencilFailOp = o.FrontFace.StencilFailOp;
        FrontFace.StencilDepthFailOp = o.FrontFace.StencilDepthFailOp;
        FrontFace.StencilPassOp = o.FrontFace.StencilPassOp;
        FrontFace.StencilFunc = o.FrontFace.StencilFunc;
        FrontFace.StencilReadMask = o.StencilReadMask;
        FrontFace.StencilWriteMask = o.StencilWriteMask;
        BackFace.StencilFailOp = o.BackFace.StencilFailOp;
        BackFace.StencilDepthFailOp = o.BackFace.StencilDepthFailOp;
        BackFace.StencilPassOp = o.BackFace.StencilPassOp;
        BackFace.StencilFunc = o.BackFace.StencilFunc;
        BackFace.StencilReadMask = o.StencilReadMask;
        BackFace.StencilWriteMask = o.StencilWriteMask;
        DepthBoundsTestEnable = 0;
    }

    public D3D12_DEPTH_STENCIL_DESC2(BOOL depthEnable, D3D12_DEPTH_WRITE_MASK depthWriteMask, D3D12_COMPARISON_FUNC depthFunc, BOOL stencilEnable, D3D12_STENCIL_OP frontStencilFailOp, D3D12_STENCIL_OP frontStencilDepthFailOp, D3D12_STENCIL_OP frontStencilPassOp, D3D12_COMPARISON_FUNC frontStencilFunc, [NativeTypeName("UINT8")] byte frontStencilReadMask, [NativeTypeName("UINT8")] byte frontStencilWriteMask, D3D12_STENCIL_OP backStencilFailOp, D3D12_STENCIL_OP backStencilDepthFailOp, D3D12_STENCIL_OP backStencilPassOp, D3D12_COMPARISON_FUNC backStencilFunc, [NativeTypeName("UINT8")] byte backStencilReadMask, [NativeTypeName("UINT8")] byte backStencilWriteMask, BOOL depthBoundsTestEnable)
    {
        DepthEnable = depthEnable;
        DepthWriteMask = depthWriteMask;
        DepthFunc = depthFunc;
        StencilEnable = stencilEnable;
        FrontFace.StencilFailOp = frontStencilFailOp;
        FrontFace.StencilDepthFailOp = frontStencilDepthFailOp;
        FrontFace.StencilPassOp = frontStencilPassOp;
        FrontFace.StencilFunc = frontStencilFunc;
        FrontFace.StencilReadMask = frontStencilReadMask;
        FrontFace.StencilWriteMask = frontStencilWriteMask;
        BackFace.StencilFailOp = backStencilFailOp;
        BackFace.StencilDepthFailOp = backStencilDepthFailOp;
        BackFace.StencilPassOp = backStencilPassOp;
        BackFace.StencilFunc = backStencilFunc;
        BackFace.StencilReadMask = backStencilReadMask;
        BackFace.StencilWriteMask = backStencilWriteMask;
        DepthBoundsTestEnable = depthBoundsTestEnable;
    }

    public static explicit operator D3D12_DEPTH_STENCIL_DESC([NativeTypeName("const D3D12_DEPTH_STENCIL_DESC2 &")] in D3D12_DEPTH_STENCIL_DESC2 value)
    {
        D3D12_DEPTH_STENCIL_DESC D = new D3D12_DEPTH_STENCIL_DESC();

        D.DepthEnable = value.DepthEnable;
        D.DepthWriteMask = value.DepthWriteMask;
        D.DepthFunc = value.DepthFunc;
        D.StencilEnable = value.StencilEnable;
        D.StencilReadMask = value.FrontFace.StencilReadMask;
        D.StencilWriteMask = value.FrontFace.StencilWriteMask;
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
