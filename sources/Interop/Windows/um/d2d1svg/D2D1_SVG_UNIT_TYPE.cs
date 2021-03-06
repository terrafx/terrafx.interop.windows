// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_SVG_UNIT_TYPE : uint
    {
        D2D1_SVG_UNIT_TYPE_USER_SPACE_ON_USE = 0,
        D2D1_SVG_UNIT_TYPE_OBJECT_BOUNDING_BOX = 1,
        D2D1_SVG_UNIT_TYPE_FORCE_DWORD = 0xffffffff,
    }
}
