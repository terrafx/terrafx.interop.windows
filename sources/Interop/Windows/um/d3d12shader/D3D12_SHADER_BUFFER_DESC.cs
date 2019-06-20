// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12shader.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public unsafe struct D3D12_SHADER_BUFFER_DESC
    {
        #region Fields
        [NativeTypeName("LPCSTR")]
        public sbyte* Name;

        public D3D_CBUFFER_TYPE Type;

        [NativeTypeName("UINT")]
        public uint Variables;

        [NativeTypeName("UINT")]
        public uint Size;

        [NativeTypeName("UINT")]
        public uint uFlags;
        #endregion
    }
}
