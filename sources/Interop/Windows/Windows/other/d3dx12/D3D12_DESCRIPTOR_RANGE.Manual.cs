// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct D3D12_DESCRIPTOR_RANGE
    {
        public D3D12_DESCRIPTOR_RANGE(D3D12_DESCRIPTOR_RANGE_TYPE rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
        {
            Init(out this, rangeType, numDescriptors, baseShaderRegister, registerSpace, offsetInDescriptorsFromTableStart);
        }

        public void Init(D3D12_DESCRIPTOR_RANGE_TYPE rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
        {
            Init(out this, rangeType, numDescriptors, baseShaderRegister, registerSpace, offsetInDescriptorsFromTableStart);
        }

        public static void Init([NativeTypeName("D3D12_DESCRIPTOR_RANGE &")] out D3D12_DESCRIPTOR_RANGE range, D3D12_DESCRIPTOR_RANGE_TYPE rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
        {
            range.RangeType = rangeType;
            range.NumDescriptors = numDescriptors;
            range.BaseShaderRegister = baseShaderRegister;
            range.RegisterSpace = registerSpace;
            range.OffsetInDescriptorsFromTableStart = offsetInDescriptorsFromTableStart;
        }
    }
}
