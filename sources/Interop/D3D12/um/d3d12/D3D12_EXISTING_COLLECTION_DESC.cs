// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_EXISTING_COLLECTION_DESC
    {
        [NativeTypeName("ID3D12StateObject *")]
        public ID3D12StateObject* pExistingCollection;

        [NativeTypeName("UINT")]
        public uint NumExports;

        [NativeTypeName("D3D12_EXPORT_DESC *")]
        public D3D12_EXPORT_DESC* pExports;
    }
}
