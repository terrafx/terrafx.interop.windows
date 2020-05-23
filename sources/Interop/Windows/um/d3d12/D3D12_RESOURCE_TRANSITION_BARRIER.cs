// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_RESOURCE_TRANSITION_BARRIER
    {
        [NativeTypeName("ID3D12Resource *")]
        public ID3D12Resource* pResource;

        [NativeTypeName("UINT")]
        public uint Subresource;

        public D3D12_RESOURCE_STATES StateBefore;

        public D3D12_RESOURCE_STATES StateAfter;
    }
}
