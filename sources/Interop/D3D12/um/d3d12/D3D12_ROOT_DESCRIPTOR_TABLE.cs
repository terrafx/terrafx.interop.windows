// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_ROOT_DESCRIPTOR_TABLE
    {
        [NativeTypeName("UINT")]
        public uint NumDescriptorRanges;

        [NativeTypeName("D3D12_DESCRIPTOR_RANGE[]")]
        public D3D12_DESCRIPTOR_RANGE* pDescriptorRanges;

        public D3D12_ROOT_DESCRIPTOR_TABLE(uint numDescriptorRanges, D3D12_DESCRIPTOR_RANGE* _pDescriptorRanges)
        {
            fixed (D3D12_ROOT_DESCRIPTOR_TABLE* pThis = &this)
            {
                Init(pThis, numDescriptorRanges, _pDescriptorRanges);
            }
        }

        public static void Init(D3D12_ROOT_DESCRIPTOR_TABLE* rootDescriptorTable, uint numDescriptorRanges, D3D12_DESCRIPTOR_RANGE* _pDescriptorRanges)
        {
            rootDescriptorTable->NumDescriptorRanges = numDescriptorRanges;
            rootDescriptorTable->pDescriptorRanges = _pDescriptorRanges;


        }

        public void Init(uint numDescriptorRanges, D3D12_DESCRIPTOR_RANGE* _pDescriptorRanges)
        {
            fixed (D3D12_ROOT_DESCRIPTOR_TABLE* pThis = &this)
            {
                Init(pThis, numDescriptorRanges, _pDescriptorRanges);
            }
        }
    }
}
