// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.1")]
    public enum WICDdsDimension
    {
        WICDdsTexture1D = 0,
        WICDdsTexture2D = 0x1,
        WICDdsTexture3D = 0x2,
        WICDdsTextureCube = 0x3,
        WICDDSTEXTURE_FORCE_DWORD = 0x7fffffff,
    }
}
