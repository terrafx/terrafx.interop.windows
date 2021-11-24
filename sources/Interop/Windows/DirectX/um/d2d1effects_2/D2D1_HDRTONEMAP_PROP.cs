// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public enum D2D1_HDRTONEMAP_PROP : uint
{
    D2D1_HDRTONEMAP_PROP_INPUT_MAX_LUMINANCE = 0,
    D2D1_HDRTONEMAP_PROP_OUTPUT_MAX_LUMINANCE = 1,
    D2D1_HDRTONEMAP_PROP_DISPLAY_MODE = 2,
    D2D1_HDRTONEMAP_PROP_FORCE_DWORD = 0xffffffff,
}
