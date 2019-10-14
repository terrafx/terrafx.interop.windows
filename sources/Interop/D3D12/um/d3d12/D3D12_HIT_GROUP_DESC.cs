// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_HIT_GROUP_DESC
    {
        [NativeTypeName("LPCWSTR")]
        public ushort* HitGroupExport;

        public D3D12_HIT_GROUP_TYPE Type;

        [NativeTypeName("LPCWSTR")]
        public ushort* AnyHitShaderImport;

        [NativeTypeName("LPCWSTR")]
        public ushort* ClosestHitShaderImport;

        [NativeTypeName("LPCWSTR")]
        public ushort* IntersectionShaderImport;
    }
}
