// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe struct D3D12_COMPUTE_PIPELINE_STATE_DESC
    {
        #region Fields
        public ID3D12RootSignature* pRootSignature;

        public D3D12_SHADER_BYTECODE CS;

        [NativeTypeName("UINT")]
        public uint NodeMask;

        public D3D12_CACHED_PIPELINE_STATE CachedPSO;

        public D3D12_PIPELINE_STATE_FLAGS Flags;
        #endregion
    }
}
