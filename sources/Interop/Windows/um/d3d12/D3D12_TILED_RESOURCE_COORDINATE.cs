// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct D3D12_TILED_RESOURCE_COORDINATE
    {
        #region Fields
        [NativeTypeName("UINT")]
        public uint X;

        [NativeTypeName("UINT")]
        public uint Y;

        [NativeTypeName("UINT")]
        public uint Z;

        [NativeTypeName("UINT")]
        public uint Subresource;
        #endregion

        #region Constructors
        public D3D12_TILED_RESOURCE_COORDINATE(uint x, uint y, uint z, uint subresource)
        {
            X = x;
            Y = y;
            Z = z;
            Subresource = subresource;
        }
        #endregion
    }
}
