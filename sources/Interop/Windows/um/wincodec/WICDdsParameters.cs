// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wincodec.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public struct WICDdsParameters
    {
        #region Fields
        [NativeTypeName("UINT")]
        public uint Width;

        [NativeTypeName("UINT")]
        public uint Height;

        [NativeTypeName("UINT")]
        public uint Depth;

        [NativeTypeName("UINT")]
        public uint MipLevels;

        [NativeTypeName("UINT")]
        public uint ArraySize;

        public DXGI_FORMAT DxgiFormat;

        public WICDdsDimension Dimension;

        public WICDdsAlphaMode AlphaMode;
        #endregion
    }
}
