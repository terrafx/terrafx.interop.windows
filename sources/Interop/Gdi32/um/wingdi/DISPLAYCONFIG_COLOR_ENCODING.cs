// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("int")]
    public enum DISPLAYCONFIG_COLOR_ENCODING : uint
    {
        DISPLAYCONFIG_COLOR_ENCODING_RGB = 0,
        DISPLAYCONFIG_COLOR_ENCODING_YCBCR444 = 1,
        DISPLAYCONFIG_COLOR_ENCODING_YCBCR422 = 2,
        DISPLAYCONFIG_COLOR_ENCODING_YCBCR420 = 3,
        DISPLAYCONFIG_COLOR_ENCODING_INTENSITY = 4,
        DISPLAYCONFIG_COLOR_ENCODING_FORCE_UINT32 = 0xFFFFFFFF,
    }
}
