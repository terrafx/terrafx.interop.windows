// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_SUBOBJECT_TO_EXPORTS_ASSOCIATION
    {
        [NativeTypeName("const D3D12_STATE_SUBOBJECT *")]
        public D3D12_STATE_SUBOBJECT* pSubobjectToAssociate;

        [NativeTypeName("UINT")]
        public uint NumExports;

        [NativeTypeName("LPCWSTR *")]
        public ushort** pExports;
    }
}
