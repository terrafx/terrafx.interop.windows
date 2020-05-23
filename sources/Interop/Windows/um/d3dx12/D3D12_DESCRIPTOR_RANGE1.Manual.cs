// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in DirectX-Graphics-Samples commit a7a87f1853b5540f10920518021d91ae641033fb
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D3D12;
using static TerraFX.Interop.D3D12_DESCRIPTOR_RANGE_FLAGS;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_DESCRIPTOR_RANGE1
    {
        public D3D12_DESCRIPTOR_RANGE1(D3D12_DESCRIPTOR_RANGE_TYPE rangeType, [NativeTypeName("UINT")] uint numDescriptors, [NativeTypeName("UINT")] uint baseShaderRegister, [NativeTypeName("UINT")] uint registerSpace = 0, D3D12_DESCRIPTOR_RANGE_FLAGS flags = D3D12_DESCRIPTOR_RANGE_FLAG_NONE, [NativeTypeName("UINT")] uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
        {
            Init(out this, rangeType, numDescriptors, baseShaderRegister, registerSpace, flags, offsetInDescriptorsFromTableStart);
        }

        public void Init(D3D12_DESCRIPTOR_RANGE_TYPE rangeType, [NativeTypeName("UINT")] uint numDescriptors, [NativeTypeName("UINT")] uint baseShaderRegister, [NativeTypeName("UINT")] uint registerSpace = 0, D3D12_DESCRIPTOR_RANGE_FLAGS flags = D3D12_DESCRIPTOR_RANGE_FLAG_NONE, [NativeTypeName("UINT")] uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
        {
            Init(out this, rangeType, numDescriptors, baseShaderRegister, registerSpace, flags, offsetInDescriptorsFromTableStart);
        }

        public static void Init([NativeTypeName("D3D12_DESCRIPTOR_RANGE1 &")] out D3D12_DESCRIPTOR_RANGE1 range, D3D12_DESCRIPTOR_RANGE_TYPE rangeType, [NativeTypeName("UINT")] uint numDescriptors, [NativeTypeName("UINT")] uint baseShaderRegister, [NativeTypeName("UINT")] uint registerSpace = 0, D3D12_DESCRIPTOR_RANGE_FLAGS flags = D3D12_DESCRIPTOR_RANGE_FLAG_NONE, [NativeTypeName("UINT")] uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
        {
            range.RangeType = rangeType;
            range.NumDescriptors = numDescriptors;
            range.BaseShaderRegister = baseShaderRegister;
            range.RegisterSpace = registerSpace;
            range.Flags = flags;
            range.OffsetInDescriptorsFromTableStart = offsetInDescriptorsFromTableStart;
        }
    }
}
