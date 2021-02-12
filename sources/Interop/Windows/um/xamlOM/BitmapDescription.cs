// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct BitmapDescription
    {
        [NativeTypeName("unsigned int")]
        public uint Width;

        [NativeTypeName("unsigned int")]
        public uint Height;

        public DXGI_FORMAT Format;

        public DXGI_ALPHA_MODE AlphaMode;
    }
}
