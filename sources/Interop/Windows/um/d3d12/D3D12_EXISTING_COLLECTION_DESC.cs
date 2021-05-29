// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_EXISTING_COLLECTION_DESC
    {
        public ID3D12StateObject* pExistingCollection;

        [NativeTypeName("UINT")]
        public uint NumExports;

        public D3D12_EXPORT_DESC* pExports;
    }
}
