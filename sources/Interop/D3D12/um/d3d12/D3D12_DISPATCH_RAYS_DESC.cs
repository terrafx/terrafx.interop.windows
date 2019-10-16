// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_DISPATCH_RAYS_DESC
    {
        public D3D12_GPU_VIRTUAL_ADDRESS_RANGE RayGenerationShaderRecord;

        public D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE MissShaderTable;

        public D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE HitGroupTable;

        public D3D12_GPU_VIRTUAL_ADDRESS_RANGE_AND_STRIDE CallableShaderTable;

        [NativeTypeName("UINT")]
        public uint Width;

        [NativeTypeName("UINT")]
        public uint Height;

        [NativeTypeName("UINT")]
        public uint Depth;
    }
}
