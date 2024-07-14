// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RT_FORMAT_ARRAY.xml' path='doc/member[@name="D3D12_RT_FORMAT_ARRAY"]/*' />
[NativeTypeName("struct CD3DX12_RT_FORMAT_ARRAY : D3D12_RT_FORMAT_ARRAY")]
[NativeInheritance("D3D12_RT_FORMAT_ARRAY")]
public unsafe partial struct D3D12_RT_FORMAT_ARRAY
{
    public D3D12_RT_FORMAT_ARRAY([NativeTypeName("const DXGI_FORMAT *")] DXGI_FORMAT* pFormats, uint NumFormats)
    {
        NumRenderTargets = NumFormats;

        fixed (DXGI_FORMAT* pRTFormats = &RTFormats[0])
        {
            NativeMemory.Copy(pFormats, pRTFormats, sizeof(DXGI_FORMAT));
        }
    }
}
