// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;
using static TerraFX.Interop.D3D12;

namespace TerraFX.Interop
{
    [Unmanaged]
    public unsafe struct D3D12_DESCRIPTOR_RANGE
    {
        #region Fields
        public D3D12_DESCRIPTOR_RANGE_TYPE RangeType;

        [NativeTypeName("UINT")]
        public uint NumDescriptors;

        [NativeTypeName("UINT")]
        public uint BaseShaderRegister;

        [NativeTypeName("UINT")]
        public uint RegisterSpace;

        [NativeTypeName("UINT")]
        public uint OffsetInDescriptorsFromTableStart;
        #endregion

        #region Constructors
        public D3D12_DESCRIPTOR_RANGE(D3D12_DESCRIPTOR_RANGE_TYPE rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
        {
            fixed (D3D12_DESCRIPTOR_RANGE* pThis = &this)
            {
                Init(pThis, rangeType, numDescriptors, baseShaderRegister, registerSpace, offsetInDescriptorsFromTableStart);
            }
        }
        #endregion

        #region Methods
        public static void Init(D3D12_DESCRIPTOR_RANGE* range, D3D12_DESCRIPTOR_RANGE_TYPE rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
        {
            range->RangeType = rangeType;
            range->NumDescriptors = numDescriptors;
            range->BaseShaderRegister = baseShaderRegister;
            range->RegisterSpace = registerSpace;
            range->OffsetInDescriptorsFromTableStart = offsetInDescriptorsFromTableStart;
        }

        public void Init(D3D12_DESCRIPTOR_RANGE_TYPE rangeType, uint numDescriptors, uint baseShaderRegister, uint registerSpace = 0, uint offsetInDescriptorsFromTableStart = D3D12_DESCRIPTOR_RANGE_OFFSET_APPEND)
        {
            fixed (D3D12_DESCRIPTOR_RANGE* pThis = &this)
            {
                Init(pThis, rangeType, numDescriptors, baseShaderRegister, registerSpace, offsetInDescriptorsFromTableStart);
            }
        }
        #endregion
    }
}
