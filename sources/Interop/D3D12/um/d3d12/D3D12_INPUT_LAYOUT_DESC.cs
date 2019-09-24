// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe struct D3D12_INPUT_LAYOUT_DESC
    {
        [NativeTypeName("D3D12_INPUT_ELEMENT_DESC[]")]
        public D3D12_INPUT_ELEMENT_DESC* pInputElementDescs;

        [NativeTypeName("UINT")]
        public uint NumElements;
    }
}
