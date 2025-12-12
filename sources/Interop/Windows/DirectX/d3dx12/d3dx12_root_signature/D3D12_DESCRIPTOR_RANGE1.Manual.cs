// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_root_signature.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using static TerraFX.Interop.DirectX.D3D12_DESCRIPTOR_RANGE_FLAGS;

namespace TerraFX.Interop.DirectX;

public unsafe partial struct D3D12_DESCRIPTOR_RANGE1
{
    public D3D12_DESCRIPTOR_RANGE1(D3D12_DESCRIPTOR_RANGE_TYPE rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, D3D12_DESCRIPTOR_RANGE_FLAGS flags = D3D12_DESCRIPTOR_RANGE_FLAG_NONE, uint offsetInDescriptorsFromTableStart = (0xffffffff))
    {
        Init(rangeType, numDescriptors, baseShaderRegister, registerSpace, flags, offsetInDescriptorsFromTableStart);
    }

    public void Init(D3D12_DESCRIPTOR_RANGE_TYPE rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, D3D12_DESCRIPTOR_RANGE_FLAGS flags = D3D12_DESCRIPTOR_RANGE_FLAG_NONE, uint offsetInDescriptorsFromTableStart = (0xffffffff))
    {
        Init(ref this, rangeType, numDescriptors, baseShaderRegister, registerSpace, flags, offsetInDescriptorsFromTableStart);
    }

    public static void Init([NativeTypeName("D3D12_DESCRIPTOR_RANGE1 &")] ref D3D12_DESCRIPTOR_RANGE1 range, D3D12_DESCRIPTOR_RANGE_TYPE rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, D3D12_DESCRIPTOR_RANGE_FLAGS flags = D3D12_DESCRIPTOR_RANGE_FLAG_NONE, uint offsetInDescriptorsFromTableStart = (0xffffffff))
    {
        range.RangeType = rangeType;
        range.NumDescriptors = numDescriptors;
        range.BaseShaderRegister = baseShaderRegister;
        range.RegisterSpace = registerSpace;
        range.Flags = flags;
        range.OffsetInDescriptorsFromTableStart = offsetInDescriptorsFromTableStart;
    }
}
