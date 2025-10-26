// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_core.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_RANGE_UINT64.xml' path='doc/member[@name="D3D12_RANGE_UINT64"]/*' />
[NativeTypeName("struct CD3DX12_RANGE_UINT64 : D3D12_RANGE_UINT64")]
[NativeInheritance("D3D12_RANGE_UINT64")]
public partial struct D3D12_RANGE_UINT64
{
    public D3D12_RANGE_UINT64([NativeTypeName("UINT64")] ulong begin, [NativeTypeName("UINT64")] ulong end)
    {
        Begin = begin;
        End = end;
    }
}
