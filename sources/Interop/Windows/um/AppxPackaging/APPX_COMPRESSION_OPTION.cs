// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum APPX_COMPRESSION_OPTION
    {
        APPX_COMPRESSION_OPTION_NONE = 0,
        APPX_COMPRESSION_OPTION_NORMAL = 1,
        APPX_COMPRESSION_OPTION_MAXIMUM = 2,
        APPX_COMPRESSION_OPTION_FAST = 3,
        APPX_COMPRESSION_OPTION_SUPERFAST = 4,
    }
}
