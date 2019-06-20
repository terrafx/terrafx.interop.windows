// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct D3D12_TEX2D_SRV
    {
        #region Fields
        [NativeTypeName("UINT")]
        public uint MostDetailedMip;

        [NativeTypeName("UINT")]
        public uint MipLevels;

        [NativeTypeName("UINT")]
        public uint PlaneSlice;

        [NativeTypeName("FLOAT")]
        public float ResourceMinLODClamp;
        #endregion
    }
}
