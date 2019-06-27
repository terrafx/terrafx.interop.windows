// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public struct D3D12_FEATURE_DATA_ARCHITECTURE1
    {
        #region Fields
        [NativeTypeName("UINT")]
        public uint NodeIndex;

        [NativeTypeName("BOOL")]
        public int TileBasedRenderer;

        [NativeTypeName("BOOL")]
        public int UMA;

        [NativeTypeName("BOOL")]
        public int CacheCoherentUMA;

        [NativeTypeName("BOOL")]
        public int IsolatedMMU;
        #endregion
    }
}
