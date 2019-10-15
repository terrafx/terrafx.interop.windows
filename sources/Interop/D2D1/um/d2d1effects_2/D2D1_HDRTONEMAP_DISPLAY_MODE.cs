// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_HDRTONEMAP_DISPLAY_MODE : uint
    {
        D2D1_HDRTONEMAP_DISPLAY_MODE_SDR = 0,
        D2D1_HDRTONEMAP_DISPLAY_MODE_HDR = 1,
        D2D1_HDRTONEMAP_DISPLAY_MODE_FORCE_DWORD = 0xFFFFFFFF,
    }
}
