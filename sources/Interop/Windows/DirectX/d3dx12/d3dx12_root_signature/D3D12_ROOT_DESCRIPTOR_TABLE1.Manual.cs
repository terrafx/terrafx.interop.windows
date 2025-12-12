// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D12_ROOT_DESCRIPTOR_TABLE1
{
    public D3D12_ROOT_DESCRIPTOR_TABLE1(uint numDescriptorRanges, [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")] D3D12_DESCRIPTOR_RANGE1* _pDescriptorRanges)
    {
        Init(numDescriptorRanges, _pDescriptorRanges);
    }

    public void Init(uint numDescriptorRanges, [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")] D3D12_DESCRIPTOR_RANGE1* _pDescriptorRanges)
    {
        Init(ref this, numDescriptorRanges, _pDescriptorRanges);
    }

    public static void Init([NativeTypeName("D3D12_ROOT_DESCRIPTOR_TABLE1 &")] ref D3D12_ROOT_DESCRIPTOR_TABLE1 rootDescriptorTable, uint numDescriptorRanges, [NativeTypeName("const D3D12_DESCRIPTOR_RANGE1 *")] D3D12_DESCRIPTOR_RANGE1* _pDescriptorRanges)
    {
        rootDescriptorTable.NumDescriptorRanges = numDescriptorRanges;
        rootDescriptorTable.pDescriptorRanges = _pDescriptorRanges;
    }
}
