// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows10.0.14393.0")]
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
