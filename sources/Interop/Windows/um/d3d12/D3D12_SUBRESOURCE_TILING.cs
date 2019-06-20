// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct D3D12_SUBRESOURCE_TILING
    {
        #region Fields
        [NativeTypeName("UINT")]
        public uint WidthInTiles;

        [NativeTypeName("UINT16")]
        public ushort HeightInTiles;

        [NativeTypeName("UINT16")]
        public ushort DepthInTiles;

        [NativeTypeName("UINT")]
        public uint StartTileIndexInOverallResource;
        #endregion

        #region Constructors
        public D3D12_SUBRESOURCE_TILING(uint widthInTiles, ushort heightInTiles, ushort depthInTiles, uint startTileIndexInOverallResource)
        {
            WidthInTiles = widthInTiles;
            HeightInTiles = heightInTiles;
            DepthInTiles = depthInTiles;
            StartTileIndexInOverallResource = startTileIndexInOverallResource;
        }
        #endregion
    }
}
