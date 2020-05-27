// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_DESCRIPTOR_RANGE
    {
        public D3D12_DESCRIPTOR_RANGE(D3D12_DESCRIPTOR_RANGE_TYPE rangeType, [NativeTypeName("UINT")] uint numDescriptors, [NativeTypeName("UINT")] uint baseShaderRegister, [NativeTypeName("UINT")] uint registerSpace = 0, [NativeTypeName("UINT")] uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
        {
            Init(out this, rangeType, numDescriptors, baseShaderRegister, registerSpace, offsetInDescriptorsFromTableStart);
        }

        public void Init(D3D12_DESCRIPTOR_RANGE_TYPE rangeType, [NativeTypeName("UINT")] uint numDescriptors, [NativeTypeName("UINT")] uint baseShaderRegister, [NativeTypeName("UINT")] uint registerSpace = 0, [NativeTypeName("UINT")] uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
        {
            Init(out this, rangeType, numDescriptors, baseShaderRegister, registerSpace, offsetInDescriptorsFromTableStart);
        }

        public static void Init([NativeTypeName("D3D12_DESCRIPTOR_RANGE &")] out D3D12_DESCRIPTOR_RANGE range, D3D12_DESCRIPTOR_RANGE_TYPE rangeType, [NativeTypeName("UINT")] uint numDescriptors, [NativeTypeName("UINT")] uint baseShaderRegister, [NativeTypeName("UINT")] uint registerSpace = 0, [NativeTypeName("UINT")] uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
        {
            range.RangeType = rangeType;
            range.NumDescriptors = numDescriptors;
            range.BaseShaderRegister = baseShaderRegister;
            range.RegisterSpace = registerSpace;
            range.OffsetInDescriptorsFromTableStart = offsetInDescriptorsFromTableStart;
        }
    }
}
